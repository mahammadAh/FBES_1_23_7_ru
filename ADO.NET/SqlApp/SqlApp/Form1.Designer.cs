namespace SqlApp
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
            queryTextBox = new TextBox();
            ExecuteButton = new Button();
            resultDataGridView = new DataGridView();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // queryTextBox
            // 
            queryTextBox.Location = new Point(12, 12);
            queryTextBox.Name = "queryTextBox";
            queryTextBox.Size = new Size(776, 23);
            queryTextBox.TabIndex = 0;
            // 
            // ExecuteButton
            // 
            ExecuteButton.BackColor = Color.FromArgb(0, 192, 0);
            ExecuteButton.Location = new Point(12, 41);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(378, 23);
            ExecuteButton.TabIndex = 1;
            ExecuteButton.Text = "Fill";
            ExecuteButton.UseVisualStyleBackColor = false;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // resultDataGridView
            // 
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Location = new Point(12, 70);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.Size = new Size(776, 358);
            resultDataGridView.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(396, 41);
            button1.Name = "button1";
            button1.Size = new Size(392, 23);
            button1.TabIndex = 3;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 434);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 302);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 748);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(resultDataGridView);
            Controls.Add(ExecuteButton);
            Controls.Add(queryTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox queryTextBox;
        private Button ExecuteButton;
        private DataGridView resultDataGridView;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}
