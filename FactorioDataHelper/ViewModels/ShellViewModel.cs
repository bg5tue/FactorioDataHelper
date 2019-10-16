using Caliburn.Micro;
using FactorioDataHelper.Models;
using Neo.IronLua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioDataHelper.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {

        }

        public void LoadData()
        {

        }

        public void Test()
        {
            var text = System.IO.File.ReadAllText(@"C:\Users\Simon Zeng\Desktop\prototypes\technology\demo-technology.lua");
            text = text.Substring(text.IndexOf('{'));
            text = text.Substring(0, text.LastIndexOf('}') + 1);
            text = "data = \r\n" + text;
            //MessageBox.Show(text);
            using (Lua lua = new Lua())
            {
                dynamic env = lua.CreateEnvironment();
                env.dochunk(text);
                //System.Windows.MessageBox.Show($"{env.data[1].type}");


                List<Technology> data = new List<Technology>();

                for (int i = 1; ; i++)
                {
                    var x = env.data[i];
                    if (x == null) break;

                    var t = new Technology
                    {
                        Name = x.name,
                        Icon = x.icon,
                        IconSize = x.icon_size,
                        Enabled = x.enabled == null ? false : x.enabled
                    };

                    for (int j = 1; ; j++)
                    {
                        //System.Windows.MessageBox.Show(env.data[i].effects.GetLength);
                        var y = x.effects[j];
                        if (y == null) break;
                        t.Effects.Add(new TechnologyEffect
                        {
                            Type = y.type,
                            Recipe = y.recipe
                        });
                    }

                    t.Unit = new TechnologyUnit
                    {
                        Count =x.unit.count == null ? -0 : x.unit.count,
                        Time = x.unit.time == null ? -0 : x.unit.time
                    };

                    for (int k = 1; ; k++)
                    {
                        var y = x.unit.ingredients[k];
                        if (y == null) break;
                        t.Unit.Ingredients.Add(y[1], y[2]);
                    }

                    data.Add(t);
                }

                System.Windows.MessageBox.Show(data.Count.ToString());
            }




            /*var text = System.IO.File.ReadAllText(@"C:\Users\Simon Zeng\Desktop\prototypes\technology\demo-technology.lua");
            text = text.Substring(text.IndexOf('{'));
            text = text.Substring(0, text.LastIndexOf('}') + 1);
            text = "data = \r\n" + text;
            //MessageBox.Show(text);
            using (Lua lua = new Lua())
            {
                dynamic env = lua.CreateEnvironment();
                env.dochunk(text);

                System.Windows.MessageBox.Show($"{env.data[1].type}");

                //env.dochunk("var1 = {type = \"unlock-recipe\",recipe = \"burner-mining-drill\"}");
                //MessageBox.Show(env.var1.type);
            }*/


        }
    }
}
