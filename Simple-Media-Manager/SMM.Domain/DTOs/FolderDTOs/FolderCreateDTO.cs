namespace SMM.Domain.DTOs.FolderDTOs
{
    public class FolderCreateDTO
    {
        public string FolderName { get; set; }
        public long? ParentId { get; set; }
    }
}
