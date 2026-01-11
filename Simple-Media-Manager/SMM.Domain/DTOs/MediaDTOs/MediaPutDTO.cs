namespace SMM.Domain.DTOs.MediaDTOs
{
    public class MediaPutDTO
    {
        public string MediaName { get; set; } = null;
        public string MediaUrl { get; set; } = null;
        public long FolderId { get; set; }
    }
}
