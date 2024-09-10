namespace MVC_Session02_Demo.Net8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           // builder.Services.AddControllers();//register the built-in apis services in the container
            builder.Services.AddControllersWithViews();//register the built-in mvc services in the container
         //   builder.Services.AddRazorPages();//register the built-in Razor Pages services in the container
           // builder.Services.AddMvc();//register the built-in ALL WEB SERVICES in the container
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            //app.MapGet("/signin", signin);
            //routing constraints
            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Test}/{id:int=1}");
            app.Run();
        }
        //static string signin()
        //{
        //    return "sign in";
        //}
    }
}
