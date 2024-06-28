using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPageNavigation.Model;

namespace WPFPageNavigation.ViewModel
{
    class SettingsVM : Utilites.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public bool Settings
        {
            get { return _pageModel.LocationStatus; }
            set { _pageModel.LocationStatus = value; OnPropertyChanged(); }
        }

        public SettingsVM()
        {
            _pageModel = new PageModel();
            Settings=true;
        }
    }
}
