namespace BookingSystem.Middlewares
{
    using Microsoft.Extensions.Caching.Memory;
    using System.Collections.Concurrent;
    using System.Security.Claims;
    using static BookingSystem.Core.Constants.GeneralApplicationConstants;
    public class OnlineUsersMiddleware
    {
        private readonly RequestDelegate next;
        private readonly string cookieName;
        private readonly int lastActivityMinutes;

        private static readonly ConcurrentDictionary<string, bool> AllKeys = 
            new ConcurrentDictionary<string, bool>();
        public OnlineUsersMiddleware(RequestDelegate next, 
            string cookieName = OnlineUsersCookieName,
            int lastActivityMinutes = LastActivityBeforeOfflineMinutes)
        {
            this.next = next;
            this.cookieName = cookieName;
            this.lastActivityMinutes = lastActivityMinutes;
        }

        public Task InvokeAsync(HttpContext context, IMemoryCache memoryCache)
        {
            if(context.User.Identity?.IsAuthenticated ?? false)
            {
                if(!context.Request.Cookies.TryGetValue(cookieName, out string? userId))
                {
                    //First login after being offline
                    userId = context.User.GetUserId();

                    context.Response.Cookies.Append(cookieName, userId, 
                        new CookieOptions()
                    { 
                        HttpOnly = true,
                        MaxAge = TimeSpan.FromDays(30)
                    });
                }

                memoryCache.GetOrCreate(userId, cacheEntry =>
                {
                    if (!AllKeys.TryAdd(userId!, true))
                    {
                        //Adding key failed to the concurrent dictionary so we have an error
                        cacheEntry.AbsoluteExpiration = DateTimeOffset.MinValue;
                    }
                    else
                    {
                        cacheEntry.SlidingExpiration = TimeSpan.FromMinutes(lastActivityMinutes);
                        cacheEntry.RegisterPostEvictionCallback(RemoveKeyWhenExpired);
                    }

                    return string.Empty;
                });
            }
            else
            {
                //User has just logged out
                if(context.Request.Cookies.TryGetValue(cookieName, out string? userId))
                {
                    if(AllKeys.TryRemove(userId!, out _))
                    {
                        AllKeys.TryUpdate(userId!, false, true);
                    }

                    context.Response.Cookies.Delete(cookieName);
                }
            }

            return next(context);
        }

        public static bool CheckIfUserIsOnline(string userId)
        {
            bool valueTaken = AllKeys.TryGetValue(userId.ToLower(), out bool success);

            return success && valueTaken;
        }
        private void RemoveKeyWhenExpired(object key, object value, EvictionReason reason, object state)
        {
            string keyStr = (string)key; //UserId

            if(!AllKeys.TryRemove(keyStr,out _))
            {
                AllKeys.TryUpdate(keyStr, false, true);
            }
        }
    }
}
