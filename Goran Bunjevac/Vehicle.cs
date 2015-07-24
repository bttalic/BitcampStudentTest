using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Test
{
    class Vehicle : Inventory
    {
        private string type;
        private int prodYear;
        private enumStatus status;
        private int id;
        private bool parsing;

        public enum enumStatus { Perfect = 1, Preserved = 2, Bad = 3 };

        public string Type { get { return type; } }
        public int ProdYear { get { return prodYear; } }

        public Vehicle(string name, string description, string price, string type, int prodYear, string statusstring) 
            : base(name, description, price) 
        {
            this.type = type;
            this.prodYear = prodYear;
            this.id = ++Inventory_Count;
            this.parsing = Enum.TryParse(statusstring, out status);
        
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}, {2}, {3}, {4}, {5}, {6}", id, Name, Description, Price, type, prodYear, status);
        }



    }
}
