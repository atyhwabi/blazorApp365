using System.Security.Claims;

namespace ECSM.Models.DTO
{
    public class AuthModel
    {
        public bool IsAuthenticated { get; set; } = false;
        public ClaimsPrincipal user { get; set; } = new ClaimsPrincipal();
        public ContactReturnDTO Contact { get; set; } = new ContactReturnDTO();
        public List<UserRoleDTO> Roles { get; set; } = new List<UserRoleDTO>();
        public string IDP { get; set; } = string.Empty;
    }
}
