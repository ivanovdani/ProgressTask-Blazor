using BlazorDemo.Infrastructure.Interfaces;
using BlazorDemo.Models;
using BlazorComponents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Infrastructure
{
    public class MockData : IDataProvider
    {
        private int inc = 0;
        public Task<List<IMenuItem>> GetMenuItems(int depth, int itemOnLvl = 3)
        {
            var result = new List<IMenuItem>();
            if (depth == 0) return Task.FromResult(result);

            for(int i = 0; i < itemOnLvl; i++)
            {
                result.Add(new MenuItem()
                {
                    Text = "Item",
                    ID = inc++,
                    Children = GetMenuItems(depth - 1, itemOnLvl).Result
                });
            }

            return Task.FromResult(result);
        }
    }
}
