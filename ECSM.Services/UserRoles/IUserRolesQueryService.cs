using ECSM.Models;
using ECSM.Models.DTO;
using OneOf.Types;
using OneOf;


namespace ECSM.Services
{
    public interface IUserRolesQueryService
    {
        Task<List<UserRoleDTO>> GetUserRolesByID(List<UserRoleDTO> rolles);
        Task<List<UserRoleDTO>> GetAnonUserRole();
    }
}
