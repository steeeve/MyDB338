namespace DB338GUI
{
    partial class FrmMain
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
            this.TxtResults = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TableNameTxtBox = new System.Windows.Forms.TextBox();
            this.TableColumnsTxtBox = new System.Windows.Forms.TextBox();
            this.ColDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insertTableText = new System.Windows.Forms.TextBox();
            this.insertColText = new System.Windows.Forms.TextBox();
            this.insertValText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.selectTableName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.selectColNames = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.deleteTable = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.deleteCond = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.updateCond = new System.Windows.Forms.TextBox();
            this.updateSetToValues = new System.Windows.Forms.TextBox();
            this.updateTableName = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtResults
            // 
            this.TxtResults.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResults.Location = new System.Drawing.Point(12, 237);
            this.TxtResults.Multiline = true;
            this.TxtResults.Name = "TxtResults";
            this.TxtResults.Size = new System.Drawing.Size(1187, 203);
            this.TxtResults.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(979, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(986, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create a Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(974, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tablename:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(977, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Table Cols:";
            // 
            // TableNameTxtBox
            // 
            this.TableNameTxtBox.Location = new System.Drawing.Point(1043, 47);
            this.TableNameTxtBox.Name = "TableNameTxtBox";
            this.TableNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TableNameTxtBox.TabIndex = 8;
            this.TableNameTxtBox.Text = "Workout1";
            // 
            // TableColumnsTxtBox
            // 
            this.TableColumnsTxtBox.Location = new System.Drawing.Point(1043, 99);
            this.TableColumnsTxtBox.Name = "TableColumnsTxtBox";
            this.TableColumnsTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TableColumnsTxtBox.TabIndex = 9;
            this.TableColumnsTxtBox.Text = "reps int, excer string";
            // 
            // ColDescription
            // 
            this.ColDescription.AutoSize = true;
            this.ColDescription.Location = new System.Drawing.Point(1021, 122);
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.Size = new System.Drawing.Size(157, 13);
            this.ColDescription.TabIndex = 10;
            this.ColDescription.Text = "Example: col1 type1, col2 type2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1021, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Example: MyTable";
            // 
            // insertTableText
            // 
            this.insertTableText.Location = new System.Drawing.Point(807, 51);
            this.insertTableText.Name = "insertTableText";
            this.insertTableText.Size = new System.Drawing.Size(100, 20);
            this.insertTableText.TabIndex = 12;
            this.insertTableText.Text = "Workout1";
            // 
            // insertColText
            // 
            this.insertColText.Location = new System.Drawing.Point(807, 99);
            this.insertColText.Name = "insertColText";
            this.insertColText.Size = new System.Drawing.Size(100, 20);
            this.insertColText.TabIndex = 13;
            this.insertColText.Text = "reps, excer";
            // 
            // insertValText
            // 
            this.insertValText.Location = new System.Drawing.Point(807, 144);
            this.insertValText.Name = "insertValText";
            this.insertValText.Size = new System.Drawing.Size(100, 20);
            this.insertValText.TabIndex = 14;
            this.insertValText.Text = "1, Curls";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Insert an entry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Table to insert into:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(710, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Column names:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(710, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Values to insert:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(794, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Example: MyTable";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(794, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Example: col1, col2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(810, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Example: \"fruit\", \"vegaetable\"";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(467, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Select entries";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(467, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Table to select from:";
            // 
            // selectTableName
            // 
            this.selectTableName.Location = new System.Drawing.Point(576, 51);
            this.selectTableName.Name = "selectTableName";
            this.selectTableName.Size = new System.Drawing.Size(100, 20);
            this.selectTableName.TabIndex = 25;
            this.selectTableName.Text = "Workout1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(470, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Columns to select:";
            // 
            // selectColNames
            // 
            this.selectColNames.Location = new System.Drawing.Point(576, 99);
            this.selectColNames.Name = "selectColNames";
            this.selectColNames.Size = new System.Drawing.Size(100, 20);
            this.selectColNames.TabIndex = 27;
            this.selectColNames.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(561, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Example: MyTable";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(564, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Example: col1, col2, col3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(473, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(233, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Delete a row";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(233, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Table to delete from:";
            // 
            // deleteTable
            // 
            this.deleteTable.Location = new System.Drawing.Point(339, 51);
            this.deleteTable.Name = "deleteTable";
            this.deleteTable.Size = new System.Drawing.Size(100, 20);
            this.deleteTable.TabIndex = 33;
            this.deleteTable.Text = "Workout1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(236, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Condition";
            // 
            // deleteCond
            // 
            this.deleteCond.Location = new System.Drawing.Point(293, 97);
            this.deleteCond.Name = "deleteCond";
            this.deleteCond.Size = new System.Drawing.Size(145, 20);
            this.deleteCond.TabIndex = 35;
            this.deleteCond.Text = "reps = 1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(322, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "Example: MyTable";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(290, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(133, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Example: col1 = cat and ...";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Update a table";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 13);
            this.label23.TabIndex = 40;
            this.label23.Text = "Table to update:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 101);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 13);
            this.label24.TabIndex = 41;
            this.label24.Text = "Condition:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 146);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 42;
            this.label25.Text = "Set to:";
            // 
            // updateCond
            // 
            this.updateCond.Location = new System.Drawing.Point(70, 99);
            this.updateCond.Name = "updateCond";
            this.updateCond.Size = new System.Drawing.Size(127, 20);
            this.updateCond.TabIndex = 43;
            this.updateCond.Text = "reps = 1";
            // 
            // updateSetToValues
            // 
            this.updateSetToValues.Location = new System.Drawing.Point(70, 144);
            this.updateSetToValues.Name = "updateSetToValues";
            this.updateSetToValues.Size = new System.Drawing.Size(127, 20);
            this.updateSetToValues.TabIndex = 44;
            this.updateSetToValues.Text = "reps = 10";
            // 
            // updateTableName
            // 
            this.updateTableName.Location = new System.Drawing.Point(101, 51);
            this.updateTableName.Name = "updateTableName";
            this.updateTableName.Size = new System.Drawing.Size(96, 20);
            this.updateTableName.TabIndex = 45;
            this.updateTableName.Text = "Workout1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 46;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(67, 122);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(133, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "Example: col1 = cat and ...";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(22, 171);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(175, 13);
            this.label27.TabIndex = 48;
            this.label27.Text = "Example: col1 = dog, col2 = UW, ...";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(101, 74);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(94, 13);
            this.label28.TabIndex = 49;
            this.label28.Text = "Example: MyTable";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 452);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.updateTableName);
            this.Controls.Add(this.updateSetToValues);
            this.Controls.Add(this.updateCond);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.deleteCond);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.deleteTable);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.selectColNames);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.selectTableName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.insertValText);
            this.Controls.Add(this.insertColText);
            this.Controls.Add(this.insertTableText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ColDescription);
            this.Controls.Add(this.TableColumnsTxtBox);
            this.Controls.Add(this.TableNameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtResults);
            this.Name = "FrmMain";
            this.Text = "DB338 0.01 Alpha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtResults;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TableNameTxtBox;
        private System.Windows.Forms.TextBox TableColumnsTxtBox;
        private System.Windows.Forms.Label ColDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox insertTableText;
        private System.Windows.Forms.TextBox insertColText;
        private System.Windows.Forms.TextBox insertValText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox selectTableName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox selectColNames;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox deleteTable;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox deleteCond;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox updateCond;
        private System.Windows.Forms.TextBox updateSetToValues;
        private System.Windows.Forms.TextBox updateTableName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
    }
}

