using NorthWindProductsProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindProductsProject
{

    public class ProductDal
    {
        public List<Product> GetAll() //hepsini getir
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }

        }
        public List<Product> GetProductsByCategory(int CategoryID)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.Where(p => p.CategoryID==CategoryID).ToList();
            }

        }

        public List<Product> GetProductsByName(string Name,int SelectedId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.Where(p => p.ProductName.ToLower().Contains(Name.ToLower()) && p.CategoryID==SelectedId).ToList();
            }
        }

    }
}
