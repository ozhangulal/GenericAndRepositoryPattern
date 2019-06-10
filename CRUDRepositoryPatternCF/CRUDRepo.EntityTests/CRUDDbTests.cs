using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRUDRepo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUDRepo.Entity.Tests
{
    [TestClass()]
    public class CRUDDbTests
    {
        [TestMethod()]
        public void CRUDDbCreatedDataBaseTest()
        {
            CRUDDb db = new CRUDDb();
            if (db.Database.Exists())
            {
                db.Database.Delete();
            }
            db.Database.Create();
        }
    }
}