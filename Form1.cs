using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cases_à_Coucher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.Text = "green";
            checkBox2.Text = "yellow";
            checkBox3.Text = "white";
            checkBox4.Text = "black";
            checkBox5.Text = "red";
            checkBox6.Text = "Orange";
            checkBox7.Text = "Blue";
            checkBox8.Text = "Marron";
            checkBox9.Text = "pink";
            checkBox10.Text = "Phosphor";

        }
            

        private List<string> menu =new List<string>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            if(menu!=null)
            for (int i = 0; i < menu.Count; i++)
                textBox1.Text += menu[i]+Environment.NewLine;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked ) {
                menu.Add(checkBox1.Text);
            }
            else
                menu.Remove(checkBox1.Text);


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                menu.Add(checkBox2.Text);
            }
            else
                menu.Remove(checkBox2.Text);

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                menu.Add(checkBox3.Text);
            }
            else
                menu.Remove(checkBox3.Text);

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                menu.Add(checkBox4.Text);
            }
            else
                menu.Remove(checkBox4.Text);

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                menu.Add(checkBox5.Text);
            }
            else
                menu.Remove(checkBox5.Text);

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                menu.Add(checkBox6.Text);
            }
            else
                menu.Remove(checkBox6.Text);

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                menu.Add(checkBox7.Text);
            }
            else
                menu.Remove(checkBox7.Text);

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                menu.Add(checkBox8.Text);
            }
            else
                menu.Remove(checkBox8.Text);

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                menu.Add(checkBox9.Text);
            }
            else
                menu.Remove(checkBox9.Text);

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                menu.Add(checkBox10.Text);
            }
            else
                menu.Remove(checkBox10.Text);

        }

        private void button_RMZ_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            textBox1.Text = null;
            menu.Clear();
    }

    private void button_fermer_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
