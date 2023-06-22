namespace AirTicket
{
    partial class AddTicketForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.incorrectText = new System.Windows.Forms.Label();
            this.addRaceButton = new System.Windows.Forms.Button();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.passportTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fatherNameTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.incorrectText);
            this.panel1.Controls.Add(this.addRaceButton);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(141, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 488);
            this.panel1.TabIndex = 1;
            // 
            // incorrectText
            // 
            this.incorrectText.AutoSize = true;
            this.incorrectText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incorrectText.ForeColor = System.Drawing.Color.Red;
            this.incorrectText.Location = new System.Drawing.Point(153, 392);
            this.incorrectText.Name = "incorrectText";
            this.incorrectText.Size = new System.Drawing.Size(201, 20);
            this.incorrectText.TabIndex = 24;
            this.incorrectText.Text = "Некорректные данные";
            this.incorrectText.Visible = false;
            // 
            // addRaceButton
            // 
            this.addRaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(116)))), ((int)(((byte)(164)))));
            this.addRaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRaceButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRaceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.addRaceButton.Location = new System.Drawing.Point(116, 426);
            this.addRaceButton.Name = "addRaceButton";
            this.addRaceButton.Size = new System.Drawing.Size(280, 50);
            this.addRaceButton.TabIndex = 14;
            this.addRaceButton.Text = "Добавить";
            this.addRaceButton.UseVisualStyleBackColor = false;
            this.addRaceButton.Click += new System.EventHandler(this.addRaceButton_Click);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.surnameTextBox.Location = new System.Drawing.Point(24, 41);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(191, 34);
            this.surnameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTextBox.Location = new System.Drawing.Point(24, 125);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(191, 34);
            this.nameTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Имя";
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherNameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fatherNameTextBox.Location = new System.Drawing.Point(24, 211);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(191, 34);
            this.fatherNameTextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(19, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Отчество";
            // 
            // passportTextBox
            // 
            this.passportTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passportTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passportTextBox.Location = new System.Drawing.Point(24, 299);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(191, 34);
            this.passportTextBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(19, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Номер паспорта";
            // 
            // AddTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.panel1);
            this.Name = "AddTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTicketForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTicketForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label incorrectText;
        private System.Windows.Forms.Button addRaceButton;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label1;
    }
}