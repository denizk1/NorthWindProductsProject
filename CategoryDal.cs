using NorthWindProductsProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindProductsProject
{
    public class CategoryDal
    {
        public List<Category> GetAll() //hepsini getir
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }

        }
       
    }
}
