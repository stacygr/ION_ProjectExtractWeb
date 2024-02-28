namespace ION_ProjectExtractLibrary.Models
{
    public class Connect_FileFormatTemplatesModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? FileEncoding { get; set; }
        public string? FormatType { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public string? FileType { get; set; }
        public string? FileName { get; set; }
        public string? FileExtension { get; set; }
        public string? FilePath { get; set; }
        public bool UseFileAttributes { get; set; }
        public bool IncludeXmlheader { get; set; }
        public List<FormatTypeSettingModel>? FormatTypeSettings { get; set; }
    }
}
