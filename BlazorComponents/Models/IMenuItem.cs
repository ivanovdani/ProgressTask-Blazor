using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorComponents.Models
{
    public interface IMenuItem
    {
        string Text { get; set; }

        List<IMenuItem> Children { get; set; }
    }
}
