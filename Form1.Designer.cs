namespace plane.homework12
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 611);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 360);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.Location = new Point(402, 12);
            button1.Name = "button1";
            button1.Size = new Size(462, 65);
            button1.TabIndex = 1;
            button1.Text = "Eniş hazırlığı";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.Location = new Point(402, 94);
            button2.Name = "button2";
            button2.Size = new Size(462, 65);
            button2.TabIndex = 2;
            button2.Text = "Turbulans";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button3.Location = new Point(402, 180);
            button3.Name = "button3";
            button3.Size = new Size(462, 65);
            button3.TabIndex = 3;
            button3.Text = "Kəmərlər";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button4.Location = new Point(402, 262);
            button4.Name = "button4";
            button4.Size = new Size(462, 65);
            button4.TabIndex = 4;
            button4.Text = "Təşəkkürlər";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button5.Location = new Point(402, 343);
            button5.Name = "button5";
            button5.Size = new Size(462, 65);
            button5.TabIndex = 5;
            button5.Text = "Beep";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button6.Location = new Point(419, 438);
            button6.Name = "button6";
            button6.Size = new Size(183, 65);
            button6.TabIndex = 6;
            button6.Text = "Gas";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button7.Location = new Point(651, 438);
            button7.Name = "button7";
            button7.Size = new Size(183, 65);
            button7.TabIndex = 7;
            button7.Text = "Break";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Blue;
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button8.Location = new Point(402, 549);
            button8.Name = "button8";
            button8.Size = new Size(462, 65);
            button8.TabIndex = 8;
            button8.Text = "ON/OFF";
            button8.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(876, 614);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Plane";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
