using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class ProductCategory : BaseEntity
    {
        //public string Id { get; set; } //removed per video 65. Created in Base Entity
        public string Category { get; set; }

        //public ProductCategory() //removed per video 65. Created in Base Entity
        //{
        //    this.Id = Guid.NewGuid().ToString();
        //}
    }
}
