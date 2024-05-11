namespace CinemaTicketSystem
{
    partial class ReservationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            numericUpDownTickets = new NumericUpDown();
            label6 = new Label();
            button1 = new Button();
            lblFilmTitle = new Label();
            lblScreeningTime = new Label();
            lblAvailableSeats = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTickets).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(146, 39);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(241, 39);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 1;
            label2.Text = "Screening Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(386, 39);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 2;
            label3.Text = "Available Seats";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 283);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(146, 177);
            label4.Name = "label4";
            label4.Size = new Size(200, 30);
            label4.TabIndex = 4;
            label4.Text = "Reservation Details:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(157, 250);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 5;
            label5.Text = "Name:";
            // 
            // numericUpDownTickets
            // 
            numericUpDownTickets.Location = new Point(324, 283);
            numericUpDownTickets.Name = "numericUpDownTickets";
            numericUpDownTickets.Size = new Size(120, 23);
            numericUpDownTickets.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(333, 250);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 7;
            label6.Text = "Ticket Amount:";
            // 
            // button1
            // 
            button1.Location = new Point(506, 287);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Reserve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnReserve_Click;
            // 
            // lblFilmTitle
            // 
            lblFilmTitle.AutoSize = true;
            lblFilmTitle.Location = new Point(157, 82);
            lblFilmTitle.Name = "lblFilmTitle";
            lblFilmTitle.Size = new Size(29, 15);
            lblFilmTitle.TabIndex = 9;
            lblFilmTitle.Text = "Title";
            // 
            // lblScreeningTime
            // 
            lblScreeningTime.AutoSize = true;
            lblScreeningTime.Location = new Point(270, 82);
            lblScreeningTime.Name = "lblScreeningTime";
            lblScreeningTime.Size = new Size(29, 15);
            lblScreeningTime.TabIndex = 10;
            lblScreeningTime.Text = "Title";
            // 
            // lblAvailableSeats
            // 
            lblAvailableSeats.AutoSize = true;
            lblAvailableSeats.Location = new Point(415, 82);
            lblAvailableSeats.Name = "lblAvailableSeats";
            lblAvailableSeats.Size = new Size(29, 15);
            lblAvailableSeats.TabIndex = 11;
            lblAvailableSeats.Text = "Title";
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAvailableSeats);
            Controls.Add(lblScreeningTime);
            Controls.Add(lblFilmTitle);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(numericUpDownTickets);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReservationForm";
            Text = "ReservationForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownTickets;
        private Label label6;
        private Button button1;
        private Label lblFilmTitle;
        private Label lblScreeningTime;
        private Label lblAvailableSeats;
    }
}