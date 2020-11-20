using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whakahaere
{
    public partial class FormBedroom : Form
    {
        public FormBedroom(string text)
        {
            InitializeComponent();
           // cbStatus.DataSource = Enum.GetValues(typeof(STATUSROOM));

            //define column Whidt
            dataGridNotes.Columns[0].Width = 100;
            dataGridNotes.Columns[1].Width = 270;

            btSave.Image = Resources.Properties.Resources.save;
            this.Text = text;
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            /*
            DialogResult res = MessageBox.Show(CONSTANT.saveQuestionMSG, CONSTANT.saveQuestionMSG,MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            //Saving new bedroom for this hotel
            if (res == DialogResult.Yes)
            {



                this.Close();
            }    
            */
        }
    }
}
