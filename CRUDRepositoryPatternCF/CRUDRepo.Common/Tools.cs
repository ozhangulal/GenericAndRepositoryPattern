using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDRepo.Entity;

namespace CRUDRepo.Common
{
    public class Tools
    {
        public static CRUDDb db = null;
        public static CRUDDb GetConnection()
        {
            if (db == null)
                db = new CRUDDb();

            return db;
        }
    }
}
