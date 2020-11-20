using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resources;
using Override;
using MyLibrary;
using System.Globalization;

// IF/ELSE QUICK =>  string bedsFormatted = (beds == 1) ? "1 bed" : String.Format("{0} beds", beds);

namespace Whakahaere
{
    public partial class Whakahaere : Form
    {
        QueryDatabase queryDB = new QueryDatabase();
        DataGridMetods dataGridMetods = new DataGridMetods();
        CreatePrenotation MenuData; // Form for create new prenotation

        DataTable tableRoom; //Table with all room in Hotel
        int[] daysMonth = new int[12];
        string[] monthName = new string[12];

        //Inizio e fine nuova prenotazione
        DateTime startPrenotation;
        DateTime stopPrenotation;

        //Index of selected cell in dataGridView
        int _selectedRow = -1;
        int _selectedColumn = -1;

        public Whakahaere()
        {
            InitializeComponent();
            MyTimer.Start();
            LoadImages();

            toolStripButtons.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
            dataGridMetods.SetTypeDataGrid(dataGridRoom);

            //Set static variable
            STATIC.tutorialFile = System.Windows.Forms.Application.StartupPath + @"\Information\Tutorial.pdf";
            STATIC.stringConnectionDatabase = String.Format($"server= {CONST.NAME_SERVER}; port= {CONST.PORT}; Database= {CONST.DATABASE_NAME}; uid={ CONST.NAME_USER}; password={CONST.PASSWORD}");

            //Load year on combobox
            for (int i = 2000; i <= 2100; i++)
            {
                cbYear.Items.Add(i);
            }

            //Set year, month, data current
            DateTime dt = DateTime.Today;
            cbYear.Text = dt.Year.ToString();
            for (int i = 1; i <= daysMonth.Length; i++)
            {
                daysMonth[i - 1] = DateTime.DaysInMonth(Convert.ToInt32(cbYear.Text), i);
                monthName[i - 1] = DateTimeFormatInfo.CurrentInfo.GetMonthName(i).ToString().ToUpper();
            }

            //Load all tablesName 
            STATIC.SetTablesArray(queryDB.ReadAllTablesDB(STATIC.stringConnectionDatabase, CONST.readAllTableDB));

            //Carichiamo tutte le camere disponibili su DataTable
            string query = CONST.readTableDB + "bedroom";

            //Carichiamo tutti gli elementi della tabella bedroom
            tableRoom = queryDB.GetTableItems(STATIC.stringConnectionDatabase, query);

            SetTableInDataGrid(dataGridRoom, tableRoom);
        }

        //*****************************************************************************************************************
        //  Events in this Class

        /// <summary>
        /// Change second
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Close MyTimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Whakahaere_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyTimer.Stop();
        }

