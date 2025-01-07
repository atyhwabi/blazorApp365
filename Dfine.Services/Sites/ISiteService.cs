using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECSM.Models.DTO.Sites;

namespace ECSM.Services.Sites
{
  public interface ISiteService
  {
    Task<List<SiteDTO>> GetAllSites();
  }
}
