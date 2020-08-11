using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB338Core;

namespace DB338GUI
{
    public partial class FrmMain : Form
    {
        public DB338 db;

        public FrmMain()
        {
            InitializeComponent();
            db = new DB338();
        }

        private void BtnSubmitQuery_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TxtQuery.Lines.Length; ++i)
            {
                QueryResult queryResult = db.SubmitQuery(TxtQuery.Lines[i]);
                string[,] queryResults = queryResult.Results;
                if (queryResult.Error != "none")
                {
                    //null means error
                    MessageBox.Show("Input SQL contained a " + queryResult.Error + " error." + TxtQuery.Lines[i]);
                }
                else 
                {
                    Output(queryResults);
                }
            }
        }

        public void Output(string[,] results)
        {
            string s = "";
            for (int i = 0; i <= results.GetUpperBound(0); ++i)
            {
                for (int j = 0; j <= results.GetUpperBound(1); ++j)
                {
                    s += results[i, j] + ", ";
                }
                s += Environment.NewLine;
            }
            TxtResults.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create table
            string q = "create table " + TableNameTxtBox.Text + "(" + TableColumnsTxtBox.Text + ")";
            QueryResult queryResult = db.SubmitQuery(q);
            string[,] queryResults = queryResult.Results;
            if (queryResult.Error != "none")
            {
                MessageBox.Show("Input SQL contained a " + queryResult.Error + " error.");
            }
            else
            {
                Output(queryResults);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Insert into
            string q = "insert into " + insertTableText.Text + "(" + insertColText.Text + ") values(" + insertValText.Text + ")";
            QueryResult queryResult = db.SubmitQuery(q);
            string[,] queryResults = queryResult.Results;
            if (queryResult.Error != "none")
            {
                MessageBox.Show("Input SQL contained a " + queryResult.Error + " error." + q);
            }
            else
            {
                Output(queryResults);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // select
            string q = "select " + selectColNames.Text + " from " + selectTableName.Text;
            QueryResult queryResult = db.SubmitQuery(q);
            string[,] queryResults = queryResult.Results;
            if (queryResult.Error != "none")
            {
                MessageBox.Show("Input SQL contained a " + queryResult.Error + " error.");
            }
            else
            {
                Output(queryResults);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string q = "delete from " + deleteTable.Text + " where " + deleteCond.Text;
            QueryResult queryResult = db.SubmitQuery(q);
            string[,] queryResults = queryResult.Results;
            if (queryResult.Error != "none")
            {
                MessageBox.Show("Input SQL contained a " + queryResult.Error + " error.");
            }
            else
            {
                Output(queryResults);
            }
        }
    }
}
