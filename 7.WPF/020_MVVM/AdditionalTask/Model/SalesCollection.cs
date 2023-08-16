using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdditionalTask.Model
{
    public static class SalesCollection
    {
        private static ObservableCollection<Sale> sales;
        private static ObservableCollection<string> currentProductBuyers;

        public static ObservableCollection<string> CurrentProductBuyers
        {
            get
            {
                return currentProductBuyers;
            }

        }
        static SalesCollection()
        {
            sales = CreateSalesCollection();
            currentProductBuyers = new ObservableCollection<string>();
        }

        private static ObservableCollection<Sale> CreateSalesCollection()
        {
            return new ObservableCollection<Sale> { new Sale("apple", "John"),
                                                    new Sale("apple", "Amy"),
                                                    new Sale("apple", "James"),
                                                    new Sale("peach", "John"),
                                                    new Sale("peach", "Robert"),
                                                    new Sale("peach", "Antony"),
                                                    new Sale("pear", "Charles"),
                                                    new Sale("pear", "John") };
        }

        public static void FindBuyers(string product)
        {
            foreach (Sale sale in sales)
            {
                if (sale.Product == product)
                {
                    currentProductBuyers.Add(sale.Buyer);
                }
            }
        }
    }
}
