using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETact.Controllers
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
        public ActionResult Practice()
        {
            return View();
        }
        public ActionResult Practice1()
        {
            return View();
        }
        public ActionResult CustomerBill()
        {
            return View();
        }
        public ActionResult Sample()
        {
            return View();
        }

        public ActionResult Nice()
        {
            return View();
        }
        public ActionResult CustomerBills()
        {
            return View();
        }
        public ActionResult Triangle()
        {
            return View();
        }
        public ActionResult Grde()
        {
            return View();
        }
        public  ActionResult Speed()
        {
            return View();
        }
        public ActionResult Xample()
        {
            return View();
        }
        public ActionResult Sample2()
        {
            return View();
        }
        
        public ActionResult Sample3()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Sirsample1()
        {

            return View();
        }
        public ActionResult Sirsample2()
        {
            var data = new List<object>();
            var lastname = Request["lname"];
            var firstname = Request["fname"];

            data.Add(new
            {
                mess = 0
            
            });
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult SirEx()
        {

            return View();
        }
        public ActionResult SirEx1()
        {
            var data = new List<object>();
            var firstname = Request["fname"];
            var lastname = Request["lname"];
            var genders = Request["Gendr"];
            var provinces = Request["province"];
            data.Add(new
            {
                mess = 1
            });
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult StudentsAcc()
        {
            return View();
        }
       
        public ActionResult StudAcc()
        {
            return View();
        }
        // public ActionResult StudentsAcc2()
        //{
        //    var data = new List<object>();

        //    // Retrieve data from request parameters
        //    var IDnum = Request["IDnum"];
        //    var LastName = Request["LastName"];
        //    var FrstName = Request["FrstName"];
        //    var Gnder = Request["Gnder"];
        //    var CodeCourse = Request["CodeCourse"];
        //    var Years = Request["Years"];
        //    var Subjects = Request["Subjects"];
        //    var TotalUnits = Request["TotalUnits"];
        //    var TuitionPerUnit = Request["TuitionPerUnit"];
        //    var TotalTuition = Request["TotalTuition"];
        //    var Registration = Request["Registration"];
        //    var Miscellaneous = Request["Miscellaneous"];
        //    var LabFees = Request["LabFees"];
        //    var TotalFeesCourse = Request["TotalFeesCourse"];
        //    var Assessment = Request["Assessment"];
        //    var TotalFee = Request["TotalFee"];
        //    var Balance = Request["Balance"];
        //    var Pesos = Request["Pesos"];
        //    var Centavos = Request["Centavos"];
        //    var Results = Request["Results"];
        //    var AmountPayS = Request["AmountPay"];
        //    data.Add(new

        //    {
        //        mess = 1
        //        //IDnum = IDnum,
        //        //LastName = LastName,
        //        //FrstName = FrstName,
        //        //Gnder = Gnder,
        //        //CodeCourse = CodeCourse,
        //        //Years = Years,
        //        //Subjects = Subjects,
        //        //TotalUnits = TotalUnits,
        //        //TuitionPerUnit = TuitionPerUnit,
        //        //TotalTuition = TotalTuition,
        //        //Registration = Registration,
        //        //Miscellaneous = Miscellaneous,
        //        //LabFees = LabFees,
        //        //TotalFeesCourse = TotalFeesCourse,
        //        //Assessment = Assessment,
        //        //TotalFee = TotalFee,
        //        //Balance = Balance,
        //        //Pesos = Pesos,
        //        //Centavos = Centavos,
        //        //Results = Results,
        //        //AmountPayS = AmountPayS
        //    });
        //    return Json(data, JsonRequestBehavior.AllowGet);


        //}
        public ActionResult SystemController()
        {
            var data = new List<object>();

            // Retrieve data from request parameters
            
            var FrstName = Request["FrstName"];
            
            var Balance = Request["Balance"];
            
            data.Add(new
            {
                mess = 0, 
                mess1 = "Mr./Ms. " + FrstName + "  you have successfully paid. Your balance is " + Balance

            });
                return Json(data, JsonRequestBehavior.AllowGet);
          }
        public ActionResult Gibo()
        {
            return View();
        }
        public ActionResult Fract()
        {
            return View();
        }
        public ActionResult Kfact()
        {
            return View();
        }

        public ActionResult Forloopajax()
        {
            var data = new List<object>();

            var num3 = Int32.Parse(Request["n3"]);
            var pri = "";

            var sum = 0;
            for (int i = 1; i < num3; i++)
            {
                if (num3 % i == 0)
                {
                    sum += i;
                }
            }

            if (num3 == sum)
            {
                pri = "perfect";
            }
            else
            {
                pri = "not perfect";
            }

            // Calculate factorial
            int factorial = 1;
            for (int i = 1; i <= num3; i++)
            {
                factorial *= i;
            }

            // Add the result to the data list
            data.Add(new
            {
                mess = 1,
                perfect = pri,
                factorial = factorial // Add factorial to the object
            });

            // Return the JSON data
            return Json(data, JsonRequestBehavior.AllowGet);
        }

       
        public ActionResult Loopajax()
        {
            var data = new List<object>();

            var num3 = Int32.Parse(Request["n3"]);
            var pri = "";
            var fact = factorial(num3);
            var per = "";




            if (perfect(num3))
            {
                per = "PERFeCT";
            }
            else
            {
                per = "NOT PERFECT";
            }


            data.Add(new
            {
                mess = 1,
                perfect = per,
                factorial = fact,


            });
            return Json(data, JsonRequestBehavior.AllowGet);
        }




        static Boolean perfect(int num3)
        {

            int sum = 0;
            for (int i = 1; i < num3; i++)
            {
                if (num3 % i == 0)
                {
                    sum += i;
                }

            }

            if (num3 == sum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static long factorial(int num3)
        {

            long fact = 1;

            for (int i = 1; i <= num3; i++)
            {
                fact *= i;
            }
            return fact;

        }

        public ActionResult CubeChecker()
        {
            var data = new List<object>();

            int number = Int32.Parse(Request["number"]);
            var result = "";

            if (number < 0)
            {
                result = "Please enter a positive integer.";
            }
            else
            {
                int root = (int)Math.Round(Math.Pow(number, 1.0 / 3));
                if (root * root * root == number)
                {
                    result = $"{number} is a perfect cube.";
                }
                else
                {
                    result = $"{number} is not a perfect cube.";
                }
            }

            data.Add(new
            {
                message = result
            });

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult PracticeAjax()
        {
            return View();
        }
        public ActionResult Factor()
        {
            var data = new List<object>();
            var num = Int32.Parse(Request["number"]);

            //var factorial = factorial(number);
            var per = "";

           
            var sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            
            if (num== sum)
            {
                per = "perfect";
            }
            else
            {
                per = "not perfect";
            }
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            data.Add(new
            {
                mess = 1,
                factorial = factorial,
                perfect = per
            });

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Facts()
        {
            var data = new List<object>();
            var number = Request["number"];
            var factorial = Request["factorial"];
            var perfect = Request["perfect"];


            data.Add(new
            {
                mess=1,
                factorial = factorial,
                perfect = perfect
            });

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Cube()
        {
            return View();
        }
        public ActionResult CubeAjax()
        {
            var data = new List<object>();
            var number = Int32.Parse(Request["number"]);
            var per = "";
            var cbs = Math.Round(Math.Pow(number, 1.0/3.0));
            //var cbs = Math.Pow(number, 3);
            
                if (number == cbs*cbs*cbs)
                {
                    per = "PERFECT CUBE";
                }
                else
                {
                    per = "NOT PERFECT CUBE";
                }
            
            data.Add(new
            {
                mess = 1,
                cube = cbs,
                perfect = per
            });
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        

    }
}