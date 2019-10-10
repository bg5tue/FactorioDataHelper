using Neo.IronLua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FactorioDataHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string LOCAL_FOLDER = @".\data\base\locale\{language}\base.cfg";
        private Dictionary<string, List<string>> _fileGroups;

        public MainWindow()
        {
            InitializeComponent();


        }

        private void Init()
        {
            Task.Run(() =>
            {
                _fileGroups.Add("technology", new List<string>
                {
                    @"data\base\prototypes\technology\demo-technology.lua",
                    @"data\base\prototypes\technology\inserter.lua",
                    @"data\base\prototypes\technology\military-upgrades.lua",
                    @"data\base\prototypes\technology\technology.lua"
                });

                _fileGroups.Add("equipment", new List<string>
                {
                    @"data\base\prototypes\equipment\equipment.lua"
                });


            });
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            string language = System.Globalization.CultureInfo.CurrentUICulture.Name;
            //var language = "zh-CN";
            MessageBox.Show(LOCAL_FOLDER.Replace("{language}", language));



            var text = System.IO.File.ReadAllText(@"D:\Games\Installed Games\Factorio v0.17.69\data\base\prototypes\technology\demo-technology.lua");
            text = text.Substring(text.IndexOf('{'));
            text = text.Substring(0, text.LastIndexOf('}') + 1);
            text = "data = \r\n" + text;
            //MessageBox.Show(text);
            using (Lua lua = new Lua())
            {
                dynamic env = lua.CreateEnvironment();
                env.dochunk(text);
                
                MessageBox.Show($"{env.data[1].type}");

                //env.dochunk("var1 = {type = \"unlock-recipe\",recipe = \"burner-mining-drill\"}");
                //MessageBox.Show(env.var1.type);
            }
        }
    }
}
