using Microsoft.Extensions.DependencyInjection;
using EmployeeDetails.Interface;
using EmployeeDetails.Service;

namespace EmployeeDetails
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Create a new HttpClient to be used by the EmployeeService
            var httpClient = new HttpClient();

            //Create a new ServiceCollection and add the EmployeeService with the HttpClient as a dependency
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton(httpClient);
            serviceCollection.AddSingleton<IEmployeeService, EmployeeService>();

            //Build the service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            //Create a new instance of Form1 with the service provider
            try
            {
                var form1 = new EmployeeData(new EmployeeService(httpClient));
                form1.Show();
                Application.Run(form1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}