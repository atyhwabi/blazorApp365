using EC.DynamicsClient;
using ECSM.Models.DTO;
using ECSM.Models.DTO.Announcement;
using ECSM.Models.Dynamics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Services
{
    public class AnnouncementQueryService(IDynamicsQueryClient queryClient) : IAnnouncementQueryService
    {
        readonly IDynamicsQueryClient queryClient = queryClient.ThrowIfNull();

        /// <summary>
        /// Gets Announcement Item
        /// </summary>
        /// <returns>Announcement</returns>
        /// <exception cref="Exception"></exception>
        public async Task<AnnouncementDTO[]> GetAnnouncementsForHome()
        {
            try
            {
                var response = await queryClient
                .Get<ecsm_announcement>(ecsm_announcementField.LogicalCollectionName
                .Query()
                .Select([
                    ecsm_announcementField.ecsm_announcementId,
                    ecsm_announcementField.ecsm_Name,
                    ecsm_announcementField.ecsm_announcement_body,
                    ecsm_announcementField.ecsm_announcement_type,
                    ecsm_announcementField.ecsm_AddtoHome,
                    ecsm_announcementField.ecsm_expiry_date,
                ])
                .Where([
                    ecsm_announcementField.ecsm_AddtoHome.Equal(true),
                    ecsm_announcementField.ecsm_expiry_date.Greater_Than_Or_Equal(DateTime.Now),
                    ecsm_announcementField.statecode.Equal(ecsm_announcement_statecode.Active)
                ])
                .Build()).ConfigureAwait(false);
                if (response is null or { Entities: null or { Length: <= 0 } })
                {
                    return [];
                }

                return response.Entities
                    .Where(e => e.ecsm_announcementId.HasValue)
                    .Select(e => new AnnouncementDTO
                    {
                      Id = e.ecsm_announcementId!.Value,
                      Title = e.ecsm_Name ?? "",
                      AnnouncementType = (int)e.ecsm_announcement_type!,
                      AddToHome = e.ecsm_AddtoHome ?? false,
                      Body = e.ecsm_announcement_body ?? "",
                      ExpiryDate = e.ecsm_expiry_date ?? DateTime.MinValue,
                    }
                    ).ToArray();
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                throw new Exception(error);
            }
        }
    }
}
