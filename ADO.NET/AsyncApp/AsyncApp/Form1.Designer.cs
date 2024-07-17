namespace AsyncApp
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
            GetDataButton = new Button();
            dataGridView1 = new DataGridView();
            TestButton = new Button();
            asyncGetDataButton = new Button();
            GetDataAsyncHanldeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // GetDataButton
            // 
            GetDataButton.Location = new Point(12, 383);
            GetDataButton.Name = "GetDataButton";
            GetDataButton.Size = new Size(137, 55);
            GetDataButton.TabIndex = 0;
            GetDataButton.Text = "Get Data";
            GetDataButton.UseVisualStyleBackColor = true;
            GetDataButton.Click += GetData;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(692, 365);
            dataGridView1.TabIndex = 1;
            // 
            // TestButton
            // 
            TestButton.Location = new Point(290, 383);
            TestButton.Name = "TestButton";
            TestButton.Size = new Size(126, 55);
            TestButton.TabIndex = 2;
            TestButton.Text = "0";
            TestButton.UseVisualStyleBackColor = true;
            // 
            // asyncGetDataButton
            // 
            asyncGetDataButton.Location = new Point(433, 383);
            asyncGetDataButton.Name = "asyncGetDataButton";
            asyncGetDataButton.Size = new Size(128, 55);
            asyncGetDataButton.TabIndex = 3;
            asyncGetDataButton.Text = "Get Data Async (callback )";
            asyncGetDataButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            asyncGetDataButton.UseVisualStyleBackColor = true;
            asyncGetDataButton.Click += asyncGetDataButton_Click;
            // 
            // GetDataAsyncHanldeButton
            // 
            GetDataAsyncHanldeButton.Location = new Point(567, 383);
            GetDataAsyncHanldeButton.Name = "GetDataAsyncHanldeButton";
            GetDataAsyncHanldeButton.Size = new Size(137, 55);
            GetDataAsyncHanldeButton.TabIndex = 4;
            GetDataAsyncHanldeButton.Text = "Get Data Async (Handle)";
            GetDataAsyncHanldeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            GetDataAsyncHanldeButton.UseVisualStyleBackColor = true;
            GetDataAsyncHanldeButton.Click += GetDataAsyncHanldeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 450);
            Controls.Add(GetDataAsyncHanldeButton);
            Controls.Add(asyncGetDataButton);
            Controls.Add(TestButton);
            Controls.Add(dataGridView1);
            Controls.Add(GetDataButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button GetDataButton;
        private DataGridView dataGridView1;
        private Button TestButton;
        private Button asyncGetDataButton;
        private Button GetDataAsyncHanldeButton;
    }
}
