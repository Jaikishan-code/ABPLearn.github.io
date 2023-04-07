using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TestABP.Products
{
    public class Product : FullAuditedEntity<Guid>
    {
        public string Product_Name { get; set; }

        public string Product_Description { get; set; }
        
        public string Product_Category { get; set; }
        
        public int Product_code { get; set;}

        public string Product_keywords { get; set; }

        public int Product_Price { get; set; }

        


    

    protected Product()
    {
    }

    public Product(
        Guid id,
        string product_Name,
        string product_Description,
        string product_Category,
        int product_code,
        string product_keywords,
        int product_Price
    ) : base(id)
    {
        Product_Name = product_Name;
        Product_Description = product_Description;
        Product_Category = product_Category;
        Product_code = product_code;
        Product_keywords = product_keywords;
        Product_Price = product_Price;
    }
    }
}
