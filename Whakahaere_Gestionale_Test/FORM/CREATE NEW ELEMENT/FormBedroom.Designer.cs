namespace Whakahaere
{
    partial class FormBedroom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBedroom));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.MaskedTextBox();
            this.txtFloor = new System.Windows.Forms.MaskedTextBox();
            this.txtBeds = new System.Windows.Forms.MaskedTextBox();
            this.txtCost = new System.Windows.Forms.MaskedTextBox();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.dataGridNotes = new System.Windows.Forms.DataGridView();
            this.Dated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.toolStripButtons = new System.Windows.Forms.ToolStrip();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotes)).BeginInit();
            this.toolStripButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Floor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(234, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(278, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Notes :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Informations :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(222, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cost :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(15, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Beds :";
            // 
            // txtRoom
            // 
            this.txtRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRoom.ForeColor = System.Drawing.Color.White;
            this.txtRoom.Location = new System.Drawing.Point(309, 45);
            this.txtRoom.Mask = "000";
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(62, 26);
            this.txtRoom.TabIndex = 2;
            this.txtRoom.ValidatingType = typeof(int);
            // 
            // txtFloor
            // 
            this.txtFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFloor.ForeColor = System.Drawing.Color.White;
            this.txtFloor.Location = new System.Drawing.Point(90, 45);
            this.txtFloor.Mask = "000";
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(62, 26);
            this.txtFloor.TabIndex = 1;
            this.txtFloor.ValidatingType = typeof(int);
            // 
            // txtBeds
            // 
            this.txtBeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBeds.ForeColor = System.Drawing.Color.White;
            this.txtBeds.Location = new System.Drawing.Point(90, 97);
            this.txtBeds.Mask = "000";
            this.txtBeds.Name = "txtBeds";
            this.txtBeds.Size = new System.Drawing.Size(62, 26);
            this.txtBeds.TabIndex = 4;
            this.txtBeds.ValidatingType = typeof(int);
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCost.ForeColor = System.Drawing.Color.White;
            this.txtCost.Location = new System.Drawing.Point(297, 97);
            this.txtCost.Mask = "9999.99";
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(83, 26);
            this.txtCost.TabIndex = 5;
            this.txtCost.ValidatingType = typeof(int);
            // 
            // txtInformation
            // 
            this.txtInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInformation.ForeColor = System.Drawing.Color.White;
            this.txtInformation.Location = new System.Drawing.Point(19, 165);
            this.txtInformation.MaxLength = 255;
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(257, 296);
            this.txtInformation.TabIndex = 6;
            // 
            // dataGridNotes
            // 
            this.dataGridNotes.AllowUserToResizeColumns = false;
            this.dataGridNotes.AllowUserToResizeRows = false;
            this.dataGridNotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dated,
            this.Notes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridNotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridNotes.GridColor = System.Drawing.Color.Gray;
            this.dataGridNotes.Location = new System.Drawing.Point(282, 165);
            this.dataGridNotes.Name = "dataGridNotes";
            this.dataGridNotes.RowHeadersVisible = false;
            this.dataGridNotes.RowHeadersWidth = 51;
            this.dataGridNotes.RowTemplate.Height = 24;
            this.dataGridNotes.Size = new System.Drawing.Size(506, 296);
            this.dataGridNotes.TabIndex = 7;
            // 
            // Dated
            // 
            this.Dated.HeaderText = "Dated";
            this.Dated.MinimumWidth = 6;
            this.Dated.Name = "Dated";
            this.Dated.Width = 125;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            this.Notes.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(422, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Status :";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(497, 45);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(290, 28);
            this.cbStatus.TabIndex = 3;
            // 
            // toolStripButtons
            // 
            this.toolStripButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toolStripButtons.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSave});
            this.toolStripButtons.Location = new System.Drawing.Point(0, 0);
            this.toolStripButtons.Name = "toolStripButtons";
            this.toolStripButtons.Size = new System.Drawing.Size(800, 27);
            this.toolStripButtons.TabIndex = 9;
            this.toolStripButtons.Text = "toolStrip1";
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(29, 24);
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // Bedroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.toolStripButtons);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridNotes);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtBeds);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Bedroom";
            this.Text = "BEDROOM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotes)).EndInit();
            this.toolStripButtons.ResumeLayout(false);
            this.toolStripButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtRoom;
        private System.Windows.Forms.MaskedTextBox txtFloor;
        private System.Windows.Forms.MaskedTextBox txtBeds;
        private System.Windows.Forms.MaskedTextBox txtCost;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.DataGridView dataGridNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ToolStrip toolStripButtons;
        private System.Windows.Forms.ToolStripButton btSave;
    }
}