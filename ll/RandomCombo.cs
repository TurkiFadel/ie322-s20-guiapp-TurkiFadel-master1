using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ll
{
    public partial class frmRandomCombo : Form
    {
        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            Randomcomb.ResetText();       
            Randomcomb.Items.Clear();    
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                Randomcomb.Items.Add(r.Next(100, 999));
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {

            Randomcomb.ResetText();
            Randomcomb.Items.Clear();
            rdoLess.Checked = false;
            rdoGreater.Checked = false;
        }

        private void Randomcomb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Randomcomb.Text) > 499)
            {
                rdoGreater.Checked = true;
            }
            else
            {
                rdoLess.Checked = true;
            }

        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void GenerateBtn2_Click(object sender, EventArgs e)
        {
            Randomcomb2.ResetText();
            Randomcomb2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                Randomcomb2.Items.Add(r.Next(10, 99));
            }
            label1.Text = Convert.ToString(Randomcomb2.Items.Count);
        }

        private void Randomcomb2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Randomcomb2.Text) > 49)
            {
                rdoGreater2.Checked = true;
            }
            else
            {
                rdoLess2.Checked = true;
            }

        }

        private void Resetbtn2_Click(object sender, EventArgs e)
        {
            Randomcomb2.ResetText();
            Randomcomb2.Items.Clear();
            rdoLess2.Checked = false;
            rdoGreater2.Checked = false;
            label1.Text = Convert.ToString(Randomcomb2.Items.Count);

        }

        private void rdoLess_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRandomCombo_Load(object sender, EventArgs e)
        {

        }
    }
}