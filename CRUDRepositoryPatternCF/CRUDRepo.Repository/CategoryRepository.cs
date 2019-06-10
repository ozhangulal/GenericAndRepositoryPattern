using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDRepo.Common;
using CRUDRepo.Entity;

namespace CRUDRepo.Repository
{
    public class CategoryRepository
    {
        private static CRUDDb db = Tools.GetConnection();
        ResultProcess<Category> result = new ResultProcess<Category>();

        public Result<List<Category>> List()
        {
            List<Category> CatList = db.Categories.ToList();
            return result.GetListResult(CatList);
        }
    }
}
