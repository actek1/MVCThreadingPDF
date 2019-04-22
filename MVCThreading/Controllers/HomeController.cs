using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MVCThreading.Libraries.BusinessRules.Queries;

namespace MVCThreading.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GeneratePDF()
        {
            string output = "PDF Created";

            new MVCThreading.Libraries.BusinessRules.PDF.PDFCreator().getHandlerPDF();

            return Json(output, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AllProcess(string[] msg)
        {
            string output = string.Join(", ", msg);

            WsThr.IService1 ws = new WsThr.Service1Client();

            var resultrWs = ws.GetDataAsync(msg);

            int result = GenerateQueries();

            return Json(output, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> AllProcessAsync(string[] msg)
        {
            string output = string.Join(", ", msg);

            var re = GenerateQueries();

            var result = GenerateQueriesAsync();
            var content = await result;

            return Json(output, JsonRequestBehavior.AllowGet);
        }

        public int GenerateQueries()
        {
            var allTickets = new Tickets().getAllTickets();

            var allBettors = new Tickets().getAllBettorsbyTickets(allTickets);

            bool result1 = new RealFiles(@"C:\Users\Actek\Documents\test").createNewFile(allBettors.ToArray(), "\\bettorsLeidos1.txt");

            var allDetaild = new Tickets().getDetails();

            var files = new RealFiles(@"C:\Windows\System32").getAllrealFiles();

            bool result2 = new RealFiles(@"C:\Users\Actek\Documents\test").createNewFile(files, "\\archivosLeidos1.txt");


            if (allBettors.Count() > 0)
                return 0;
            else
                return 1;
        }

        public async Task<int> GenerateQueriesAsync()
        {

            var allTickets = new Tickets().getAllTickets();

            var allBettors = new Tickets().getAllBettorsbyTickets(allTickets);
            await Task.Delay(5000);
            bool result1 = new RealFiles(@"C:\Users\Actek\Documents\test").createNewFile(allBettors.ToArray(), "\\bettorsLeidos.txt");

            var allDetaild = new Tickets().getDetails();

            var files = new RealFiles(@"C:\Windows\System32").getAllrealFiles();

            bool result2 = new RealFiles(@"C:\Users\Actek\Documents\test").createNewFile(files, "\\archivosLeidos.txt");


            if (allBettors.Count() > 0)
                return 0;
            else
                return 1;
        }

    }
}