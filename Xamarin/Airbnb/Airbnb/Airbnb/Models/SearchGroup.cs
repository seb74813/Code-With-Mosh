using System;
using System.Collections.Generic;
using System.Text;

namespace Airbnb.Models
{
    class SearchGroup : List<Search>
    {
        public string Title;
        public SearchGroup(string name)
        {
            Title = name;
        }
    }
}
