using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FactorioDataHelper.Converters
{

    public class UITextLookupConverter
    {
        public static Binding CreateBinding(string key)
        {
            Binding languageBinding = new Binding("LanguageDefn")
            {
                //Source = ViewModels.LocalViewModel.Current,
                //Converter = _sharedConverter,
                ConverterParameter = key,
            };
            return languageBinding;
        }
    }
}
