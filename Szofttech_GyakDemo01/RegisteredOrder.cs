using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szofttech_GyakDemo01
{
    public partial class RegisteredOrder : DevExpress.XtraEditors.XtraForm
    {
        public RegisteredOrder()
        {

            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Szeretné leadni a rendelést?", "Rendelés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //Rendelésleadás metódus/class meghívás
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba történt leadás közben! Ellenőrizze az adatokat!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("A rendelést sikeresen leadta!", "Rendelés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}