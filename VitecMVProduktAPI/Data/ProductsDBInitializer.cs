using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitecMVProduktAPI.Models;

namespace VitecMVProduktAPI.Data
{
    public class ProductsDBInitializer
    {
        public static void Initialize(VitecMVProduktAPIContext Context) {


            Context.Database.EnsureCreated();
            if (Context.Products.Any()) {
                return;
            } else {
                var Products = new Products {
                    Title = "CDOrd",
                    Picture = null,
                    Price = 50,
                    Description = "Lorem ipsum"

                };
            }
        }
    }
}
