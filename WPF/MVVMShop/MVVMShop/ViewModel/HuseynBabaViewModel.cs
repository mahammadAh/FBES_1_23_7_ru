using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVMShop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMShop.ViewModel
{
    public class HuseynBabaViewModel : ViewModelBase
    {
        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                Set<ObservableCollection<Product>>(ref products, value);
            }
        }

   


        private ObservableCollection<BasketElement> basket;
        public ObservableCollection<BasketElement> Basket  { get  { return basket; } set{ Set<ObservableCollection<BasketElement>>(ref basket, value); }}

        private string totalAmount;
        public string TotalAmount { get { return totalAmount; } set { Set<string>(ref totalAmount, value); } }

        


        private RelayCommand<Product> addProductToBasketCommand;
        public RelayCommand<Product> AddProductToBasketCommand
        {
            get 
            {
                return addProductToBasketCommand ?? new RelayCommand<Product>
                    (
                     param =>
                     {
                         var selectedItem = param as Product;
                         var result = Basket.FirstOrDefault(x => x.Id == selectedItem.Id);
                         if (result != null)
                         {
                             result.Count++;
                             result.Cost = result.Cost + selectedItem.Cost;
                            
                         }
                         else
                         {
                             Basket.Add(new BasketElement
                             {
                                 Id = selectedItem.Id,
                                 Cost = selectedItem.Cost,
                                 Count = 1,
                                 Name = selectedItem.Name
                             });
                         }

                         TotalAmount = Basket.Sum(x => x.Cost).ToString();
                        
                     }
                    );
            }
        }


        public HuseynBabaViewModel()
       {
            Products = new ObservableCollection<Product>
            {
                new Product
            {
                Name = "Mouse",
                Description = "Game Mouse",
                Cost = 200,
                ImageUrl = "https://assets2.razerzone.com/images/pnx.assets/e429c76f51b34a0ce9c368be025e58b8/razer-naga-left-handed-edition-500x500.png"
            },
                new Product
            {
                Name = "Keyboard",
                Description = "Game Keyboard",
                Cost = 400,
                ImageUrl = "https://media.gamestop.com/i/gamestop/11105808_white_ALT02?$pdp$"
            },
                new Product
            {
                Name = "Monitor",
                Description = " Monitor for UI/UX",
                Cost = 1100,
                ImageUrl = "https://sm.pcmag.com/pcmag_uk/review/r/razer-rapt/razer-raptor-27_22t6.jpg"
            },
                new Product
            {
                Name = "Proccessor",
                Description = "Gaming processor",
                Cost = 1500,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnGcpoeFEFiv3fqPKX_eiwwaa4-XxUqRz89dc2hGfUcA&s"
            },
                 new Product
            {
                Name = "Headphones",
                Description = "Headphone for singer",
                Cost = 400,
                ImageUrl = "https://m.media-amazon.com/images/I/71C-sMCpLWL._AC_UF1000,1000_QL80_.jpg"
            },
               new Product
            {
                Name = "Planshet",
                Description = "Grahpic designer",
                Cost = 230,
                ImageUrl = "https://art-tablet.by/uploads/blog/img-news/risovanie-na-graficheskom-planshete-11.jpg"
            }
            };

            Basket = new ObservableCollection<BasketElement>();




        }
    }
}
