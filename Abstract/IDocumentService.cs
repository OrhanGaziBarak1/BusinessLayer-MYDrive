using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDocumentService
    {
        List<Document> GetDocuments();
        void DocumentAdd(Document document);
        Document GetByID(int id);
        void DocumentRemove(Document document);
        void DocumentUpdate(Document document);

    }
}
