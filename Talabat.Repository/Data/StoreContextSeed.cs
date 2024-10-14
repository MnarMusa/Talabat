using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Talabat.Core.Entities;


namespace Talabat.Repository.Data
{
    public static class StoreContextSeed
    {
        

        public async static Task SeedAsync(StoreContext _dbcontext)
        {
           
           var brandsData = File.ReadAllText("../Talabat.Repository/Data/DataSeeding/brands.json");
            var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
            

            if (brands.Count()>0)
            {
                //brands = brands.Select(b => new ProductBrand()
                //{
                //    Name = b.Name,
                //}
                //).ToList();
                if (!(_dbcontext.ProductBrands.Count()>0)){
                    foreach (var brand in brands)
                    {
                        _dbcontext.Set<ProductBrand>().Add(brand);


                    }
                    await _dbcontext.SaveChangesAsync();
                }

                
                
            }




            var CategoryData = File.ReadAllText("../Talabat.Repository/Data/DataSeeding/categories.json");
            var Categories = JsonSerializer.Deserialize<List<ProductCategory>>(CategoryData);


            if (Categories.Count() > 0)
            {
                //brands = brands.Select(b => new ProductBrand()
                //{
                //    Name = b.Name,
                //}
                //).ToList();
                if (!(_dbcontext.ProductCategories.Count() > 0))
                {
                    foreach (var category in Categories)
                    {
                        _dbcontext.Set<ProductCategory>().Add(category);


                    }
                    await _dbcontext.SaveChangesAsync();
                }



            }



            var ProductsData = File.ReadAllText("../Talabat.Repository/Data/DataSeeding/products.json");
            var Products = JsonSerializer.Deserialize<List<Product>>(ProductsData);


            if (Products.Count() > 0)
            {
                //brands = brands.Select(b => new ProductBrand()
                //{
                //    Name = b.Name,
                //}
                //).ToList();
                if (!(_dbcontext.Products.Count() > 0))
                {
                    foreach (var product in Products)
                    {
                        _dbcontext.Set<Product>().Add(product);


                    }
                    await _dbcontext.SaveChangesAsync();
                }



            }



        }

    }
}
