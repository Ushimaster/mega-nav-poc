using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using PoC.MegaNav.Web.Models;

namespace PoC.MegaNav.Web.Controllers
{
    public class MenuController : Controller
    {
        //[ChildActionOnly]
        //public PartialViewResult Menu()
        //{
        //    var model = new ApiResponse();

        //    var client = new HttpClient();
        //    HttpResponseMessage response = client.GetAsync("https://localhost:7084/api/menu/learner/").GetAwaiter().GetResult();

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        //        var items = JsonConvert.DeserializeObject<IEnumerable<MenuItem>>(json);

        //        model.MenuItems = items;

        //        return PartialView(model);
        //    }

        //    return PartialView(model);
        //}
    }
}