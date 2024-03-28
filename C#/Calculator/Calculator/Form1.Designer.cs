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
            buttonMinus = new Button();
            buttonPlus = new Button();
            buttonUmnj = new Button();
            buttonDel = new Button();
            buttonRavno = new Button();
            labelRuslt = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 290);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumberButtonClick;
            // 
            // button2
            // 
            button2.Location = new Point(93, 290);
            button2.Name = "button2";
            button2.Size = new Size(75, 33);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberButtonClick;
            // 
            // button3
            // 
            button3.Location = new Point(174, 290);
            button3.Name = "button3";
            button3.Size = new Size(75, 33);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButtonClick;
            // 
            // button4
            // 
            button4.Location = new Point(12, 329);
            button4.Name = "button4";
            button4.Size = new Size(75, 34);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberButtonClick;
            // 
            // button5
            // 
            button5.Location = new Point(93, 329);
            button5.Name = "button5";
            button5.Size = new Size(75, 34);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberButtonClick;
            // 
            // button6
            // 
            button6.Location = new Point(174, 329);
            button6.Name = "button6";
            button6.Size = new Size(75, 34);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButtonClick;
            // 
            // button7
            // 
            button7.Location = new Point(12, 369);
            button7.Name = "button7";
            button7.Size = new Size(75, 31);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberButtonClick;
            // 
            // button8
            // 
            button8.Location = new Point(93, 369);
            button8.Name = "button8";
            button8.Size = new Size(75, 31);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberButtonClick;
            // 
            // button9
            // 
            button9.Location = new Point(174, 369);
            button9.Name = "button9";
            button9.Size = new Size(75, 31);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberButtonClick;
            // 
            // button10
            // 
            button10.Location = new Point(12, 406);
            button10.Name = "button10";
            button10.Size = new Size(75, 35);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumberButtonClick;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(255, 290);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(49, 33);
            buttonMinus.TabIndex = 10;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(255, 329);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(49, 34);
            buttonPlus.TabIndex = 11;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonUmnj
            // 
            buttonUmnj.Location = new Point(255, 369);
            buttonUmnj.Name = "buttonUmnj";
            buttonUmnj.Size = new Size(49, 31);
            buttonUmnj.TabIndex = 12;
            buttonUmnj.Text = "*";
            buttonUmnj.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(310, 290);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(55, 33);
            buttonDel.TabIndex = 13;
            buttonDel.Text = "\\";
            buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonRavno
            // 
            buttonRavno.Location = new Point(310, 329);
            buttonRavno.Name = "buttonRavno";
            buttonRavno.Size = new Size(55, 71);
            buttonRavno.TabIndex = 14;
            buttonRavno.Text = "=";
            buttonRavno.UseVisualStyleBackColor = true;
            buttonRavno.Click += buttonRavno_Click;
            // 
            // labelRuslt
            // 
            labelRuslt.Location = new Point(12, 222);
            labelRuslt.Name = "labelRuslt";
            labelRuslt.Size = new Size(353, 65);
            labelRuslt.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 491);
            Controls.Add(labelRuslt);
            Controls.Add(buttonRavno);
            Controls.Add(buttonDel);
            Controls.Add(buttonUmnj);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMinus);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
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
        private Button buttonMinus;
        private Button buttonPlus;
        private Button buttonUmnj;
        private Button buttonDel;
        private Button buttonRavno;
        private Label labelRuslt;
    }
}