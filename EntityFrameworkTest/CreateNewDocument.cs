using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    static class CreateNewDocument
    {
        public static void CreateDocument(int newUserCompanyID)
        {
            Document newDoc = new Document();
            newDoc.UniqueID = Utils.GenerateHashCode(10).ToUpper();
            newDoc.Title = "Оферта";
            newDoc.FileName = "File name";
            newDoc.CreateDate = DateTime.Now;
            newDoc.TypeID = (int)DOCUMENT_TYPE.Offer;
            newDoc.ContractorID = newUserCompanyID;
            newDoc.CompanyID = 42;
            newDoc.StatusID = (int)DOCUMENT_STATUS.Added;
            newDoc.EmployeeID = 69;
            Create(newDoc);

            newDoc.StatusID = (int)DOCUMENT_STATUS.SignSent;
            newDoc.IsSign = true;
            newDoc.SentDate = DateTime.Now;
            newDoc.SignDate = DateTime.Now;
        }

        private static void Create(Document newDoc)
        {
            using (var context = new AppContext())
            {
                context.Documents.Add(newDoc);
                context.SaveChanges();
            }
            Console.WriteLine(newDoc.Company2.Name);
        }

    }
}
