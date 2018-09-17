using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicTacToe.Controllers
{
    public class HomeController : Controller
    {
        List<string> selectedBoxes = new List<string>();

        List<string> topRow = new List<string>(new string[] { "A1", "B1", "C1" });
        List<string> middleRow = new List<string>(new string[] { "A2", "B2", "C2" });
        List<string> bottomRow = new List<string>(new string[] { "A3", "B3", "C3" });
        List<string> leftColumn = new List<string>(new string[] { "A1", "A2", "A3" });
        List<string> middleColumn = new List<string>(new string[] { "B1", "B2", "B3" });
        List<string> rightColumn = new List<string>(new string[] { "C1", "C2", "C3" });
        List<string> leftToRigtDiagonal = new List<string>(new string[] { "A1", "B2", "C3" });
        List<string> rigthToLeftDiagonal = new List<string>(new string[] { "A3", "B2", "C1" });

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TakeInput(string box)
        {
            selectedBoxes.Add(box);

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
    }
}