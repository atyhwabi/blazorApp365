using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO
{
    public class MessageCreateDTO
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public string CaseId { get; set; }
    }
}
