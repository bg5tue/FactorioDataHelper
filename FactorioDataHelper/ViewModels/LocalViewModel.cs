using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioDataHelper.ViewModels
{
    public class LocalViewModel : PropertyChangedBase
    {

        #region Current
        public LocalViewModel Current
        {
            get { return this; }
        }

        #endregion

        public LocalViewModel()
        {
            
        }

        /// <summary>
        /// Get UI thread CultureInfo
        /// </summary>
        /// <returns></returns>
        public System.Globalization.CultureInfo GetCultureInfo() => System.Globalization.CultureInfo.CurrentUICulture;

        private LocalViewModel GetCurrent() => this;
        
        public void LoadLanguageFile()
        {
            string lang = this.GetCultureInfo()?.Name;

            // Exists language file
            if (System.IO.File.Exists($@"data\base\locale\{lang}\base.cfg"))
            {

            }
        }
    }
}
