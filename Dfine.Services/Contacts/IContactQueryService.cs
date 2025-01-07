using ECSM.Models;
using OneOf.Types;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECSM.Models.DTO;

namespace ECSM.Services
{
    public interface IContactQueryService
    {
        Task<ContactReturnDTO> GetContactByADObjectID(string objID);
        Task<ContactReturnDTO> GetAnonContact();
    }
}
