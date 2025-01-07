using ECSM.Models.DTO;
using ECSM.Models.DTO.Announcement;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Services
{
    public interface IAnnouncementQueryService
    {
        Task<AnnouncementDTO[]> GetAnnouncementsForHome();
    }
}
