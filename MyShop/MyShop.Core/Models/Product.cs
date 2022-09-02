using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product : BaseEntity
    {
        //public string Id { get; set; } removed because we already have ID in Base Entity

        [StringLength(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(0,1000)]
        public decimal Price { get; set; }
        public string Category { get; set; }//group product by different categories
        public string Image { get; set; }

        //public Product()//this is so everytime we create an instance of Product class, it auto generates an ID
        //{
        //    //this.Id = Guid.NewGuid().ToString(); //generate a new ID everytime and convert to an string ID. //removed in 65 video because in Base Entity
        //}
    }
}
