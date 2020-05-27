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
            this.SuspendLayout();
            // 
            // TxtQuery
            // 
            this.TxtQuery.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuery.Location = new System.Drawing.Point(12, 12);
            this.TxtQuery.Multiline = true;
            this.TxtQuery.Name = "TxtQuery";
            this.TxtQuery.Size = new System.Drawing.Size(672, 151);
            this.TxtQuery.TabIndex = 1;
            this.TxtQuery.Text = resources.GetString("TxtQuery.Text");
            // 
            // BtnSubmitQuery
            // 
            this.BtnSubmitQuery.Location = new System.Drawing.Point(690, 60);
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
            this.TxtResults.Size = new System.Drawing.Size(672, 219);
            this.TxtResults.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 400);
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
    }
}

