using EC.DynamicsClient;
using OneOf.Types;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ECSM.Models;
using ECSM.Models.DTO;
using ECSM.Models.Dynamics;
using ECSM.Services.SettingsService;

namespace ECSM.Services
{
    /// <summary>
    /// A service that provides access to user roles
    /// </summary>
    public sealed class UserRolesQueryService(IDynamicsQueryClient queryClient, ISettingsService settingsService) : IUserRolesQueryService
    {
        readonly IDynamicsQueryClient queryClient = queryClient.ThrowIfNull();
        readonly ISettingsService settingsService = settingsService.ThrowIfNull();

        /// <summary>
        /// Gets a List of User Roles
        /// </summary>
        /// <returns>User Roles</returns>
        /// <exception cref="FailedStatusCodeException"></exception>
        public async Task<List<UserRoleDTO>> GetUserRolesByID(List<UserRoleDTO> rolles)
        {
            try
            {
                var userRolles = new List<UserRoleDTO>();

                foreach(var role in rolles)
                {
                    var entityCollection = await queryClient
                    .Get<ecsm_portal_role>(ecsm_portal_roleField.LogicalCollectionName
                    .Query()
                    .Where([
                        ecsm_portal_roleField.ecsm_portal_roleId.Equal(role.RoleID.ToString()),
                        ecsm_portal_roleField.statecode.Equal(ecsm_portal_role_statecode.Active)
                    ])
                    .Select([
                        ecsm_portal_roleField.ecsm_portal_roleId,
                        ecsm_portal_roleField.ecsm_Name,
                        ecsm_portal_roleField.ecsm_description
                    ])
                    .Build()).ConfigureAwait(false);

                    if (entityCollection is null or { Entities: null or { Length: < 1 } })
                    {
                        return [];
                    }

                    userRolles.AddRange(entityCollection.Entities
                            .Select(e => new UserRoleDTO
                            {
                                RoleID = e.ecsm_portal_roleId,
                                RoleName = e.ecsm_Name ?? "",
                                Description = e.ecsm_description ?? ""
                            }).ToList());
                }

                return userRolles;
            }
            catch (FailedStatusCodeException exception)
            when (exception.Response.StatusCode is HttpStatusCode.InternalServerError)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Gets Anonaymous User Role
        /// </summary>
        /// <returns>User Role</returns>
        /// <exception cref="FailedStatusCodeException"></exception>
        public async Task<List<UserRoleDTO>> GetAnonUserRole()
        {
            try
            {
                var setting = await settingsService.GetSettingByName("AnonymousRoleID").ConfigureAwait(false);

                var entityCollection = await queryClient.Get<ecsm_portal_role>(ecsm_portal_roleField.EntitySetName
                    .Query()
                    .Where([
                        ecsm_portal_roleField.ecsm_Name.Equal(setting.Value),
                        ecsm_portal_roleField.statecode.Equal(ecsm_portal_role_statecode.Active)
                    ])
                    .Select([
                        ecsm_portal_roleField.ecsm_portal_roleId,
                        ecsm_portal_roleField.ecsm_Name,
                        ecsm_portal_roleField.ecsm_description
                    ])
                    .Build()).ConfigureAwait(false);

                if (entityCollection is null or { Entities: null or { Length: < 1 } })
                {
                    return [];
                }

                return entityCollection.Entities
                        .Select(e => new UserRoleDTO
                        {
                            RoleID = e.ecsm_portal_roleId,
                            RoleName = e.ecsm_Name ?? "",
                            Description = e.ecsm_description ?? ""
                        }).ToList();
            }
            catch (FailedStatusCodeException exception)
            when (exception.Response.StatusCode is HttpStatusCode.InternalServerError)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
