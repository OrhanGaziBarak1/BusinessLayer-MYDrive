using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFolderService
    {
        List<Folder> GetFolders();
        void FolderAdd(Folder folder);
        Folder GetByID(int id);
        void FolderRemove(Folder folder);
        void FolderUpdate(Folder folder);
    }
}
