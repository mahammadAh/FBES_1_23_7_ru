namespace AsyncApp2
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
            Button sqlServerButton;
            dataGridView = new DataGridView();
            messageTextBox = new TextBox();
            runButton = new Button();
            postgreSqlButton = new Button();
            errorRichTextBox = new RichTextBox();
            sqlServerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // sqlServerButton
            // 
            sqlServerButton.Location = new Point(12, 12);
            sqlServerButton.Name = "sqlServerButton";
            sqlServerButton.Size = new Size(209, 40);
            sqlServerButton.TabIndex = 4;
            sqlServerButton.Text = "Sql Server";
            sqlServerButton.UseVisualStyleBackColor = true;
            sqlServerButton.Click += sqlServerButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 58);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(455, 278);
            dataGridView.TabIndex = 0;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(12, 354);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(455, 23);
            messageTextBox.TabIndex = 1;
            // 
            // runButton
            // 
            runButton.Location = new Point(151, 394);
            runButton.Name = "runButton";
            runButton.Size = new Size(170, 44);
            runButton.TabIndex = 2;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // postgreSqlButton
            // 
            postgreSqlButton.Location = new Point(255, 12);
            postgreSqlButton.Name = "postgreSqlButton";
            postgreSqlButton.Size = new Size(209, 40);
            postgreSqlButton.TabIndex = 3;
            postgreSqlButton.Text = "Postgre Sql";
            postgreSqlButton.UseVisualStyleBackColor = true;
            postgreSqlButton.Click += postgreSqlButton_Click;
            // 
            // errorRichTextBox
            // 
            errorRichTextBox.Location = new Point(473, 12);
            errorRichTextBox.Name = "errorRichTextBox";
            errorRichTextBox.Size = new Size(303, 426);
            errorRichTextBox.TabIndex = 5;
            errorRichTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 450);
            Controls.Add(errorRichTextBox);
            Controls.Add(sqlServerButton);
            Controls.Add(postgreSqlButton);
            Controls.Add(runButton);
            Controls.Add(messageTextBox);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox messageTextBox;
        private Button runButton;
        private Button postgreSqlButton;
        private RichTextBox errorRichTextBox;
    }
}