        /// <summary>
        /// Show pdf with tutorial information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showTutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show pdf with tutorial information of this software            
            if (File.Exists(STATIC.tutorialFile))
            {
                System.Diagnostics.Process.Start(STATIC.tutorialFile);
            }
            else
            {
                MessageBox.Show(STATIC.tutorialFile + "\n\n" + STATIC.tutorialFile, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Move to column DateTime Today
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTime_Click(object sender, EventArgs e)
        {
            //Vai alla colonna con la data odierna (cambia anche la combobox Year)
            string st = DateTime.Today.ToShortDateString();
            int ind = dataGridRoom.Columns[st].Index;
            dataGridRoom.FirstDisplayedScrollingColumnIndex = ind;
        }





        /// <summary>
        /// Se abbiamo inserito gli oggeti come dataSource, con CurrentRow.DataBoundItem visualizziamo l'oggetto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Prendiamo l'oggetto selezionato dalla riga
            Bedroom roomSelect = (Bedroom)dataGridRoom.CurrentRow.DataBoundItem; //Row , ItemArray

            //Visualizziamo le informazioni base
            string info = String.Format($"Floor: {roomSelect.Floor}\nRoom: { roomSelect.Room }\nStatus: { roomSelect.Status}");
            MessageBox.Show(info, CONST.titleReferenceRoom);
        }

        /// <summary>
        /// Tasto destro del mouse sulle celle, ed apriamo la prenotazione sulle celle selezionate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridRoom_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //View UserControl and add prenotation
            try
            {
                if (dataGridRoom.SelectedCells.Count > 0)
                {
                    switch (e.Button)
                    {
                        case MouseButtons.Left: //Close UserControl with textMenu
                            if (MenuData != null)
                                MenuData.Dispose();
                            break;

                        case MouseButtons.Right: //Open UserControl with textMenu
                            if (MenuData != null)
                            {
                                MenuData.Dispose();
                            }
                           MenuData = new CreatePrenotation("insert room + floor", startPrenotation, stopPrenotation);
                            MenuData.ShowDialog();
                            // dataGridTable.Controls.Add(MenuData); //se fosse uno userControl
                            //MenuData.SuspendLayout();
                            //MenuData.ResumeLayout(false);
                            break;
                    }
                }
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Take all horizontal cell for prenotation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridRoom_SelectionChanged(object sender, EventArgs e)
        {
            SetValueCell();
        }

        /// <summary>
        /// PAINT OBJECT OVER DATAGRIDVIEW
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridRoom_Paint(object sender, PaintEventArgs e)
        {
            //TESTING - INSERT RECTANGLE OVER COLUMN AND ADD MONTH AND YEAR
            //TOO SLOW PROGRAM AND INCONSTANT
            {/*
            int colStart = 2;
            for (int i = 0; i < monthName.Length; i++)
            {                
                //Creiamo un rettangolo, che parta dalla colona 2 e va fino alla fine
                Rectangle rectangle = this.dataGridRoom.GetCellDisplayRectangle(colStart, -1, true);
                rectangle.X += 1;
                rectangle.Y += 1;

                //Il rettangolo sarà largo come il num. di giorni del mese
                rectangle.Width = rectangle.Width * daysMonth[i]+130;
                rectangle.Height = rectangle.Height / 2;

                //Inseriamo il rettangolo
                e.Graphics.FillRectangle(new SolidBrush(this.dataGridRoom.ColumnHeadersDefaultCellStyle.BackColor), rectangle);

                //Incapsuliamo le informazioni nel seguente formato
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                //Inseriamo i valori graficamente
                e.Graphics.DrawString(monthName[i]+"  "+cbYear.Text ,
                    this.dataGridRoom.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(this.dataGridRoom.ColumnHeadersDefaultCellStyle.ForeColor),
                    rectangle,
                    format);

                colStart += daysMonth[i];
            }
            */
        }


        }

        /// <summary>
        /// INSERT REDLINE WHEN DAY.TODAY START
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridRoom_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                string st = DateTime.Today.ToShortDateString();
                int index = dataGridRoom.Columns[st].Index;
                var redPen = new Pen(Color.Red, 1);
                var bluePen = new Pen(Color.DarkGray, 3);

                //Get the x coordination value of the left line
                int left_x = dataGridRoom.GetColumnDisplayRectangle(dataGridRoom.Columns[index].Index, false).Left;
                int left_s = dataGridRoom.GetColumnDisplayRectangle(dataGridRoom.Columns[2].Index, false).Left;

                //Get the x coordination value of the right line
                // int right_x = dataGridRoom.GetColumnDisplayRectangle(dataGridRoom.Columns[index].Index, false).Right;
                //Get the y coordination value of the top of each line
                int top_y = dataGridRoom.GetRowDisplayRectangle(dataGridRoom.Rows[0].Index, false).Top;
                //Get the y coordination value of the bottom of each line
                int bottom_y = dataGridRoom.Height;
                //Draw the lines using red pen and the x, y values above
                e.Graphics.DrawLine(redPen, new Point(left_x, top_y), new Point(left_x, bottom_y));
                e.Graphics.DrawLine(bluePen, new Point(left_s, top_y), new Point(left_s, bottom_y));
                // e.Graphics.DrawLine(redPen, new Point(right_x, top_y), new Point(right_x, bottom_y));

                //INSERT VERTICAL LINE FOR EACH MONTH => TOO VERY SLOW !!!
                { /*
                  int colVal = 2;

                  for (int i = 0; i < daysMonth.Length; i++)
                   {
                       colVal += daysMonth[i];
                       int splitMonth = dataGridRoom.GetColumnDisplayRectangle(dataGridRoom.Columns[colVal].Index, false).Left;
                       e.Graphics.DrawLine(bluePen, new Point(splitMonth, top_y), new Point(splitMonth, bottom_y));
                   }
                 */
                }

            }
            catch (Exception)
            { }
        }

        //*****************************************************************************************************************
        // Metods in this Class

