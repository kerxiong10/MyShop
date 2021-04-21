using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        public string Id { get; set; }

        [StringLength(20)] //set Name length to 20 char
        [DisplayName("Product Name")] //Will display Product Name on UI
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(0,1000)]//set range price
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }

        //constructor - everytime we create an instances of product we auto generate an ID
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
