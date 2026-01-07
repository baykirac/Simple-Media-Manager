using SMM.Domain.Common;
using SMM.Domain.Exceptions;
using SMM.Domain.Resources;

namespace SMM.Domain.Entities
{
    public class Media : BaseEntity
    {

        public string MediaName { get; set; } = null;
        public string MediaUrl { get; set; } = null;
        public long FolderId { get; set; }

        public Folder Folder { get; set; } = null;

        private Media()
        {
        }

        private Media(string mediaName, string mediaUrl, long folderId)
        {
            SetMediaName(mediaName);
            MediaUrl = mediaUrl;
            FolderId = folderId;
        }

        public static Media Create (string mediaName, string mediaUrl, long folderId)
        {
            return new Media(mediaName, mediaUrl, folderId);
        }

        public void SetMediaName(string mediaName)
        {
            if (string.IsNullOrWhiteSpace(mediaName))
                throw new DomainException(Messages.Exception_EmptyMediaName);
            if (mediaName.Length > 100)
                throw new DomainException(Messages.Exception_ExceedMediaName);

            MediaName = mediaName;
        }

        public void SetMediaUrl(string mediaUrl)
        {
            if (!string.IsNullOrWhiteSpace(mediaUrl))
                throw new DomainException(Messages.Exception_EmptyMediaUrl);
            if (mediaUrl.Length > 300)
                throw new DomainException(Messages.Exception_ExceedMediaUrl);

            MediaUrl = mediaUrl;
        }
    }
}
