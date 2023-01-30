using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.OrderModels
{
    public class Food : Product
    {
       

        public Food(string category, string name,  decimal price) : base(category, name, price)
        {
          
        }
        
    }
}