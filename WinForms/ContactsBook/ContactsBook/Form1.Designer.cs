namespace ContactsBook
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
            label1 = new Label();
            listBoxContacts = new ListBox();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            label2 = new Label();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            label3 = new Label();
            maskedTextBoxPhone = new MaskedTextBox();
            label4 = new Label();
            comboBoxEyesColor = new ComboBox();
            checkBoxMarried = new CheckBox();
            buttonAdd = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            labelMarried = new Label();
            labelEyesColor = new Label();
            labelPhone = new Label();
            labelGender = new Label();
            labelSurname = new Label();
            labelName = new Label();
            labelSelected = new Label();
            buttonRemove = new Button();
            label11 = new Label();
            textBoxImageURL = new TextBox();
            pictureBoxImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // listBoxContacts
            // 
            listBoxContacts.FormattingEnabled = true;
            listBoxContacts.ItemHeight = 15;
            listBoxContacts.Location = new Point(322, 9);
            listBoxContacts.Name = "listBoxContacts";
            listBoxContacts.Size = new Size(284, 424);
            listBoxContacts.TabIndex = 10;
            listBoxContacts.SelectedIndexChanged += listBoxContacts_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(213, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(12, 80);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(213, 23);
            textBoxSurname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Surname :";
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Checked = true;
            radioButtonMale.Location = new Point(11, 115);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(51, 19);
            radioButtonMale.TabIndex = 3;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(68, 115);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(63, 19);
            radioButtonFemale.TabIndex = 4;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 146);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "Phone :";
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Location = new Point(11, 164);
            maskedTextBoxPhone.Mask = "(000) 000-00-00";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(214, 23);
            maskedTextBoxPhone.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 201);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 9;
            label4.Text = "Eyes Color : ";
            // 
            // comboBoxEyesColor
            // 
            comboBoxEyesColor.FormattingEnabled = true;
            comboBoxEyesColor.Location = new Point(13, 219);
            comboBoxEyesColor.Name = "comboBoxEyesColor";
            comboBoxEyesColor.Size = new Size(121, 23);
            comboBoxEyesColor.TabIndex = 6;
            // 
            // checkBoxMarried
            // 
            checkBoxMarried.AutoSize = true;
            checkBoxMarried.Location = new Point(13, 257);
            checkBoxMarried.Name = "checkBoxMarried";
            checkBoxMarried.Size = new Size(67, 19);
            checkBoxMarried.TabIndex = 7;
            checkBoxMarried.Text = "Married";
            checkBoxMarried.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Lime;
            buttonAdd.Location = new Point(5, 410);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(659, 246);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 11;
            label5.Text = "Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(659, 276);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 12;
            label6.Text = "Surname :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(659, 306);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 13;
            label7.Text = "Gender :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(659, 336);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 14;
            label8.Text = "Phone :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(659, 366);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 15;
            label9.Text = "Eyes Color :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(659, 396);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 16;
            label10.Text = "Married :";
            // 
            // labelMarried
            // 
            labelMarried.AutoSize = true;
            labelMarried.Location = new Point(802, 396);
            labelMarried.Name = "labelMarried";
            labelMarried.Size = new Size(0, 15);
            labelMarried.TabIndex = 22;
            // 
            // labelEyesColor
            // 
            labelEyesColor.AutoSize = true;
            labelEyesColor.Location = new Point(802, 366);
            labelEyesColor.Name = "labelEyesColor";
            labelEyesColor.Size = new Size(0, 15);
            labelEyesColor.TabIndex = 21;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(802, 336);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(0, 15);
            labelPhone.TabIndex = 20;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(802, 306);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(0, 15);
            labelGender.TabIndex = 19;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(802, 276);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(0, 15);
            labelSurname.TabIndex = 18;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(802, 246);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 15);
            labelName.TabIndex = 17;
            // 
            // labelSelected
            // 
            labelSelected.AutoSize = true;
            labelSelected.Location = new Point(660, 217);
            labelSelected.Name = "labelSelected";
            labelSelected.Size = new Size(0, 15);
            labelSelected.TabIndex = 23;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.Red;
            buttonRemove.Location = new Point(86, 410);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 24;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 290);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 25;
            label11.Text = "Image URL :";
            // 
            // textBoxImageURL
            // 
            textBoxImageURL.Location = new Point(13, 308);
            textBoxImageURL.Name = "textBoxImageURL";
            textBoxImageURL.Size = new Size(212, 23);
            textBoxImageURL.TabIndex = 26;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Cursor = Cursors.IBeam;
            pictureBoxImage.ImageLocation = "";
            pictureBoxImage.Location = new Point(659, 12);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(251, 220);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 27;
            pictureBoxImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(922, 450);
            Controls.Add(pictureBoxImage);
            Controls.Add(textBoxImageURL);
            Controls.Add(label11);
            Controls.Add(buttonRemove);
            Controls.Add(labelSelected);
            Controls.Add(labelMarried);
            Controls.Add(labelEyesColor);
            Controls.Add(labelPhone);
            Controls.Add(labelGender);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonAdd);
            Controls.Add(checkBoxMarried);
            Controls.Add(comboBoxEyesColor);
            Controls.Add(label4);
            Controls.Add(maskedTextBoxPhone);
            Controls.Add(label3);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(textBoxSurname);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(listBoxContacts);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxContacts;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Label label2;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Label label3;
        private MaskedTextBox maskedTextBoxPhone;
        private Label label4;
        private ComboBox comboBoxEyesColor;
        private CheckBox checkBoxMarried;
        private Button buttonAdd;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label labelMarried;
        private Label labelEyesColor;
        private Label labelPhone;
        private Label labelGender;
        private Label labelSurname;
        private Label labelName;
        private Label labelSelected;
        private Button buttonRemove;
        private Label label11;
        private TextBox textBoxImageURL;
        private PictureBox pictureBoxImage;
    }
}