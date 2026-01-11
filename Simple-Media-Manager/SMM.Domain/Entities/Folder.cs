using SMM.Domain.Common;
using SMM.Domain.Exceptions;
using SMM.Domain.Resources;
using System.Runtime.InteropServices;

namespace SMM.Domain.Entities
{
    public class Folder : BaseEntity
    {
        public string FolderName { get; set; }
        public long? ParentId { get; set; }

        #nullable enable
        public Folder? Parent { get; set; }
        public ICollection<Folder> Children { get; private set; } = new List<Folder>();
        public ICollection<Media> Medias { get; private set; } = new List<Media>();
        private Folder() { }

        private Folder(string folderName, long? parentId)
        {
            SetFolderName(folderName);
            SetParentFolderById(parentId);
        }

        public static Folder Create(string folderName, long? parentId)
        {
            return new Folder(folderName, parentId);
        }

        public void SetFolderName(string folderName)
        {
            if (string.IsNullOrWhiteSpace(folderName))
                throw new DomainException(Messages.Exception_EmptyFolderName);
            if (folderName.Length > 100)
                throw new DomainException(Messages.Exception_ExceedFolderName);

            FolderName = folderName;
        }

        public void SetParentFolderById(long? parentId)
        {
            ParentId = parentId;
        }

        public void SetParentFolderById(string parentId)
        {
            throw new NotImplementedException();
        }
    }
}
