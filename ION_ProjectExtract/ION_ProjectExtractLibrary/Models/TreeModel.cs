namespace ION_ProjectExtractLibrary.Models
{
    public class TreeModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Label { get; set; }
        public int Sequence { get; set; }
        public List<TreeElementChildModel>? TreeElementChildren { get; set; }
    }
}
