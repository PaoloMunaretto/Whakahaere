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
    public partial class CreatePrenotation : Form
    {
        public event EventHandler SavePrenotation;


        public CreatePrenotation(string info, DateTime start, DateTime stop)
        {
            InitializeComponent();
            this.Text += " - " + info;
            this.Icon = Resources.Properties.Resources.DatabaseICO;
            dateStart.Value = start;
            dateStop.Value = stop;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
