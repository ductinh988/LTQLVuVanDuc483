using LTQL_1721050483.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL_1721050483.Controllers
{
    public class View2bangsController : Controller
    {
        LTQLDb db = new LTQLDb();
        // GET: View2bangs
        public ActionResult Index()
        {
            var viewModel =
      from pd in db.NhaCungCaps
      join p in db.SanPhams on pd.Manhacungcap equals p.Manhacungcap
      select new View2bang { nhaCungCap = pd, SanPham = p };
            return View(viewModel);
        }
    }
}