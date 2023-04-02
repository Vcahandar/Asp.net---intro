using Microsoft.AspNetCore.Mvc;

namespace HomeWorks.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {

            //2) Home controllerin index action-da 1-den 20-e kimi ededlerin arasindan tek olanlari secib, viewda h3 taglarinde gostermek.

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int[] nums = { };

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                {
                    Array.Resize(ref nums, nums.Length + 1);
                    nums[nums.Length - 1] = i;

                }
            }
            return View(nums);

        }
    }
}
