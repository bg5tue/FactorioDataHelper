using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioDataHelper.Models
{
    public class AppConfig
    {
        public string Language { get; set; }

        public GameInfo GameInfo { get; set; }
    }

    public class GameInfo
    {
        /// <summary>
        /// Game version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Game folder path
        /// </summary>
        public string Path { get; set; }
    }
}
