using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FolderManager : IFolderService
    {
        IFolderDal _folderDal;

        public FolderManager(IFolderDal folderDal)
        {
            _folderDal = folderDal;
        }

        public void FolderAdd(Folder folder)
        {
            _folderDal.Insert(folder);
        }

        public void FolderRemove(Folder folder)
        {
            _folderDal.Delete(folder);
        }

        public Folder GetByID(int id)
        {
            return _folderDal.Get(x => x.FolderID == id);
        }

        public List<Folder> GetFolders()
        {
            return _folderDal.Read();
        }
        public void FolderUpdate(Folder folder)
        {
            _folderDal.Update(folder);
        }
    }
}
