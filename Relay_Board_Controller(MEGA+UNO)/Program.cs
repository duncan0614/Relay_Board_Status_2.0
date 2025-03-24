using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relay_Board_Controller
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmStation station = new frmStation();
            station.ShowDialog();

            do {
                if (frmStation.strStation == "Arduino_UNO") {
                    Application.Run(new Relay_Board_UNO());
                }
                else if (frmStation.strStation == "Arduino_MEGA") {
                    Application.Run(new Relay_Board_MEGA());
                }
            }
            while (frmStation.strStation != "Closing");
            
            
            //Application.Run();
        }
    }
}
