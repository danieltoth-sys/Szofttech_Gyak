using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Szofttech_GyakDemo01
{
    static class Program
    {
        #region Program&MainConfiguration
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new LoginScreen());
            }
            catch (Exception)
            {
                MessageBox.Show("Ismeretlen hiba történt a program működése során! Az alkalmazás leáll!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }
        #endregion
    }
}