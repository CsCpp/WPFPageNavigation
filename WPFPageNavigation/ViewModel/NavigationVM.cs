using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPageNavigation.Utilites;
using System.Windows.Input;

namespace WPFPageNavigation.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }

        }
        
        public ICommand HomeCommand { get; set; }
        public ICommand CustomersCommand { get; set; }
        public ICommand ProductsCommand { get; set; }
        public ICommand OrderCommand { get; set; }
        public ICommand TransactionCommand { get; set; }
        public ICommand ShipmentCommand { get; set; }
        public ICommand SettingsCommand { get; set; }

        private void Home(object obj)=>CurrentView=new HomeVM();
        private void Customer(object obj) => CurrentView = new CustomerVM();
        private void Product(object obj) => CurrentView = new ProductsVM();
        private void Order(object obj) => CurrentView = new OrdersVM();
        private void Transaction(object obj) => CurrentView = new TransactionVM();
        private void Shipment(object obj) => CurrentView = new ShipmentVM();
        private void Setting(object obj) => CurrentView = new SettingsVM();


        public NavigationVM()
        {
            HomeCommand=new RelayCommand(Home);
            CustomersCommand = new RelayCommand(Customer);
            ProductsCommand = new RelayCommand(Product);
            OrderCommand = new RelayCommand(Order);
            TransactionCommand = new RelayCommand(Transaction);
            ShipmentCommand = new RelayCommand(Shipment);
            SettingsCommand = new RelayCommand(Setting);

            CurrentView = new HomeVM();
        }
    }


}
