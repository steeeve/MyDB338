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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TxtQuery = new System.Windows.Forms.TextBox();
            this.BtnSubmitQuery = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // TxtQuery
            // 
            this.TxtQuery.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuery.Location = new System.Drawing.Point(12, 12);
            this.TxtQuery.Multiline = true;
            this.TxtQuery.Name = "TxtQuery";
            this.TxtQuery.Size = new System.Drawing.Size(351, 151);
            this.TxtQuery.TabIndex = 1;
            this.TxtQuery.Text = resources.GetString("TxtQuery.Text");
            // 
            // BtnSubmitQuery
            // 
            this.BtnSubmitQuery.Location = new System.Drawing.Point(228, 169);
            this.BtnSubmitQuery.Name = "BtnSubmitQuery";
            this.BtnSubmitQuery.Size = new System.Drawing.Size(96, 29);
            this.BtnSubmitQuery.TabIndex = 2;
            this.BtnSubmitQuery.Text = "Run";
            this.BtnSubmitQuery.UseVisualStyleBackColor = true;
            this.BtnSubmitQuery.Click += new System.EventHandler(this.BtnSubmitQuery_Click);
            // 
            // TxtResults
            // 
            this.TxtResults.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResults.Location = new System.Drawing.Point(12, 169);
            this.TxtResults.Multiline = true;
            this.TxtResults.Name = "TxtResults";
            this.TxtResults.Size = new System.Drawing.Size(210, 219);
            this.TxtResults.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 140);
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
            this.label1.Location = new System.Drawing.Point(637, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create a Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tablename:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Table Cols:";
            // 
            // TableNameTxtBox
            // 
            this.TableNameTxtBox.Location = new System.Drawing.Point(694, 41);
            this.TableNameTxtBox.Name = "TableNameTxtBox";
            this.TableNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TableNameTxtBox.TabIndex = 8;
            // 
            // TableColumnsTxtBox
            // 
            this.TableColumnsTxtBox.Location = new System.Drawing.Point(694, 100);
            this.TableColumnsTxtBox.Name = "TableColumnsTxtBox";
            this.TableColumnsTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TableColumnsTxtBox.TabIndex = 9;
            // 
            // ColDescription
            // 
            this.ColDescription.AutoSize = true;
            this.ColDescription.Location = new System.Drawing.Point(627, 124);
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.Size = new System.Drawing.Size(163, 13);
            this.ColDescription.TabIndex = 10;
            this.ColDescription.Text = "Example: (col1 type1, col2 type2)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(691, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Example: MyTable";
            // 
            // insertTableText
            // 
            this.insertTableText.Location = new System.Drawing.Point(469, 45);
            this.insertTableText.Name = "insertTableText";
            this.insertTableText.Size = new System.Drawing.Size(100, 20);
            this.insertTableText.TabIndex = 12;
            // 
            // insertColText
            // 
            this.insertColText.Location = new System.Drawing.Point(469, 93);
            this.insertColText.Name = "insertColText";
            this.insertColText.Size = new System.Drawing.Size(100, 20);
            this.insertColText.TabIndex = 13;
            // 
            // insertValText
            // 
            this.insertValText.Location = new System.Drawing.Point(469, 138);
            this.insertValText.Name = "insertValText";
            this.insertValText.Size = new System.Drawing.Size(100, 20);
            this.insertValText.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Insert an entry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Table to insert into:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Column names:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Values to insert:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Example: MyTable";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Example: (col1, col2)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Example: (\"fruit\", \"vegaetable\")";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 452);
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
            this.Controls.Add(this.BtnSubmitQuery);
            this.Controls.Add(this.TxtQuery);
            this.Name = "FrmMain";
            this.Text = "DB338 0.01 Alpha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtQuery;
        private System.Windows.Forms.Button BtnSubmitQuery;
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
    }
}

