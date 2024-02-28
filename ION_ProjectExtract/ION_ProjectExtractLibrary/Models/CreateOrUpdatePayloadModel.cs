namespace ION_ProjectExtractLibrary.Models
{
    internal class CreateOrUpdatePayloadModel
    {
        public string message { get; set; }
        public string content { get; set; }
        public string branch { get; set; }
        public string sha { get; set; }
    }
}
