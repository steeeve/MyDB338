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
            this.BtnSubmitQuery.Location = new System.Drawing.Point(369, 12);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create Table";
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
            this.ColDescription.Size = new System.Drawing.Size(178, 13);
            this.ColDescription.TabIndex = 10;
            this.ColDescription.Text = "Example: (col1 type1, col2 type2, ...)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Example: MyTable";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 452);
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
    }
}

