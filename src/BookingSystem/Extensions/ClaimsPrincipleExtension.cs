namespace System.Security.Claims
{
    using static BookingSystem.Core.Constants.AdministratorConstants;
    public static class ClaimsPrincipleExtension
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(AdminRole);
        }
    }
}
