//
// Copyright easy-does-it.de project maintainers and contributors.
// Licensed under the MIT license.
//

namespace StaticHtml
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }

    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseDefaultFiles(); // must come before UseStaticFiles
            app.UseStaticFiles();
        }
    }
}
