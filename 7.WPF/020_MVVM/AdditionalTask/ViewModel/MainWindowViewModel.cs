using AdditionalTask.Infrastructure;
using AdditionalTask.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AdditionalTask.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        RelayCommand findProductBuyersCommand;
        string currentProduct;
        ObservableCollection<string> productBuyers;

        public string CurrentProduct
        {
            get
            {
                return currentProduct;
            }
            set
            {
                currentProduct = value;
                OnPropertyChanged("CurrentProduct");
            }

        }

        public ObservableCollection<string> ProductBuyers
        {
            get
            {
                productBuyers = SalesCollection.CurrentProductBuyers;
                return productBuyers;
            }
        }
        public ICommand FindProductBuyers
        {
            get
            {
                if (findProductBuyersCommand == null)
                    findProductBuyersCommand = new RelayCommand(ExecuteFindProductBuyersCommand, CanExecuteFindProductBuyersCommand);
                return findProductBuyersCommand;
            }
        }

        public void ExecuteFindProductBuyersCommand(object parameter)
        {
            if (productBuyers != null)
                productBuyers.Clear();
            SalesCollection.FindBuyers(currentProduct);
        }

        public bool CanExecuteFindProductBuyersCommand(object parameter)
        {
            if (string.IsNullOrEmpty(CurrentProduct))
                return false;
            return true;
        }
    }
}
