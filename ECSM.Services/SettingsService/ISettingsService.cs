using ECSM.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Services.SettingsService
{
    public interface ISettingsService
    {
        Task<SettingsDTO> GetSettingByName(string name);
        Task<List<SettingsDTO>> GetAllSetting();
        Task<SettingsDTO> GetSettingByNameForLogoAsync(string logoprimary);
    }
}
