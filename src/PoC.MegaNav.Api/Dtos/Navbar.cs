namespace PoC.MegaNav.Api.Dtos
{
    public class Navbar
    {
        public string LogoUrl { get; set; }
        public IEnumerable<MenuItem> Menu { get; set; }
    }
}
