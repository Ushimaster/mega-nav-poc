namespace PoC.MegaNav.Web.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        public MenuItem Parent { get; set; }

        public string Title { get; set; }

        public string Link { get; set; }
    }
}