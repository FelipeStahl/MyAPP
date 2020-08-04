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
            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/FelipeStahl/MyAPP"))
            {
                await mgr.Result.UpdateApp();
            }
            Application.Run(new Form1());
        }
    }
}
