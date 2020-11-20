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
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
            this.Icon = Resources.Properties.Resources.invoiceICO;
            
            //Cisualizziamo la prenotazione e permettiamo il completamento del pagamento
        }
    }
}
