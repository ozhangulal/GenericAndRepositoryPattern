using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDRepo.Common;
using CRUDRepo.Entity;

namespace CRUDRepo.Repository
{
    public class ProductRepository : DataRepository<Product, int>
    {
        private static CRUDDb db = Tools.GetConnection();
        ResultProcess<Product> result = new ResultProcess<Product>();

        public override Result<int> Delete(int id)
        {
            Product silinecek = db.Products.SingleOrDefault(t => t.ProductId == id);
            db.Products.Remove(silinecek);
            return result.GetResult(db);
        }

        public override Result<Product> GetObjById(int id)
        {
            return result.GetT(db.Products.SingleOrDefault(t => t.ProductId == id));
        }

        public override Result<int> Insert(Product item)
        {
            db.Products.Add(item);
            return result.GetResult(db);
        }

        public override Result<List<Product>> List()
        {
            return result.GetListResult(db.Products.ToList());
        }

        public override Result<int> Update(Product item)
        {
            Product gunP = db.Products.SingleOrDefault(t => t.ProductId == item.ProductId);
            gunP.BrandId = item.BrandId;
            gunP.CategoryId = item.CategoryId;
            gunP.ProductName = item.ProductName;
            gunP.Photo = item.Photo;
            return result.GetResult(db);
        }
    }
}