        /// <summary>
        /// Load all images on buttons in Whakahaere
        /// </summary>
        private void LoadImages()
        {
            //Load images
            this.Icon = Resources.Properties.Resources.Hotel;
            btPrenotations.Image = Resources.Properties.Resources.calendar;
            btBedrooms.Image = Resources.Properties.Resources.bedroom;
            btSettings.Image = Resources.Properties.Resources.setting;
            btInformations.Image = Resources.Properties.Resources.information;
            btPayment.Image = Resources.Properties.Resources.invoice;

            //Set ToolStripStatus
            lblTime.Image = Resources.Properties.Resources.clock;
            lblTime.ImageAlign = ContentAlignment.MiddleRight;
            lblTime.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Impostiamo i dati della nostra Tabella alla dataGridView
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <param name="table"></param>
        public void SetTableInDataGrid(DataGridView dataGrid, DataTable table)
        {
            /* 
            //Metodo veloce per caricare tutti i valori e visualizzare tutti gli elementi come colonne
            BindingSource source = new BindingSource { DataSource = table };
            dataGrid.DataSource = source;
            */

            List<Bedroom> RoomsHotel = new List<Bedroom>();
            BedroomMetods metods = new BedroomMetods();

            
            foreach (DataRow row in table.Rows)
            {
                Bedroom room = metods.ConvertRowToObject(row);
                RoomsHotel.Add(room);
            }

            //Settiamo le colonne della DataGridView
            var NameField1 = new DataGridViewTextBoxColumn();
            NameField1.HeaderText = "Floor";
            NameField1.Name = "Floor";
            NameField1.DataPropertyName = "Floor";
            dataGrid.Columns.Add(NameField1);
            dataGrid.Columns[NameField1.Name].Frozen = true;

            var NameField = new DataGridViewTextBoxColumn();
            NameField.HeaderText = "Room";
            NameField.Name = "Room";
            NameField.DataPropertyName = "room";
            dataGrid.Columns.Add(NameField);
            dataGrid.Columns[NameField.Name].Frozen = true;

            BindingSource source = new BindingSource(); //{ DataSource = RoomsHotel };//{ DataSource = table };
            source.DataSource = RoomsHotel; // table;


            //Load Calendr on dataGridView
            LoadCalendar(Convert.ToInt32(cbYear.Text), dataGrid);
            dataGrid.DataSource = source;
        }

        /// <summary>
        /// Load on dataGrid calendar in column reference
        /// </summary>
        /// <param name="year"></param>
        private void LoadCalendar(int year, DataGridView dataGrid)
        {
            DateTime dt = new DateTime(year, 1, 1);
            int nextyear = year + 1;
            while (year < nextyear)
            {
                CreateColumn(dt, dataGrid);

                //Avanziamo di un giorno
                dt = dt.AddDays(1);
                year = dt.Year;
            }
            {
                /*//Vogliamo inserire un anno completo, dal primo giorno a capodanno
                 * for (int i = 0; i < DateTime.DaysInMonth(year, 1); i++)
                {
                    int dayNum = i + 1;
                    dt = new DateTime(year, 1, dayNum);

                    CreateColumn(dt.DayOfWeek, dt);
                }*/
                // int row = dataGridRoom.Rows.Add();
                // dataGridRoom.Rows[row].HeaderCell.Value = dt.ToString("MMMM");
                //source.Add(dt.ToString("MMMM")); //Gli oggetti aggiunti devono essere dello stesso tipo
            }
        }

        /// <summary>
        /// Create column on dataGrid and change color if weekand
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private void CreateColumn(DateTime dt, DataGridView datagrid)
        {
            // Nome della colonna => date in Number /\ Testo della colonna => num giorno
            int columnIndex = datagrid.Columns.Add(dt.ToShortDateString(), dt.Day.ToString());// dt.Day.ToString());
            if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
            {
                datagrid.Columns[columnIndex].DefaultCellStyle.BackColor = ControlPaint.Light(Color.LightGray);
            }
        }

        /// <summary>
        /// Select cell in dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetValueCell()
        {
            try
            {
                if (dataGridRoom.SelectedCells[0].ColumnIndex >= 2)
                {

                    if (dataGridRoom.SelectedCells.Count > 0)
                    {
                        //_selectedRow = dataGridRoom.SelectedCells[0].RowIndex;
                        //_selectedColumn = dataGridRoom.SelectedCells[0].ColumnIndex;

                        switch (dataGridRoom.SelectedCells.Count)
                        {
                            case 0:
                                // store no current selection
                                _selectedRow = -1;
                                _selectedColumn = -1;
                                break;
                            case 1:
                                // store starting point for multi-select
                                _selectedRow = dataGridRoom.SelectedCells[0].RowIndex;
                                _selectedColumn = dataGridRoom.SelectedCells[0].ColumnIndex;
                                break;
                        }

                        foreach (DataGridViewCell cell in dataGridRoom.SelectedCells)
                        {
                            //FOR SELECT HORIZONTAL ROW
                            if (cell.RowIndex == _selectedRow)
                            {
                                if (cell.ColumnIndex != _selectedColumn)
                                {
                                    _selectedColumn = -1;
                                }
                            }

                            //FOR SELECT VERTICAL COLUMN
                            /*
                            else if (cell.ColumnIndex == _selectedColumn)
                            {
                                if (cell.RowIndex != _selectedRow)
                                {
                                    _selectedRow = -1;
                                }
                            }
                            */

                            //otherwise the cell selection is NOT VALID
                            else cell.Selected = false;
                        }

                        int columnIndex = dataGridRoom.SelectedCells[0].ColumnIndex;
                        string columnName = dataGridRoom.Columns[columnIndex].Name;
                        startPrenotation = Convert.ToDateTime(columnName);

                        columnIndex = dataGridRoom.SelectedCells[dataGridRoom.SelectedCells.Count - 1].ColumnIndex;
                        columnName = dataGridRoom.Columns[columnIndex].Name;
                        stopPrenotation = Convert.ToDateTime(columnName);

                        if (startPrenotation > stopPrenotation)
                        {
                            DateTime tmp = new DateTime();
                            tmp = startPrenotation;
                            startPrenotation = stopPrenotation;
                            stopPrenotation = tmp;
                        }
                    }
                }
                else
                {
                    dataGridRoom.ClearSelection();
                }
            }
            catch (Exception)
            { }
        }

    }
}
