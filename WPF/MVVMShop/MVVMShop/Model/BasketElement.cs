using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;


namespace MVVMShop.Model
{
    public class BasketElement : ViewModelBase
    {


        public Guid Id { get; set; }
        public string Name { get; set; }
  
        private int count;
        public int Count
        {
            get { return count; }
            set { Set<int>(ref count, value); }
        }

        private float cost;
        public float Cost
        {
            get { return cost; }
            set { Set<float>(ref cost, value); }
        }


        public BasketElement()
        {
            Count = 0;
            Cost = 0;
        }

    }
}
