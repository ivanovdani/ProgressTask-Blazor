using BlazorComponents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Models
{
    public class MenuItem : IMenuItem
    {
        public string Text { get; set; }

        public List<IMenuItem> Children { get; set; }

        public int ID { get; set; }
    }
}
