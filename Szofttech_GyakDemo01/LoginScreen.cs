using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szofttech_GyakDemo01.Properties;
using DevExpress.LookAndFeel;

namespace Szofttech_GyakDemo01
{
    public partial class LoginScreen : DevExpress.XtraEditors.XtraForm
    {
        //Temporary! Delete when database is added!
        public string username;
        public string password;
        //Temporary stuff ends here! Do not delete any stuff below this comment!
        #region LoginScreenConfiguration
        public LoginScreen()
        {
            //Temporary! Delete when database is added! //Temporary account!
            username = "user";
            password = "123";
            //
            InitializeComponent();

            if (Properties.Settings.Default.isDark == true)
            {
                this.LookAndFeel.SetSkinStyle(UserLookAndFeel.Default.SkinName, SkinSvgPalette.Bezier.MercuryIce);
            }
            else
            {
                this.LookAndFeel.SetSkinStyle(UserLookAndFeel.Default.SkinName, SkinSvgPalette.Bezier.OfficeColorful);
            }

            textEdit2.Properties.PasswordChar = '*';
        }
        #endregion
        #region CheckDatasForLogin
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (username != textEdit1.Text || password != textEdit2.Text)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás felhasználónév, vagy jelszó!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Sikeres bejelentkezés!", "Belépés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainMenu main = new MainMenu();
            main.Owner = this;
            this.Hide();
            main.ShowDialog(this);            
        }
        #endregion
    }
}
