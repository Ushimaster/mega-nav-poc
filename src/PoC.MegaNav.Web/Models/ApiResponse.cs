using System.Collections.Generic;

namespace PoC.MegaNav.Web.Models
{
    public class ApiResponse
    {
        public IEnumerable<MenuItem> MenuItems { get; set; }
    }
}