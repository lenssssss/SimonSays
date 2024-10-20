namespace SimonSays
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pb_Red = new PictureBox();
            pb_Yellow = new PictureBox();
            pb_Blue = new PictureBox();
            pb_Green = new PictureBox();
            lb_score = new Label();
            lb_highscore = new Label();
            btn_start = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Yellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Blue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Green).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pb_Red, 0, 0);
            tableLayoutPanel1.Controls.Add(pb_Yellow, 1, 0);
            tableLayoutPanel1.Controls.Add(pb_Blue, 0, 1);
            tableLayoutPanel1.Controls.Add(pb_Green, 1, 1);
            tableLayoutPanel1.Location = new Point(38, 84);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(302, 279);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pb_Red
            // 
            pb_Red.Dock = DockStyle.Fill;
            pb_Red.Image = Properties.Resources.R1;
            pb_Red.Location = new Point(3, 3);
            pb_Red.Name = "pb_Red";
            pb_Red.Size = new Size(145, 133);
            pb_Red.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Red.TabIndex = 0;
            pb_Red.TabStop = false;
            pb_Red.Click += pb_Click;
            pb_Red.MouseDown += pb_Red_MouseDown;
            pb_Red.MouseUp += pb_Red_MouseUp;
            // 
            // pb_Yellow
            // 
            pb_Yellow.Dock = DockStyle.Fill;
            pb_Yellow.Image = Properties.Resources.Y1;
            pb_Yellow.Location = new Point(154, 3);
            pb_Yellow.Name = "pb_Yellow";
            pb_Yellow.Size = new Size(145, 133);
            pb_Yellow.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Yellow.TabIndex = 1;
            pb_Yellow.TabStop = false;
            pb_Yellow.Click += pb_Click;
            pb_Yellow.MouseDown += pb_Yellow_MouseDown;
            pb_Yellow.MouseUp += pb_Yellow_MouseUp;
            // 
            // pb_Blue
            // 
            pb_Blue.Dock = DockStyle.Fill;
            pb_Blue.Image = Properties.Resources.B1;
            pb_Blue.Location = new Point(3, 142);
            pb_Blue.Name = "pb_Blue";
            pb_Blue.Size = new Size(145, 134);
            pb_Blue.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Blue.TabIndex = 2;
            pb_Blue.TabStop = false;
            pb_Blue.Click += pb_Click;
            pb_Blue.MouseDown += pb_Blue_MouseDown;
            pb_Blue.MouseUp += pb_Blue_MouseUp;
            // 
            // pb_Green
            // 
            pb_Green.Dock = DockStyle.Fill;
            pb_Green.Image = Properties.Resources.G1;
            pb_Green.Location = new Point(154, 142);
            pb_Green.Name = "pb_Green";
            pb_Green.Size = new Size(145, 134);
            pb_Green.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Green.TabIndex = 3;
            pb_Green.TabStop = false;
            pb_Green.Click += pb_Click;
            pb_Green.MouseDown += pb_Green_MouseDown;
            pb_Green.MouseUp += pb_Green_MouseUp;
            // 
            // lb_score
            // 
            lb_score.AutoSize = true;
            lb_score.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_score.Location = new Point(130, 26);
            lb_score.Name = "lb_score";
            lb_score.Size = new Size(107, 38);
            lb_score.TabIndex = 1;
            lb_score.Text = "Score:0";
            // 
            // lb_highscore
            // 
            lb_highscore.AutoSize = true;
            lb_highscore.Location = new Point(457, 40);
            lb_highscore.Name = "lb_highscore";
            lb_highscore.Size = new Size(85, 20);
            lb_highscore.TabIndex = 2;
            lb_highscore.Text = "High Score:";
            // 
            // btn_start
            // 
            btn_start.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_start.Location = new Point(103, 378);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(173, 72);
            btn_start.TabIndex = 0;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(603, 514);
            Controls.Add(btn_start);
            Controls.Add(lb_highscore);
            Controls.Add(lb_score);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_Red).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Yellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Blue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Green).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pb_Red;
        private PictureBox pb_Yellow;
        private PictureBox pb_Blue;
        private PictureBox pb_Green;
        private Label lb_score;
        private Label lb_highscore;
        private Button btn_start;
    }
}
