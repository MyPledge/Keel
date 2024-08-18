using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keel.WPF.Demo
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            //Keel.WPF.Demo.App app = new Keel.WPF.Demo.App();
            //app.InitializeComponent();
            //app.Run();

            var builder = Application.CreateBuilder<App>(args);

           

            var app = builder.Build();

           
            app.Run();
        }
    }
}
