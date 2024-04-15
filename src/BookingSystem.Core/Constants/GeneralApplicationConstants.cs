namespace BookingSystem.Core.Constants
{
    public static class GeneralApplicationConstants
    {
        public const string OnlineUsersCookieName = "IsOnline";
        public const int LastActivityBeforeOfflineMinutes = 10;

        public const string UsersCacheKey = "UsersCache";
        public const int UsersCacheDurationMinutes = 5;

        public const string UserMessageSuccess = "UserMessageSuccess";
        public const string UserMessageError = "UserMessageError";
    }
}
