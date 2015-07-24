using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class PawnShop : ISearchable
    {
        private List<Inventory> inventory;
        private List<Workers> workers;

        public PawnShop()
        {

            this.inventory = new List<Inventory>();
            this.workers = new List<Workers>();                                  //preuzima listu inventorya i emplpyeesa
        }


        public List<Inventory> Inventory { get { return inventory; } }
        public List<Workers> Workers { get { return workers; } }
       


         public void AddInventory(Inventory i)                               // dodaje u listu inventorya
        {
            inventory.Add(i);
            
        }


         public void AddWorker(Workers w)                                        // dodaje u listu workera
       {
           workers.Add(w);
           workers.Sort();
       }


         public List<ISearchable> Find(string s)
        {
            List<ISearchable> everything = new List<ISearchable>(workers);   //
            everything.AddRange(inventory);
            List<ISearchable> results = new List<ISearchable>();
            foreach (ISearchable e in everything) {
                if (e.Search(s) != null)
                    results.Add(e);
            }
            return results;
        }

         public virtual ISearchable Search(string s)
         {
             throw new NotImplementedException();
         }
    }
}
