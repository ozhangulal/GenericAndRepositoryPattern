using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDRepo.Entity;
using CRUDRepo.Common;

namespace CRUDRepo.Repository
{
    public class BrandRepository : DataRepository<Brand, int>
    {
        public static CRUDDb db = Tools.GetConnection();
        ResultProcess<Brand> result = new ResultProcess<Brand>();

        public override Result<int> Delete(int id)
        {
            Brand silinecek = db.Brands.SingleOrDefault(t => t.BrandId == id);
            db.Brands.Remove(silinecek);
            return result.GetResult(db);
        }

        public override Result<Brand> GetObjById(int id)
        {
            Brand b = db.Brands.SingleOrDefault(t => t.BrandId == id);
            return result.GetT(b);
        }

        public override Result<int> Insert(Brand item)
        {
            db.Brands.Add(item);
            return result.GetResult(db);
        }

        public override Result<List<Brand>> List()
        {
            return result.GetListResult(db.Brands.ToList());
        }

        public override Result<int> Update(Brand item)
        {
            Brand guncellenecek = db.Brands.SingleOrDefault(t => t.BrandId == item.BrandId);
            guncellenecek.BrandName = item.BrandName;
            guncellenecek.Description = item.Description;
            return result.GetResult(db);
        }
    }
}
