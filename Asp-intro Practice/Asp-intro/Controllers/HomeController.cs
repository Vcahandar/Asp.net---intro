using Microsoft.AspNetCore.Mvc;

namespace Asp_intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int[] nums1 = { 1, 3, 2, 4, 5, 6, 7, 8 };
            int[] nums2 = { 10, 30, 20, 40, 50, 60, 70, 80 };
            Data data = new Data();
            data.Nums1 = nums1;
            data.Nums2 = nums2;

            return View(data);
        }





        //public string Index(int id)
        //{
        //    if (id == 0)
        //    {
        //        return "Aqshin";
        //    }

        //    return "Aqshin - " + id;

        //}

        //public string Detail(string slug,string name)
        //{
        //    return slug + " " + name;

        //}





        //public string Index(int id)
        //{

        //    return "Aqshin -" + id;

        //}

        //private string GetName()
        //{
        //    return "aqshin";
        //}
    }

    class Data {
        public int[] Nums1 { get; set; }
        public int[] Nums2 { get; set; }
    }
}
