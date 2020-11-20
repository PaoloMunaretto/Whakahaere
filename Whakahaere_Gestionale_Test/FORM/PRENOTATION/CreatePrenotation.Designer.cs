namespace Whakahaere
{
    partial class CreatePrenotation
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
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateStop = new System.Windows.Forms.DateTimePicker();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateStart.Location = new System.Drawing.Point(127, 17);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(353, 26);
            this.dateStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stop :";
            // 
            // dateStop
            // 
            this.dateStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateStop.Location = new System.Drawing.Point(127, 65);
            this.dateStop.Name = "dateStop";
            this.dateStop.Size = new System.Drawing.Size(353, 26);
            this.dateStop.TabIndex = 3;
            // 
            // cbClient
            // 
            this.cbClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.cbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbClient.ForeColor = System.Drawing.Color.White;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(127, 121);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(353, 28);
            this.cbClient.TabIndex = 5;
            // 
            // txtClient
            // 
            this.txtClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtClient.ForeColor = System.Drawing.Color.White;
            this.txtClient.Location = new System.Drawing.Point(127, 169);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(353, 26);
            this.txtClient.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Client :";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(25, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 61);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(353, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 61);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CreatePrenotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(503, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CreatePrenotation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New prenotation :";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateStop;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}