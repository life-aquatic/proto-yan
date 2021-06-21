using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proto.Models
{
    public class SelectModel
    {
        public string SelectedValue1 { get; set;}
        public string SelectedValue2 { get; set;}
        public IEnumerable<SelectListItem> Items { get; set; } = new List<SelectListItem>
        { 
            new SelectListItem {Value = "dollar", Text= "DollaR"},
            new SelectListItem {Value = "euro", Text= "EvRRRo"},
            new SelectListItem {Value = "ruble", Text= "RRuble"}
        };
    }
}
