using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace PKG_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String contentidtext = "Content-ID = ";
            String contentidIn = textBox5.Text;
            String L = "k_licensee = ";
            String Lin = textBox6.Text;
            String Drm = "DRM_Type = ";
            String DrmIn = textBox7.Text;
            String contenttype = "Content_Type = ";
            String contenttypeIn = textBox8.Text;
            String plgversion = "PackageVersion = ";
            String pkgversionIn = textBox9.Text;
            output.Text = contentidtext + contentidIn + enter.Text + L + Lin + enter.Text + Drm + DrmIn + enter.Text + contenttype + contenttypeIn + enter.Text + plgversion + pkgversionIn;
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PS3 Pkg Conf (*.conf)|*.conf";
            saveFileDialog1.Title = "Save Config";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                //Write a line of text
                sw.Write(output.Text);
                //Close the file
                sw.Close();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Left = 369;
                textBox5.Width = 243;
                textBox5.Text = "UP0001-ABCD12345_00-0000111122223333";
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                info.Visible = false;
            }
            else
            {
                checkBox1.Left = 179;
                textBox5.Width = 68;
                textBox5.Text = "ABCD12345";
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                info.Visible = true;
            }
        }
    }
}
