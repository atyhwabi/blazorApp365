using ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECSM.Models.DTO
{
  public class ContactReturnDTO
  {
    public Guid? ContactID { get; set; }

    public string FullName { get; set; } = string.Empty;

    public string FirstName { get; set; }
    [JsonPropertyName("ecsm_portal_role_Contact_Contact")]
    public List<UserRoleDTO> Rolles { get; set; }
  }
}
