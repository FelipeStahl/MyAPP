using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace MyApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var mgr = new UpdateManager(@"C:\Users\Felipe-Sistema\Source\Repos\MyApp\Releases"))
            {
                await mgr.UpdateApp();
            }
            Application.Run(new Form1());
        }
    }
}
