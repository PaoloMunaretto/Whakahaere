using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whakahaere
{
    public class DataGridMetods
    {
        /// <summary>
        /// Set columns dataGridView
        /// </summary>
        /// <param name="dataGrid"></param>
        public void SetTypeDataGrid(DataGridView dataGrid)
        {            
            dataGrid.AutoGenerateColumns = false;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ReadOnly = true;


            //dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGrid.ColumnHeadersHeight = 50;
        }
    }
}
