using ECSM.Models.DTO.FormElement;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.Cases
{
  public class CaseAnswer
  {
    public Guid FormElementId { get; set; }

    public FormElementDTO FormElement { get; set; }

    public string Label { get; set; } = string.Empty;

    public string Answer { get; set; } = string.Empty;

    public int NumberAnswer { get; set; } 

    public decimal DecimalAnswer { get; set; }

    public string Tooltip { get; set; }

    public bool BoolAnswer { get; set; }

    public DateTime DateAnswer { get; set; } = DateTime.Now;

    public string fileName { get; set; } = string.Empty;

    public bool Required { get; set; }
  }
}
