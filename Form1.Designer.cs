namespace WinFormsApp12
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
            Exit = new Button();
            DisplayAppointment = new Button();
            SearchAppointment = new Button();
            CreateAppointment = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.None;
            Exit.BackColor = Color.Ivory;
            Exit.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.Location = new Point(370, 318);
            Exit.Name = "Exit";
            Exit.Size = new Size(112, 34);
            Exit.TabIndex = 3;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += button4_Click;
            // 
            // DisplayAppointment
            // 
            DisplayAppointment.Anchor = AnchorStyles.None;
            DisplayAppointment.BackColor = Color.Ivory;
            DisplayAppointment.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayAppointment.Location = new Point(298, 278);
            DisplayAppointment.Name = "DisplayAppointment";
            DisplayAppointment.Size = new Size(264, 34);
            DisplayAppointment.TabIndex = 1;
            DisplayAppointment.Text = "Display Appointment Dates";
            DisplayAppointment.UseVisualStyleBackColor = false;
            DisplayAppointment.Click += button2_Click;
            // 
            // SearchAppointment
            // 
            SearchAppointment.Anchor = AnchorStyles.None;
            SearchAppointment.BackColor = Color.Ivory;
            SearchAppointment.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchAppointment.Location = new Point(319, 238);
            SearchAppointment.Name = "SearchAppointment";
            SearchAppointment.Size = new Size(221, 34);
            SearchAppointment.TabIndex = 2;
            SearchAppointment.Text = "Search Appointment";
            SearchAppointment.UseVisualStyleBackColor = false;
            SearchAppointment.Click += SearchAppointment_Click;
            // 
            // CreateAppointment
            // 
            CreateAppointment.Anchor = AnchorStyles.None;
            CreateAppointment.BackColor = Color.Ivory;
            CreateAppointment.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreateAppointment.ForeColor = Color.Black;
            CreateAppointment.Location = new Point(319, 198);
            CreateAppointment.Name = "CreateAppointment";
            CreateAppointment.Size = new Size(221, 34);
            CreateAppointment.TabIndex = 0;
            CreateAppointment.Text = "Create Appointment";
            CreateAppointment.UseVisualStyleBackColor = false;
            CreateAppointment.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.OldLace;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(298, 93);
            label1.Name = "label1";
            label1.Size = new Size(367, 84);
            label1.TabIndex = 4;
            label1.Text = "VETMED";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.sa;
            pictureBox1.Location = new Point(103, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.dog_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Exit);
            Controls.Add(SearchAppointment);
            Controls.Add(DisplayAppointment);
            Controls.Add(CreateAppointment);
            Name = "Form1";
            Text = "VETMED";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit;
        private Button DisplayAppointment;
        private Button SearchAppointment;
        private Button CreateAppointment;
        private Label label1;
        private PictureBox pictureBox1;
    }
}