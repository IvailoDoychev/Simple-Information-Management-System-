namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgScreenings = new DataGridView();
            cmbGenre = new ComboBox();
            cmbCinemaHall = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            dtpScreeningTime = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgScreenings).BeginInit();
            SuspendLayout();
            // 
            // dgScreenings
            // 
            dgScreenings.BackgroundColor = SystemColors.ActiveCaption;
            dgScreenings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgScreenings.GridColor = SystemColors.ActiveCaptionText;
            dgScreenings.Location = new Point(77, 129);
            dgScreenings.Name = "dgScreenings";
            dgScreenings.RowTemplate.Height = 25;
            dgScreenings.Size = new Size(690, 309);
            dgScreenings.TabIndex = 0;
            dgScreenings.CellContentClick += dgScreenings_CellContentClick;
            // 
            // cmbGenre
            // 
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(168, 89);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(114, 23);
            cmbGenre.TabIndex = 1;
            cmbGenre.SelectedIndexChanged += cmbGenre_SelectedIndexChanged;
            // 
            // cmbCinemaHall
            // 
            cmbCinemaHall.FormattingEnabled = true;
            cmbCinemaHall.Location = new Point(483, 89);
            cmbCinemaHall.Name = "cmbCinemaHall";
            cmbCinemaHall.Size = new Size(114, 23);
            cmbCinemaHall.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 71);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 71);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 5;
            label2.Text = "Screening Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 71);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "Cinema Hall";
            // 
            // button1
            // 
            button1.Location = new Point(653, 88);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "FILTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnFilter_Click;
            // 
            // dtpScreeningTime
            // 
            dtpScreeningTime.Location = new Point(345, 89);
            dtpScreeningTime.Name = "dtpScreeningTime";
            dtpScreeningTime.Size = new Size(88, 23);
            dtpScreeningTime.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpScreeningTime);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCinemaHall);
            Controls.Add(cmbGenre);
            Controls.Add(dgScreenings);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgScreenings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgScreenings;
        private ComboBox cmbGenre;
        private ComboBox cmbCinemaHall;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private DateTimePicker dtpScreeningTime;
    }
}