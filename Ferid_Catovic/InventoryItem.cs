using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTest
{
    class InventoryItem : ISearchable 
    {
        private int ID_COUNT = 0;
        private string name { get; set; }
        private string desc { get; set; }
        private int price { get; set; }
        private int id {get; set;}

        public InventoryItem(string name, string decs, int price) 
        {
            this.name = name;
            this.desc = desc;
            this.price = price;
            this.id = ++ID_COUNT;
        }




        public override string ToString()
        {
            return String.Format("ID: {0}\nName: {1}\nDestripion: {2}\nPrice: {3}", id, name, desc, price);
        }

        public virtual ISearchable FitsSearch(string s)
        {
            throw new NotImplementedException();
        }


    }
}
