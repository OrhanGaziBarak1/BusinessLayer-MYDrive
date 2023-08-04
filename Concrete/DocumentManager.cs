using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DocumentManager : IDocumentService
    {

        IDocumentDal _documentDal;

        public DocumentManager(IDocumentDal documentDal)
        {
            _documentDal = documentDal;
        }

        //Read Operation
        public List<Document> GetDocuments()
        {
            return _documentDal.Read();
        }
        //Create Operation
        public void DocumentAdd(Document document)
        {
            _documentDal.Insert(document);
        }
        //GetID Operation
        public Document GetByID(int id)
        {
            return _documentDal.Get(x => x.DocumentID == id);
        }
        //Delete Operation
        public void DocumentRemove(Document document)
        {
            _documentDal.Delete(document);
        }
        //Update Operation
        public void DocumentUpdate(Document document)
        {
            _documentDal.Update(document);
        }
    }
}
