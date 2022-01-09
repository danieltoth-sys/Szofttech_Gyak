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
using DevExpress.XtraEditors.Controls;

namespace Szofttech_GyakDemo01
{
    public partial class RegisteredOrder : DevExpress.XtraEditors.XtraForm
    {
        public RegisteredOrder()
        {

            InitializeComponent();
            var mainDataFromXML = ReadXML.ReadRealXML.XMLRead("readxml.xml");
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
            radioGroup1.SelectedIndex = 0;
            radioGroup1.Enabled = true;
            checkedListBoxControl1.Enabled = false;
            counter = 0;
            while (counter < mainDataFromXML.Adatok.Count)
            {
                checkedListBoxControl1.Items.Add(mainDataFromXML.Adatok[counter].Termekek.Elnevezes);                
                counter++;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Szeretné leadni a rendelést?", "Rendelés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {

                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba történt leadás közben! Ellenőrizze az adatokat!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("A rendelést sikeresen leadta!", "Rendelés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            var mainDataFromXML = ReadXML.ReadRealXML.XMLRead("readxml.xml");
            if (simpleButton1.Visible == false)
            { 
                double endosszeg = Convert.ToDouble(labelControl2.Text);
                if (checkedListBoxControl1.Items[checkedListBoxControl1.SelectedIndex].CheckState == CheckState.Checked)
                {
                    if (radioGroup1.SelectedIndex == 0)
                    {
                        endosszeg += Convert.ToInt32(mainDataFromXML.Adatok[checkedListBoxControl1.SelectedIndex].Termekek.Ar.Split(' ')[0]) * 0.7;
                        listBoxControl1.Items.Add(mainDataFromXML.Adatok[checkedListBoxControl1.SelectedIndex].Termekek.Elnevezes + " " + radioGroup1.Properties.Items[radioGroup1.SelectedIndex] + " " + "True");
                    }
                    else
                    {
                        endosszeg += Convert.ToInt32(mainDataFromXML.Adatok[checkedListBoxControl1.SelectedIndex].Termekek.Ar.Split(' ')[0]);
                        listBoxControl1.Items.Add(mainDataFromXML.Adatok[checkedListBoxControl1.SelectedIndex].Termekek.Elnevezes + " " + radioGroup1.Properties.Items[radioGroup1.SelectedIndex] + " " + "False");
                    }
                }
                else
                {
                    if (radioGroup1.SelectedIndex == 0)
                    {
                        endosszeg -= Convert.ToInt32(mainDataFromXML.Adatok[checkedListBoxControl1.SelectedIndex].Termekek.Ar.Split(' ')[0]) * 0.7;
                    }
                    else
                    {
                        endosszeg -= Convert.ToInt32(mainDataFromXML.Adatok[checkedListBoxControl1.SelectedIndex].Termekek.Ar.Split(' ')[0]);
                    }
                }

                labelControl2.Text = (endosszeg).ToString();
                radioGroup1.Enabled = true;
                checkedListBoxControl1.Enabled = false;
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioGroup1.Enabled = false;
            checkedListBoxControl1.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan végzett a termékek felvételével?", "Összesítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                simpleButton1.Visible = true;
                simpleButton2.Visible = false;
                checkedListBoxControl1.Enabled = false;
                int counter = 0;
                while (counter < checkedListBoxControl1.CheckedItems.Count)
                {
                    radioGroup2.Properties.Items.Add(new RadioGroupItem(checkedListBoxControl1.CheckedItems[counter], checkedListBoxControl1.CheckedItems[counter].ToString()));
                    counter++;
                }
            }
            groupControl1.Visible = true;
            radioGroup1.Enabled = false;
            checkedListBoxControl1.Enabled = true;

        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var mainDataFromXML = ReadXML.ReadRealXML.XMLRead("readxml.xml");
            int counter = 0;
            if (radioGroup2.Properties.Items.Count != 0)
            {
                if (simpleButton1.Visible == true)
                {
                    double endosszeg = Convert.ToDouble(labelControl2.Text);
                    while (counter < mainDataFromXML.Adatok.Count)
                    {
                        if (listBoxControl1.Items[radioGroup2.SelectedIndex].ToString().Split(' ')[0] == mainDataFromXML.Adatok[counter].Termekek.Elnevezes)
                        {
                            if (listBoxControl1.Items[radioGroup2.SelectedIndex].ToString().Split(' ')[2] == "True")
                            {
                                endosszeg -= Convert.ToDouble(mainDataFromXML.Adatok[counter].Termekek.Ar.ToString().Split(' ')[0]) * 0.7;
                                break;
                            }
                            else
                            {
                                endosszeg -= Convert.ToDouble(mainDataFromXML.Adatok[counter].Termekek.Ar.ToString().Split(' ')[0]);
                                break;
                            }
                        }
                        counter++;
                    }
                    radioGroup2.Properties.Items.Remove(radioGroup2.Properties.Items[radioGroup2.SelectedIndex]);
                    labelControl2.Text = endosszeg.ToString();
                }
                else
                {
                    simpleButton4.Enabled = false;
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            groupControl1.Visible = false;
        }
    }
}