using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO.TreeView
{
  public class TreeItem
  {
    public Guid Id { get; set; }
    public string Text { get; set; }
    public Guid? ParentIdValue { get; set; }
    public bool HasChildren { get; set; }
    public bool Expanded { get; set; }
    public bool IsCategory { get; set; }
  }
}
