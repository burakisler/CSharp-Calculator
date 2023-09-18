namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            label1 = new Label();
            MTBOX = new MaskedTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(4, 250);
            button1.Name = "button1";
            button1.Size = new Size(106, 50);
            button1.TabIndex = 4;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BT_CL;
            // 
            // button2
            // 
            button2.Location = new Point(116, 250);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 5;
            button2.Text = ",";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BT_CL;
            // 
            // button3
            // 
            button3.Location = new Point(172, 250);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 6;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OP_CL;
            // 
            // button4
            // 
            button4.Location = new Point(4, 194);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 7;
            button4.Text = "1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += BT_CL;
            // 
            // button5
            // 
            button5.Location = new Point(60, 194);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 8;
            button5.Text = "2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += BT_CL;
            // 
            // button6
            // 
            button6.Location = new Point(116, 194);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 9;
            button6.Text = "3";
            button6.UseVisualStyleBackColor = true;
            button6.Click += BT_CL;
            // 
            // button7
            // 
            button7.Location = new Point(172, 194);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 10;
            button7.Text = "*";
            button7.UseVisualStyleBackColor = true;
            button7.Click += OP_CL;
            // 
            // button8
            // 
            button8.Location = new Point(172, 138);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 14;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            button8.Click += OP_CL;
            // 
            // button9
            // 
            button9.Location = new Point(116, 138);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 13;
            button9.Text = "6";
            button9.UseVisualStyleBackColor = true;
            button9.Click += BT_CL;
            // 
            // button10
            // 
            button10.Location = new Point(60, 138);
            button10.Name = "button10";
            button10.Size = new Size(50, 50);
            button10.TabIndex = 12;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = true;
            button10.Click += BT_CL;
            // 
            // button11
            // 
            button11.Location = new Point(4, 138);
            button11.Name = "button11";
            button11.Size = new Size(50, 50);
            button11.TabIndex = 11;
            button11.Text = "4";
            button11.UseVisualStyleBackColor = true;
            button11.Click += BT_CL;
            // 
            // button12
            // 
            button12.Location = new Point(172, 82);
            button12.Name = "button12";
            button12.Size = new Size(50, 50);
            button12.TabIndex = 18;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = true;
            button12.Click += OP_CL;
            // 
            // button13
            // 
            button13.Location = new Point(116, 82);
            button13.Name = "button13";
            button13.Size = new Size(50, 50);
            button13.TabIndex = 17;
            button13.Text = "9";
            button13.UseVisualStyleBackColor = true;
            button13.Click += BT_CL;
            // 
            // button14
            // 
            button14.Location = new Point(60, 82);
            button14.Name = "button14";
            button14.Size = new Size(50, 50);
            button14.TabIndex = 16;
            button14.Text = "8";
            button14.UseVisualStyleBackColor = true;
            button14.Click += BT_CL;
            // 
            // button15
            // 
            button15.Location = new Point(4, 82);
            button15.Name = "button15";
            button15.Size = new Size(50, 50);
            button15.TabIndex = 15;
            button15.Text = "7";
            button15.UseVisualStyleBackColor = true;
            button15.Click += BT_CL;
            // 
            // button16
            // 
            button16.Location = new Point(228, 82);
            button16.Name = "button16";
            button16.Size = new Size(50, 50);
            button16.TabIndex = 19;
            button16.Text = "CE";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Location = new Point(228, 138);
            button17.Name = "button17";
            button17.Size = new Size(50, 50);
            button17.TabIndex = 20;
            button17.Text = "C";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Location = new Point(228, 194);
            button18.Name = "button18";
            button18.Size = new Size(50, 106);
            button18.TabIndex = 21;
            button18.Text = "=";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(209, 15);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 22;
            label1.Click += label1_Click;
            // 
            // MTBOX
            // 
            MTBOX.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MTBOX.Location = new Point(4, 43);
            MTBOX.Name = "MTBOX";
            MTBOX.Size = new Size(274, 33);
            MTBOX.TabIndex = 24;
            MTBOX.Text = "0";
            MTBOX.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 305);
            Controls.Add(MTBOX);
            Controls.Add(label1);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hesap Makinesi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Label label1;
        private MaskedTextBox MTBOX;
    }
}