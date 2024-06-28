using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPageNavigation.Model;

namespace WPFPageNavigation.ViewModel
{
    class OrdersVM : Utilites.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public DateOnly DisplayOrderDate
        {
            get {return _pageModel.OrderDate;}
            set { _pageModel.OrderDate=value; OnPropertyChanged(); }
        }
        public OrdersVM()
        {
            _pageModel = new PageModel();
            DisplayOrderDate=DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
