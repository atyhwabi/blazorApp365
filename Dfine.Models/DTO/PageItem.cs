﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSM.Models.DTO
{
    public class PageItem
    {
        public string Text { get; set; }
        public int PageIndex { get; set; }
        public bool Enabled { get; set; }
        public bool Active { get; set; }

        public PageItem( int pageIndex, bool enabled, string text)
        {
            PageIndex = pageIndex;
            Enabled = enabled;
            Text = text;
        }
    }
}
