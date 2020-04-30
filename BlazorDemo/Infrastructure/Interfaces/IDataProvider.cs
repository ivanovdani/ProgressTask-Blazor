using BlazorComponents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Infrastructure.Interfaces
{
    public interface IDataProvider
    {
        Task<List<IMenuItem>> GetMenuItems(int depth, int itemsOnLvl = 3);
    }
}
