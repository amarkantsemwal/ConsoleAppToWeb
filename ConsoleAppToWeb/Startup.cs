namespace ConsoleAppToWeb
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection serviceDescriptors) { 
        }

        public void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment webHostBuilder)
        {
            applicationBuilder.UseRouting();
            applicationBuilder.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context => {
                    await context.Response.WriteAsync("Welcome!");
                });    
            });
        }


        

        
    }
}
