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
    public partial class Order : DevExpress.XtraEditors.XtraForm
    {
        public Order()
        {
            InitializeComponent();
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text != "" && textEdit2.Text != "" && textEdit3.Text != "" && textEdit4.Text != "")
            {
                MessageBox.Show("Regisztrálás sikeres! Továbbítjuk a rendelésre.", "Regisztráció", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegisteredOrder order = new RegisteredOrder();
                order.Owner = this;
                this.Hide();
                order.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sikertelen regisztráció!", "Regisztráció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}