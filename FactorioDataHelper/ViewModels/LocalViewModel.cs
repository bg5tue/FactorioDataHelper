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
        #region Variable
        private string _gameLocalText = "";
        #endregion


        #region Items

        #region Combat Group
        private string _groupCombat;

        public string GroupCombat
        {
            get { return _groupCombat; }
            set
            {
                _groupCombat = value;
                NotifyOfPropertyChange(() => GroupCombat);
            }
        }
        #endregion


        #endregion

        public LocalViewModel()
        {

        }

        /// <summary>
        /// Get UI thread CultureInfo
        /// </summary>
        /// <returns></returns>
        public System.Globalization.CultureInfo GetCultureInfo() => System.Globalization.CultureInfo.CurrentUICulture;


        public void LoadLanguageFile()
        {
            string lang = this.GetCultureInfo()?.Name;

            // Exists language file
            if (System.IO.File.Exists($@"data\base\locale\{lang}\base.cfg"))
            {

            }
        }

        public void GetGameLocalItem(string key)
        {

        }
    }
}
