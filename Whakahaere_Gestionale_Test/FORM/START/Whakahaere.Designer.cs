namespace Whakahaere
{
    partial class Whakahaere
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Whakahaere));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolStripButtons = new System.Windows.Forms.ToolStrip();
            this.btPrenotations = new System.Windows.Forms.ToolStripDropDownButton();
            this.newPrenotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPrenotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPrenotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btBedrooms = new System.Windows.Forms.ToolStripDropDownButton();
            this.createBedroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBedroomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btPayment = new System.Windows.Forms.ToolStripDropDownButton();
            this.payPrenotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.btSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.btInformations = new System.Windows.Forms.ToolStripDropDownButton();
            this.showTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatus = new System.Windows.Forms.ToolStrip();
            this.lblTime = new System.Windows.Forms.ToolStripLabel();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridRoom = new System.Windows.Forms.DataGridView();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.toolStripButtons.SuspendLayout();
            this.toolStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).BeginInit();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(-4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(-4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(104, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(104, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 26);
            this.textBox2.TabIndex = 3;
            // 
            // toolStripButtons
            // 
            this.toolStripButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toolStripButtons.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btPrenotations,
            this.btBedrooms,
            this.btPayment,
            this.Separator_1,
            this.btSettings,
            this.btInformations});
            this.toolStripButtons.Location = new System.Drawing.Point(0, 0);
            this.toolStripButtons.Name = "toolStripButtons";
            this.toolStripButtons.Size = new System.Drawing.Size(1250, 37);
            this.toolStripButtons.TabIndex = 4;
            this.toolStripButtons.Text = "toolStrip1";
            // 
            // btPrenotations
            // 
            this.btPrenotations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPrenotations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPrenotationToolStripMenuItem,
            this.showPrenotationToolStripMenuItem,
            this.modifyPrenotationToolStripMenuItem});
            this.btPrenotations.Image = ((System.Drawing.Image)(resources.GetObject("btPrenotations.Image")));
            this.btPrenotations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPrenotations.Name = "btPrenotations";
            this.btPrenotations.Size = new System.Drawing.Size(44, 34);
            this.btPrenotations.Text = "Prenotations";
            // 
            // newPrenotationToolStripMenuItem
            // 
            this.newPrenotationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.newPrenotationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newPrenotationToolStripMenuItem.Name = "newPrenotationToolStripMenuItem";
            this.newPrenotationToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.newPrenotationToolStripMenuItem.Text = "New prenotation";
            // 
            // showPrenotationToolStripMenuItem
            // 
            this.showPrenotationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.showPrenotationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showPrenotationToolStripMenuItem.Name = "showPrenotationToolStripMenuItem";
            this.showPrenotationToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.showPrenotationToolStripMenuItem.Text = "Show prenotation";
            // 
            // modifyPrenotationToolStripMenuItem
            // 
            this.modifyPrenotationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.modifyPrenotationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modifyPrenotationToolStripMenuItem.Name = "modifyPrenotationToolStripMenuItem";
            this.modifyPrenotationToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.modifyPrenotationToolStripMenuItem.Text = "Modify prenotation";
            // 
            // btBedrooms
            // 
            this.btBedrooms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btBedrooms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBedroomToolStripMenuItem,
            this.modifyBedroomsToolStripMenuItem});
            this.btBedrooms.Image = ((System.Drawing.Image)(resources.GetObject("btBedrooms.Image")));
            this.btBedrooms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBedrooms.Name = "btBedrooms";
            this.btBedrooms.Size = new System.Drawing.Size(44, 34);
            this.btBedrooms.Text = "Bedrooms";
            // 
            // createBedroomToolStripMenuItem
            // 
            this.createBedroomToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.createBedroomToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.createBedroomToolStripMenuItem.Name = "createBedroomToolStripMenuItem";
            this.createBedroomToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.createBedroomToolStripMenuItem.Text = "Create bedroom";
            // 
            // modifyBedroomsToolStripMenuItem
            // 
            this.modifyBedroomsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.modifyBedroomsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modifyBedroomsToolStripMenuItem.Name = "modifyBedroomsToolStripMenuItem";
            this.modifyBedroomsToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.modifyBedroomsToolStripMenuItem.Text = "Modify bedrooms";
            // 
            // btPayment
            // 
            this.btPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPayment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payPrenotationToolStripMenuItem,
            this.invoiceToolStripMenuItem});
            this.btPayment.Image = ((System.Drawing.Image)(resources.GetObject("btPayment.Image")));
            this.btPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPayment.Name = "btPayment";
            this.btPayment.Size = new System.Drawing.Size(44, 34);
            this.btPayment.Text = "Payment";
            // 
            // payPrenotationToolStripMenuItem
            // 
            this.payPrenotationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.payPrenotationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.payPrenotationToolStripMenuItem.Name = "payPrenotationToolStripMenuItem";
            this.payPrenotationToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.payPrenotationToolStripMenuItem.Text = "Payment";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.invoiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // Separator_1
            // 
            this.Separator_1.Name = "Separator_1";
            this.Separator_1.Size = new System.Drawing.Size(6, 37);
            // 
            // btSettings
            // 
            this.btSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSettings.Image = ((System.Drawing.Image)(resources.GetObject("btSettings.Image")));
            this.btSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(44, 34);
            this.btSettings.Text = "Settings";
            // 
            // btInformations
            // 
            this.btInformations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btInformations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTutorialToolStripMenuItem});
            this.btInformations.Image = ((System.Drawing.Image)(resources.GetObject("btInformations.Image")));
            this.btInformations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btInformations.Name = "btInformations";
            this.btInformations.Size = new System.Drawing.Size(44, 34);
            this.btInformations.Text = "Informations";
            // 
            // showTutorialToolStripMenuItem
            // 
            this.showTutorialToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.showTutorialToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showTutorialToolStripMenuItem.Name = "showTutorialToolStripMenuItem";
            this.showTutorialToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.showTutorialToolStripMenuItem.Text = "Show tutorial";
            this.showTutorialToolStripMenuItem.Click += new System.EventHandler(this.showTutorialToolStripMenuItem_Click);
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toolStripStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripStatus.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime});
            this.toolStripStatus.Location = new System.Drawing.Point(0, 696);
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatus.Size = new System.Drawing.Size(1250, 26);
            this.toolStripStatus.TabIndex = 5;
            this.toolStripStatus.Text = "toolStrip1";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(145, 23);
            this.lblTime.Text = "__/__/____   __:__:__";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // dataGridRoom
            // 
            this.dataGridRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridRoom.ColumnHeadersHeight = 25;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRoom.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRoom.Location = new System.Drawing.Point(0, 137);
            this.dataGridRoom.Name = "dataGridRoom";
            this.dataGridRoom.RowHeadersWidth = 50;
            this.dataGridRoom.RowTemplate.Height = 24;
            this.dataGridRoom.Size = new System.Drawing.Size(1250, 559);
            this.dataGridRoom.TabIndex = 6;
            this.dataGridRoom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoom_CellDoubleClick);
            this.dataGridRoom.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridRoom_CellMouseClick);
            this.dataGridRoom.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridRoom_CellPainting);
            this.dataGridRoom.SelectionChanged += new System.EventHandler(this.dataGridRoom_SelectionChanged);
            this.dataGridRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridRoom_Paint);
            // 
            // panelLogIn
            // 
            this.panelLogIn.Controls.Add(this.label3);
            this.panelLogIn.Controls.Add(this.cbYear);
            this.panelLogIn.Controls.Add(this.label1);
            this.panelLogIn.Controls.Add(this.label2);
            this.panelLogIn.Controls.Add(this.textBox1);
            this.panelLogIn.Controls.Add(this.textBox2);
            this.panelLogIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogIn.Location = new System.Drawing.Point(0, 37);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(1250, 100);
            this.panelLogIn.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(385, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year :";
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.cbYear.DropDownHeight = 100;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbYear.ForeColor = System.Drawing.Color.White;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.IntegralHeight = false;
            this.cbYear.Location = new System.Drawing.Point(450, 21);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(159, 28);
            this.cbYear.TabIndex = 4;
            // 
            // Whakahaere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1250, 722);
            this.Controls.Add(this.dataGridRoom);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.toolStripStatus);
            this.Controls.Add(this.toolStripButtons);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Whakahaere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wakahaere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Whakahaere_FormClosing);
            this.toolStripButtons.ResumeLayout(false);
            this.toolStripButtons.PerformLayout();
            this.toolStripStatus.ResumeLayout(false);
            this.toolStripStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).EndInit();
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStrip toolStripButtons;
        private System.Windows.Forms.ToolStrip toolStripStatus;
        private System.Windows.Forms.ToolStripLabel lblTime;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.ToolStripDropDownButton btPrenotations;
        private System.Windows.Forms.ToolStripDropDownButton btBedrooms;
        private System.Windows.Forms.ToolStripDropDownButton btSettings;
        private System.Windows.Forms.ToolStripDropDownButton btInformations;
        private System.Windows.Forms.ToolStripMenuItem newPrenotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPrenotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPrenotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBedroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyBedroomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btPayment;
        private System.Windows.Forms.ToolStripMenuItem payPrenotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator_1;
        private System.Windows.Forms.DataGridView dataGridRoom;
        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbYear;
    }
}

