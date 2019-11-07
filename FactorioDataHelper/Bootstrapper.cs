using Caliburn.Micro;
using FactorioDataHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FactorioDataHelper
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            _container.Singleton<IWindowManager, WindowManager>();
            _container.Singleton<IEventAggregator, EventAggregator>();

            _container.Singleton<Models.AppConfig>();

            _container.Singleton<LocalViewModel>();

            _container.Singleton<ShellViewModel>();
        }

        protected override object GetInstance(Type serviceType, string key)
        {
            return _container.GetInstance(serviceType, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return _container.GetAllInstances(serviceType);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            Dictionary<string, object> settings = new Dictionary<string, object>();
            settings.Add("Title", "Factorio Data Tool");
            settings.Add("SizeToContent", SizeToContent.Manual);
            settings.Add("Height", 600);
            settings.Add("Width", 800);

            DisplayRootViewFor<ShellViewModel>(settings);
        }
    }
}
