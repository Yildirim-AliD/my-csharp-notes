using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_EntityFrameWorkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext ctx = new ETradeContext())
            {
                //ctx.Products.Add(product);
                var entity = ctx.Entry(product);
                entity.State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();
            }
        }


        public void Update(Product product)
        {
            using (ETradeContext ctx = new ETradeContext())
            {
                var entity = ctx.Entry(product);
                entity.State =System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            
            using (ETradeContext ctx = new ETradeContext())
            {
                var entity = ctx.Entry(product);
                entity.State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }
        }


        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice>=price).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal min,decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min &&p.UnitPrice<=max).ToList();
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
               //return context.Products.FirstOrDefault(p=>p.Id == id);
               return context.Products.SingleOrDefault(p => p.Id == id);
            }
        }


    }
}
