using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// class which implements main program logic
    /// </summary>
    class PawnShop
    {
        /// <summary>
        /// gives connection to the database class
        /// </summary>
        private PawnshopDbContext db = new PawnshopDbContext();

        /// <summary>
        /// adds inventoryitem to the database
        /// </summary>
        /// <param name="newItem"></param>
        public void AddInventoryItem(InventoryItem newItem)
        {
            db.InventoryItems.Add(newItem);
            db.SaveChanges();
        }
        /// <summary>
        /// adds car-inventoryitem to the database
        /// </summary>
        /// <param name="car"></param>
        public void AddCar(Car car)
        {
            InventoryItem item = car;
            db.InventoryItems.Add(item);
            db.SaveChanges();
        }
        /// <summary>
        /// adds watch.inventoryitem to the database
        /// </summary>
        /// <param name="watch"></param>
        public void AddWatch(Watch watch)
        {
            InventoryItem item = watch;
            db.InventoryItems.Add(item);
            db.SaveChanges();
        }
        /// <summary>
        /// lists all the inventoryitems
        /// </summary>
        /// <returns></returns>
        public List<InventoryItem> listItems()
        {
            List<InventoryItem> list = db.InventoryItems.ToList();
                return list;

        }
        /// <summary>
        /// adds worker to the database
        /// </summary>
        /// <param name="worker"></param>
        public void AddWorker(Worker worker)
        {
            db.Workers.Add(worker);
            db.SaveChanges();
        }
        /// <summary>
        /// adds the expert-worker to the database
        /// </summary>
        /// <param name="expert"></param>
        public void AddExpert(Experts expert)
        {
            Worker worker = expert;
            db.Workers.Add(expert);
            db.SaveChanges();
        }
        /// <summary>
        /// lists all the workers
        /// </summary>
        /// <returns></returns>
        public List<Worker>listWorkers()
        {
            List<Worker> workers = db.Workers.ToList();
            return workers;
        }
        /// <summary>
        /// returns list of all inventoryitems which forfills keyword search value
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        public List<InventoryItem> SearchItem(string keyWord)
        {
            List<InventoryItem> list =new List<InventoryItem>();
            var items = listItems();
            foreach (var item in items)
            {
                if (item is Car)
                {
                    if (((Car)item).FitsSearch(keyWord))
                        list.Add(item);
                }
                else
                    if (item.FitsSearch(keyWord))
                        list.Add(item);
            }
            return list;
        }
        /// <summary>
        /// returns ordered list
        /// </summary>
        /// <returns></returns>
        public List<InventoryItem> SortByPrice()
        {
            return db.InventoryItems.OrderBy(x => x.Price).ToList();
        }
        /// <summary>
        /// returs ordered list
        /// </summary>
        /// <returns></returns>
        public List<InventoryItem> SortByName()
        {
            return db.InventoryItems.OrderBy(x => x.Name).ToList();
        }
    }
}
