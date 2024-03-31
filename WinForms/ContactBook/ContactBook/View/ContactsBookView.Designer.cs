namespace ContactBook
{
    partial class ContactsBookView
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
            listBoxContacts = new ListBox();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAdd = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // listBoxContacts
            // 
            listBoxContacts.FormattingEnabled = true;
            listBoxContacts.ItemHeight = 15;
            listBoxContacts.Location = new Point(12, 12);
            listBoxContacts.Name = "listBoxContacts";
            listBoxContacts.Size = new Size(307, 259);
            listBoxContacts.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 290);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(307, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(12, 336);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(307, 23);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(12, 377);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(307, 23);
            textBoxPhone.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 274);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 4;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 316);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Surname : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 362);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "Phone : ";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(244, 415);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += OnClick_AddButton;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(12, 415);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += OnClick_DeleteButton;
            // 
            // ContactsBookView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(listBoxContacts);
            Name = "ContactsBookView";
            Text = "ContactsBookView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxContacts;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAdd;
        private Button buttonDelete;
    }
}