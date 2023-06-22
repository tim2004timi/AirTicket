namespace AirTicket
{
    partial class CencelTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CencelTicketForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ticketsListBox = new System.Windows.Forms.ListBox();
            this.cancelTicketButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.ticketsListBox);
            this.panel1.Controls.Add(this.cancelTicketButton);
            this.panel1.Location = new System.Drawing.Point(141, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 488);
            this.panel1.TabIndex = 1;
            // 
            // ticketsListBox
            // 
            this.ticketsListBox.FormattingEnabled = true;
            this.ticketsListBox.ItemHeight = 16;
            this.ticketsListBox.Location = new System.Drawing.Point(50, 50);
            this.ticketsListBox.Name = "ticketsListBox";
            this.ticketsListBox.Size = new System.Drawing.Size(400, 324);
            this.ticketsListBox.TabIndex = 15;
            // 
            // cancelTicketButton
            // 
            this.cancelTicketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(116)))), ((int)(((byte)(164)))));
            this.cancelTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelTicketButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelTicketButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.cancelTicketButton.Location = new System.Drawing.Point(116, 426);
            this.cancelTicketButton.Name = "cancelTicketButton";
            this.cancelTicketButton.Size = new System.Drawing.Size(280, 50);
            this.cancelTicketButton.TabIndex = 14;
            this.cancelTicketButton.Text = "Отменить заявку";
            this.cancelTicketButton.UseVisualStyleBackColor = false;
            this.cancelTicketButton.Click += new System.EventHandler(this.CancelTicketButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CencelTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "CencelTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CencelTicketForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CencelTicketForm_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ticketsListBox;
        private System.Windows.Forms.Button cancelTicketButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}