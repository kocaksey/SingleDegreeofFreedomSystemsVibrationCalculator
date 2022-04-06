using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleDeg0fFreedomSystemsVibrationCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double fn = 0;
        double wn = 0;
        double time = 0;
        double cc = 0;
        double ccc = 0;
        double wd = 0;
        double q = 0;
        double tr = 0;
        double fd = 0;

    private void button1_Click(object sender, EventArgs e)
        {
            double m;
            double k;
            double c;
            double ohm;
            double.TryParse(txtMass.Text, out m);
            double.TryParse(txtK.Text, out k);
            double.TryParse(txtC.Text, out c);
            double.TryParse(txtHarmonic.Text, out ohm);

            if (txtMass.Text == "" || txtK.Text == "" || txtC.Text == "")
            {
                MessageBox.Show("Please enter values!", "Warning!");
            }
            else if (txtHarmonic.Text == "" && txtHarmonic.Enabled == true)
            {
                MessageBox.Show("Please enter values!", "Warning!");
            }
            else
            {
                wn = Math.Sqrt(k / m);
                
                fn = wn / (2 * Math.PI);
                
                time = 1 / fn;
                
                cc = 2 * m * wn;
                ccc = c * cc;
                wd = wn * (Math.Sqrt(1 - Math.Pow(c, 2)));
                q = 1 / (2 * c);
                tr = Math.Sqrt((1 + Math.Pow(  (2*c*ohm)/(wn) ,2)) / (  (Math.Pow(1-Math.Pow((ohm)/(wn),2) ,2)) + ( Math.Pow((2*c*ohm)/(wn),2))));
                fd = wd / (2 * Math.PI);
                wn = Math.Round(wn, 2);
                fn = Math.Round(fn, 2);
                time = Math.Round(time, 2);
                cc = Math.Round(cc, 2);
                ccc = Math.Round(ccc, 2);
                wd = Math.Round(wd, 2);
                q = Math.Round(q, 2);
                tr = Math.Round(tr, 2);
                fd = Math.Round(fd, 2);




                lbWn.Text = Convert.ToString(wn);
                
                lbFn.Text = Convert.ToString(fn);
                lbT.Text = Convert.ToString(time);
                lbCc.Text = Convert.ToString(cc);
                lbC.Text = Convert.ToString(ccc);
                lbWd.Text = Convert.ToString(wd);
                lbFd.Text = Convert.ToString(fd);
                lbQ.Text = Convert.ToString(q);
                lbTr.Text = Convert.ToString(tr);

                if (cmbFF.SelectedIndex == 0)
                {
                    lbTr.Text = "";
                }

                hz1.Visible = true;
                hz2.Visible = true;
                hz3.Visible = true;
                hz4.Visible = true;
                hz5.Visible = true;

            }
        }



        private void cmbFF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFF.Text == "Forced")
            {
                txtHarmonic.Enabled = true;
            }
            else
            {
                txtHarmonic.Enabled = false;
                txtHarmonic.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFF.SelectedIndex = 0;

        }

        private void txtMass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtMass.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtMass.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtMass.Text.StartsWith("0") && !txtMass.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtK.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtK.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtK.Text.StartsWith("0") && !txtK.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtC.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtC.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtC.Text.StartsWith("0") && !txtC.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtHarmonic_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtHarmonic.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtHarmonic.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtHarmonic.Text.StartsWith("0") && !txtHarmonic.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hz1.Visible = false;
            hz2.Visible = false;
            hz3.Visible = false;
            hz4.Visible = false;
            hz5.Visible = false;

            lbWn.Text = "";
            lbFn.Text = "";
            lbT.Text = "";
            lbCc.Text = "";
            lbC.Text = "";
            lbWd.Text = "";
            lbFd.Text = "";
            lbQ.Text = "";
            lbTr.Text = "";
            txtMass.Text = "";
            txtK.Text = "";
            txtC.Text = "";
            txtHarmonic.Text = "";
            cmbFF.SelectedIndex = 0;

        }
    }
}
