using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Szofttech_GyakDemo01.Properties;
using DevExpress.XtraEditors.Controls;

namespace Szofttech_GyakDemo01
{   
    public partial class MainMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        #region MainMenuConfiguration
        public MainMenu()
        {
            InitializeComponent();

            var mainDataFromXML = ReadXML.ReadRealXML.XMLRead("readxml.xml");
            if (Settings.Default.isMaximized == true)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            MessageBox.Show(mainDataFromXML.Adatok[0].Menuk.Elnevezes + " " + mainDataFromXML.Adatok[1].Menuk.Elnevezes);

            int counter = 0;
            List<string> Menus = new List<string>();
            for (int i = 0; i < mainDataFromXML.Adatok.Count; i++)
            {
                Menus.Add(mainDataFromXML.Adatok[i].Menuk.Elnevezes);
            }
            List<string> noDuplicatesMenus = Menus.Distinct().ToList();
            while (counter < noDuplicatesMenus.Count)
            {
                radioGroup1.Properties.Items.Add(new RadioGroupItem(noDuplicatesMenus[counter], noDuplicatesMenus[counter].ToString()));
                counter++;
            }
            counter = 0;
            while (counter < mainDataFromXML.Adatok.Count)
            {
                checkedListBoxControl1.Items.Add(mainDataFromXML.Adatok[counter].Termekek.Elnevezes);
                listBoxControl1.Items.Add(mainDataFromXML.Adatok[counter].Felhasznalok.Nev);
                counter++;
            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Szofttech_GyakDemo01.Properties.Settings.Default.Save();
                Application.ExitThread();
            }
        }

        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                Settings.Default.isMaximized = true;
            }
            else
            {
                Settings.Default.isMaximized = false;
            }
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region OrderType
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            NewOrder order = new NewOrder();
            order.Owner = this;
            order.ShowDialog();
            if (order.DialogResult == DialogResult.Yes)
            {
                fluentDesignFormContainer1.Visible = true;
                //fluentDesignFormContainer2.Visible = false;
            }
            else if (order.DialogResult == DialogResult.No)
            {
                Order order1 = new Order();
                order1.Owner = this;
                this.Hide();
                order1.ShowDialog();
            }
        }
        #endregion
        
        #region PriceCalculate
        private void checkedListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Termék hozzáadása egy listához, és ezzel együtt a termék szerinti árszámítás a végösszeghez!
        }

        private void checkedListBoxControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Menü hozzáadása egy listához, és ezzel együtt a termék szerinti árszámítás a végösszeghez!
        }

        private void checkedListBoxControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Előző rendelés hozzáadása egy listához, és ezzel együtt a termék szerinti árszámítás a végösszeghez!
        }

        public void ChangePrice(int prodprice)
        {
            string[] price = labelControl2.Text.Split(' ');
            int finalprice = Convert.ToInt32(price[1]) + prodprice;
            labelControl2.Text = "Végösszeg: " + finalprice + " Ft";
        }
        #endregion

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


        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Temporary! Delete when database is added!
            checkedListBoxControl3.Items.Clear();
            switch (listBoxControl1.SelectedIndex)
            {
                case 0:
                    checkedListBoxControl3.Items.Add("Hamburgermenü");
                    checkedListBoxControl3.Items.Add("Spagetti");
                    checkedListBoxControl3.Items.Add("Pizza menü");
                    break;
                case 1:
                    checkedListBoxControl3.Items.Add("Pizza menü");
                    checkedListBoxControl3.Items.Add("Hamburgermenü");
                    break;
                case 2:
                    checkedListBoxControl3.Items.Add("Sültkrumpli");
                    checkedListBoxControl3.Items.Add("Hamburgermenü");
                    checkedListBoxControl3.Items.Add("Gyros menü");
                    break;
                default:
                    break;
            }
            //Temporary stuff ends here! Do not delete any stuff below this comment!
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Owner = this;
            this.Hide();
            product.ShowDialog();
            //
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Owner = this;
            this.Hide();
            menu.ShowDialog();
            //
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient();
            ingredient.Owner = this;
            this.Hide();
            ingredient.ShowDialog();
            //
        }

        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            var mainDataFromXML = ReadXML.ReadRealXML.XMLRead("readxml.xml");
            int endosszeg = Convert.ToInt32(labelControl2.Text);
            if (checkedListBoxControl1.Items[checkedListBoxControl1.SelectedIndex].CheckState == CheckState.Checked)
            {
                endosszeg += Convert.ToInt32(mainDataFromXML.Adatok[checkedListBoxControl1.SelectedIndex].Termekek.Ar.Split(' ')[0]);
            }
            else
            {
                endosszeg -= Convert.ToInt32(mainDataFromXML.Adatok[checkedListBoxControl1.SelectedIndex].Termekek.Ar.Split(' ')[0]);
            }
            labelControl2.Text = (endosszeg).ToString();
        }
    }
}
