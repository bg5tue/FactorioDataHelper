using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioDataHelper.Models
{
    public class Technology : DataItem
    {
        public string Icon { get; set; }


        public int IconSize { get; set; } = 128;
                

        public bool Enabled { get; set; } = false;


        public List<TechnologyEffect> Effects { get; set; } = new List<TechnologyEffect>();


        public TechnologyUnit Unit { get; set; }


        public List<string> PreRequisites { get; set; } = new List<string>();


        public string Order { get; set; } = "c-a";
    }

    public class TechnologyEffect
    {
        public string Type { get; set; } = "unlock-recipe";


        public string Recipe { get; set; }
    }

    public class TechnologyUnit
    {
        public int Count { get; set; }


        public Dictionary<string, int> Ingredients { get; set; } = new Dictionary<string, int>();


        public int Time { get; set; }
    }
}
