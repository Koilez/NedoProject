namespace Project
{
    partial class WindowAddData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxFirsName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxAge = new TextBox();
            textBoxCity = new TextBox();
            textBoxStreet = new TextBox();
            textBoxNumberHouse = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonAdd = new Button();
            buttonClose = new Button();
            comboBoxIsALive = new ComboBox();
            SuspendLayout();
            // 
            // textBoxFirsName
            // 
            textBoxFirsName.Location = new Point(201, 20);
            textBoxFirsName.Name = "textBoxFirsName";
            textBoxFirsName.Size = new Size(125, 27);
            textBoxFirsName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(201, 53);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(125, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(201, 86);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(125, 27);
            textBoxAge.TabIndex = 2;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(201, 152);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(125, 27);
            textBoxCity.TabIndex = 4;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(201, 185);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(125, 27);
            textBoxStreet.TabIndex = 5;
            // 
            // textBoxNumberHouse
            // 
            textBoxNumberHouse.Location = new Point(201, 218);
            textBoxNumberHouse.Name = "textBoxNumberHouse";
            textBoxNumberHouse.Size = new Size(125, 27);
            textBoxNumberHouse.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 53);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 86);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 9;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 119);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 10;
            label4.Text = "Is a live";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 155);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 11;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 188);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 12;
            label6.Text = "Street";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 218);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 13;
            label7.Text = "Number House";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(53, 260);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(201, 260);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 15;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // comboBoxIsALive
            // 
            comboBoxIsALive.AllowDrop = true;
            comboBoxIsALive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIsALive.FormattingEnabled = true;
            comboBoxIsALive.Items.AddRange(new object[] { "True", "False" });
            comboBoxIsALive.Location = new Point(201, 119);
            comboBoxIsALive.Name = "comboBoxIsALive";
            comboBoxIsALive.Size = new Size(125, 28);
            comboBoxIsALive.TabIndex = 16;
            // 
            // WindowAddData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 315);
            Controls.Add(comboBoxIsALive);
            Controls.Add(buttonClose);
            Controls.Add(buttonAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNumberHouse);
            Controls.Add(textBoxStreet);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxFirsName);
            Name = "WindowAddData";
            Text = "WindowAddData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirsName;
        private TextBox textBoxSurname;
        private TextBox textBoxAge;
        private TextBox textBoxCity;
        private TextBox textBoxStreet;
        private TextBox textBoxNumberHouse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonAdd;
        private Button buttonClose;
        private ComboBox comboBoxIsALive;
    }
}