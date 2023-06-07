namespace Project
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            buttonLookDB = new Button();
            buttonAddPerson = new Button();
            labelPages = new Label();
            buttonUp = new Button();
            buttonDown = new Button();
            buttonUpEnd = new Button();
            buttonDownEnd = new Button();
            buttonFilters = new Button();
            textBoxNameF = new TextBox();
            groupBoxFilters = new GroupBox();
            buttonClear = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxHouseF = new TextBox();
            textBoxStreetF = new TextBox();
            textBoxCityF = new TextBox();
            textBoxAgeF = new TextBox();
            textBoxSurF = new TextBox();
            label2 = new Label();
            label1 = new Label();
            listViewData = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            buttonChange = new Button();
            buttonDelete = new Button();
            groupBoxFilters.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLookDB
            // 
            buttonLookDB.Location = new Point(483, 409);
            buttonLookDB.Name = "buttonLookDB";
            buttonLookDB.Size = new Size(94, 29);
            buttonLookDB.TabIndex = 2;
            buttonLookDB.Text = "Look";
            buttonLookDB.UseVisualStyleBackColor = true;
            buttonLookDB.Click += buttonLook_Click;
            // 
            // buttonAddPerson
            // 
            buttonAddPerson.Location = new Point(583, 409);
            buttonAddPerson.Name = "buttonAddPerson";
            buttonAddPerson.Size = new Size(94, 29);
            buttonAddPerson.TabIndex = 4;
            buttonAddPerson.Text = "Add Person";
            buttonAddPerson.UseVisualStyleBackColor = true;
            buttonAddPerson.Click += buttonAddPerson_Click;
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.Location = new Point(89, 413);
            labelPages.Name = "labelPages";
            labelPages.Size = new Size(39, 20);
            labelPages.TabIndex = 6;
            labelPages.Text = "0 / 0";
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(134, 409);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(28, 29);
            buttonUp.TabIndex = 7;
            buttonUp.Text = ">";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(55, 409);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(28, 29);
            buttonDown.TabIndex = 8;
            buttonDown.Text = "<";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // buttonUpEnd
            // 
            buttonUpEnd.Location = new Point(168, 409);
            buttonUpEnd.Name = "buttonUpEnd";
            buttonUpEnd.Size = new Size(37, 29);
            buttonUpEnd.TabIndex = 9;
            buttonUpEnd.Text = ">>";
            buttonUpEnd.UseVisualStyleBackColor = true;
            buttonUpEnd.Click += buttonUpEnd_Click;
            // 
            // buttonDownEnd
            // 
            buttonDownEnd.Location = new Point(12, 409);
            buttonDownEnd.Name = "buttonDownEnd";
            buttonDownEnd.Size = new Size(37, 29);
            buttonDownEnd.TabIndex = 10;
            buttonDownEnd.Text = "<<";
            buttonDownEnd.UseVisualStyleBackColor = true;
            buttonDownEnd.Click += buttonDownEnd_Click;
            // 
            // buttonFilters
            // 
            buttonFilters.Image = (Image)resources.GetObject("buttonFilters.Image");
            buttonFilters.ImageAlign = ContentAlignment.MiddleRight;
            buttonFilters.Location = new Point(592, 10);
            buttonFilters.Name = "buttonFilters";
            buttonFilters.Size = new Size(79, 29);
            buttonFilters.TabIndex = 11;
            buttonFilters.Text = "Filters";
            buttonFilters.TextAlign = ContentAlignment.MiddleLeft;
            buttonFilters.UseVisualStyleBackColor = true;
            buttonFilters.Click += buttonFilters_Click;
            // 
            // textBoxNameF
            // 
            textBoxNameF.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxNameF.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxNameF.Location = new Point(6, 40);
            textBoxNameF.Name = "textBoxNameF";
            textBoxNameF.Size = new Size(81, 27);
            textBoxNameF.TabIndex = 0;
            // 
            // groupBoxFilters
            // 
            groupBoxFilters.Controls.Add(buttonClear);
            groupBoxFilters.Controls.Add(label6);
            groupBoxFilters.Controls.Add(label5);
            groupBoxFilters.Controls.Add(label4);
            groupBoxFilters.Controls.Add(label3);
            groupBoxFilters.Controls.Add(textBoxHouseF);
            groupBoxFilters.Controls.Add(textBoxStreetF);
            groupBoxFilters.Controls.Add(textBoxCityF);
            groupBoxFilters.Controls.Add(textBoxAgeF);
            groupBoxFilters.Controls.Add(textBoxSurF);
            groupBoxFilters.Controls.Add(textBoxNameF);
            groupBoxFilters.Controls.Add(label2);
            groupBoxFilters.Controls.Add(label1);
            groupBoxFilters.Location = new Point(677, 2);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Size = new Size(93, 436);
            groupBoxFilters.TabIndex = 12;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Visible = false;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(12, 372);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 29);
            buttonClear.TabIndex = 13;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 300);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 12;
            label6.Text = "House Num";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 237);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 11;
            label5.Text = "Street";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 182);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 10;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 123);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 9;
            label3.Text = "Age";
            // 
            // textBoxHouseF
            // 
            textBoxHouseF.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxHouseF.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxHouseF.Location = new Point(6, 323);
            textBoxHouseF.Name = "textBoxHouseF";
            textBoxHouseF.Size = new Size(81, 27);
            textBoxHouseF.TabIndex = 7;
            // 
            // textBoxStreetF
            // 
            textBoxStreetF.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxStreetF.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxStreetF.Location = new Point(6, 260);
            textBoxStreetF.Name = "textBoxStreetF";
            textBoxStreetF.Size = new Size(81, 27);
            textBoxStreetF.TabIndex = 6;
            // 
            // textBoxCityF
            // 
            textBoxCityF.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxCityF.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxCityF.Location = new Point(6, 205);
            textBoxCityF.Name = "textBoxCityF";
            textBoxCityF.Size = new Size(81, 27);
            textBoxCityF.TabIndex = 5;
            // 
            // textBoxAgeF
            // 
            textBoxAgeF.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxAgeF.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxAgeF.Location = new Point(6, 146);
            textBoxAgeF.Name = "textBoxAgeF";
            textBoxAgeF.Size = new Size(81, 27);
            textBoxAgeF.TabIndex = 4;
            // 
            // textBoxSurF
            // 
            textBoxSurF.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxSurF.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxSurF.Location = new Point(6, 93);
            textBoxSurF.Name = "textBoxSurF";
            textBoxSurF.Size = new Size(81, 27);
            textBoxSurF.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // listViewData
            // 
            listViewData.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1 });
            listViewData.FullRowSelect = true;
            listViewData.GridLines = true;
            listViewData.Location = new Point(5, 45);
            listViewData.Name = "listViewData";
            listViewData.Size = new Size(672, 358);
            listViewData.TabIndex = 3;
            listViewData.UseCompatibleStateImageBehavior = false;
            listViewData.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Index";
            columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Data";
            columnHeader1.Width = 570;
            // 
            // buttonChange
            // 
            buttonChange.Location = new Point(383, 409);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(94, 29);
            buttonChange.TabIndex = 13;
            buttonChange.Text = "Change";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(283, 409);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonChange);
            Controls.Add(listViewData);
            Controls.Add(groupBoxFilters);
            Controls.Add(buttonFilters);
            Controls.Add(buttonDownEnd);
            Controls.Add(buttonUpEnd);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(labelPages);
            Controls.Add(buttonAddPerson);
            Controls.Add(buttonLookDB);
            Name = "MainWindow";
            Text = "Form1";
            Load += MainWindow_Load;
            groupBoxFilters.ResumeLayout(false);
            groupBoxFilters.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLookDB;
        private Button buttonAddPerson;
        private Label labelPages;
        private Button buttonUp;
        private Button buttonDown;
        private Button buttonUpEnd;
        private Button buttonDownEnd;
        private Button buttonFilters;
        private TextBox textBoxNameF;
        private GroupBox groupBoxFilters;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxHouseF;
        private TextBox textBoxStreetF;
        private TextBox textBoxCityF;
        private TextBox textBoxAgeF;
        private TextBox textBoxSurF;
        private Label label2;
        private Button buttonClear;
        private ListView listViewData;
        private ColumnHeader columnHeader1;
        private Button buttonChange;
        private ColumnHeader columnHeader2;
        private Button buttonDelete;
    }
}