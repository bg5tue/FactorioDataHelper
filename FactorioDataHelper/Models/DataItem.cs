using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioDataHelper.Models
{
    public class DataItem
    {
        public Type Type => this.GetType();


        public string Name { get; set; }
    }
}
