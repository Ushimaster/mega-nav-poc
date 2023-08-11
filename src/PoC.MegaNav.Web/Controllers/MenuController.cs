using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using PoC.MegaNav.Web.Models;

namespace PoC.MegaNav.Web.Controllers
{
    public class MenuController : Controller
    {
        [ChildActionOnly]
        public PartialViewResult Menu()
        {
            var client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://localhost:7084/api/menu/learner/").GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var items = JsonConvert.DeserializeObject<IEnumerable<MenuItem>>(json);

                return PartialView(items);
            }

            return PartialView(Enumerable.Empty<MenuItem>());
        }
    }
}