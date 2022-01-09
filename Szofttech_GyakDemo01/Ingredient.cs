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
    public partial class Ingredient : DevExpress.XtraEditors.XtraForm
    {
        public Ingredient()
        {
            InitializeComponent();
            var mainDataFromXML = ReadXML.ReadRealXML.XMLRead("readxml.xml");
            int counter = 0;
            while (counter < mainDataFromXML.Adatok.Count)
            {
                listBoxControl1.Items.Add(mainDataFromXML.Adatok[counter].Alapanyagok.Elnevezes);
                counter++;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == "")
            {
                MessageBox.Show("A megnevezés nincs megadva!", "Hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool x = false;
                foreach (var item in listBoxControl1.Items)
                {
                    if (item.ToString() == textEdit1.Text)
                    {
                        x = true;
                    }
                }
                if (!x)
                {
                    listBoxControl1.Items.Add(textEdit1.Text);
                    MessageBox.Show("Sikeres alapanyag hozzáadás!", "Hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sikertelen alapanyag hozzáadás!\nMár szerepel a nyílvántartásban.", "Hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                textEdit1.Text = "";
            }
        }
        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
