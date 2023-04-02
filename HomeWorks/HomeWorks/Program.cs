namespace HomeWorks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();


            var app = builder.Build();
            app.MapControllerRoute(
                name: "defalut",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}