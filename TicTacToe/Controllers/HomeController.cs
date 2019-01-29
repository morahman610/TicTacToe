using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicTacToe.Controllers
{
    public class HomeController : Controller
    {
        List<string> playerBoxes = new List<string>();
        List<string> aIBoxes = new List<string>();

        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(string selectedBox)
        {

          /*  if (newGame)
                playerBoxes.Clear(); */

            playerBoxes.Add(selectedBox);

            ViewBag.A2 = selectedBox;

            List<string>[] rowsAndColumns = new List<string>[8];

            List<string> topRow = new List<string> { "A1", "B1", "C1" };
            rowsAndColumns[0] = topRow;
            List<string> middleRow = new List<string> { "A2", "B2", "C2" };
            rowsAndColumns[1] = middleRow;
            List<string> bottomRow = new List<string> { "A3", "B3", "C3" };
            rowsAndColumns[2] = bottomRow;
            List<string> leftColumn = new List<string> { "A1", "A2", "A3" };
            rowsAndColumns[3] = leftColumn;
            List<string> middleColumn = new List<string> { "B1", "B2", "B3" };
            rowsAndColumns[4] = middleColumn;
            List<string> rightColumn = new List<string> { "C1", "C2", "C3" };
            rowsAndColumns[5] = rightColumn;
            List<string> leftToRigtDiagonal = new List<string> { "A1", "B2", "C3" };
            rowsAndColumns[6] = leftToRigtDiagonal;
            List<string> rigthToLeftDiagonal = new List<string> { "A3", "B2", "C1" };
            rowsAndColumns[7] = rigthToLeftDiagonal;

            bool keepGoing = true;

            foreach (List<string> a in rowsAndColumns)
            {
                if (playerBoxes == a)
                {
                    keepGoing = false;
                }

                else if (aIBoxes == a)
                {
                    keepGoing = false;
                }
            }

            ViewBag.Message = null;

            if (keepGoing == false)
            {
                ViewBag.Message = "Congradulations! You've won!";
            }



            Random rnd = new Random();

            int aIRowNumber = rnd.Next(0, 2);
            int aiColumnNumber = rnd.Next(0, 2);

            List<string> aIColumn = rowsAndColumns[aIRowNumber];

            string aIselectedBox = aIColumn[aiColumnNumber];
            
            return View();
        }

        public ActionResult TakeInput(string box)
        {
            playerBoxes.Add(box);

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