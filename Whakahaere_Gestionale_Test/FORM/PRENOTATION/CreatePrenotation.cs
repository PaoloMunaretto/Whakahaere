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
        public CreatePrenotation(string info, DateTime start, DateTime stop)
        {
            InitializeComponent();
            this.Text += " - " + info;
            this.Icon = Resources.Properties.Resources.DatabaseICO;
            dateStart.Value = start;
            dateStop.Value = stop;
        }

        private void dataGridTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                //if row selected is Client

                //If row selected is Room

                //If row selected is Prenotation

                //  => Show Form with object and close this.Close(); 
                    
            }
            catch (Exception)
            { }
        }
    }
}
