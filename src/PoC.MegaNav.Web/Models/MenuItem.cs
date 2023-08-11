namespace PoC.MegaNav.Web.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        public string Title { get; set; }

        public string Link { get; set; }
    }
}