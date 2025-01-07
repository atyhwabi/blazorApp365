using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO
{
  public class PanelBarItem
  {
    public Guid? Id { get; set; }
    public string Text { get; set; }
    public string Url { get; set; }
    public Guid? Parent { get; set; }
    public bool HasChildren { get; set; }
  }
}
