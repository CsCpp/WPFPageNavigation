using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPageNavigation.Model;

namespace WPFPageNavigation.ViewModel
{
    class TransactionVM : Utilites.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public decimal TransactionAmount
        {
            get { return _pageModel.TransactionValue; }
            set { _pageModel.TransactionValue = value; OnPropertyChanged(); }

        }
        public TransactionVM()
        {
            _pageModel = new PageModel();
            TransactionAmount = 5638;
        }

    }
}
