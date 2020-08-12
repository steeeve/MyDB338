using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace DB338Core
{
    class IntSchTable
    {

        private string name;

        private List<IntSchColumn> columns;

        public IntSchTable(string initname)
        {
            name = initname;
            columns = new List<IntSchColumn>();
        }

        public string Name { get => name; set => name = value; }

        public List<string> getAllColumns()
        {
            List<string> retlist = new List<string>();
            for (int i = 0; i < columns.Count; i++)
            {
                retlist.Add(columns[i].Name);
            }
            return retlist;
        }

        public List<string> getRowVals(int row)
        {
            List<string> retlist = new List<string>();
            for (int i = 0; i < columns.Count; ++i)
            {
                retlist.Add(columns[i].items[row]);
            }
            return retlist;
        }

        public string[,] Select(List<string> cols)
        {
            string[,] results = new string[columns[0].items.Count, cols.Count];

            for (int i = 0; i < cols.Count; ++i)
            {
                for (int j = 0; j < columns.Count; ++j)
                {
                    if (cols[i] == columns[j].Name)
                    {
                        for (int z = 0; z < columns[0].items.Count; ++z)
                        {
                            results[z, i] = columns[j].items[z];
                        }
                    }
                }
            }

            return results;
        }

        public string[,] SelectWhere(List<string> cols, List<string> colcond, List<string> valcond)
        {
            string[,] results = new string[columns[0].items.Count, cols.Count];
            int satisfies = 0;

            for (int i = 0; i < columns[0].items.Count; ++i) // looping thru rows (i)
            {
                for (int j = 0; j < columns.Count; ++j) // looping thru columns (j)
                {
                    if (colcond.Contains(columns[j].Name)) // this col has a condition to be checked
                    {
                        if (valcond.Contains(columns[j].items[i])) // satisfies condition
                        {
                            //keep checking the rest of the conds
                            satisfies += 1;
                        }
                        else // does not satisfy condition, move on to next row
                        {
                            satisfies = 0;
                            break;
                        }
                    }

                    if (j == columns.Count - 1 && satisfies == colcond.Count)
                    { // we satisfied the requirements, add this row to results
                        satisfies = 0;
                        for (int c = 0; c < columns.Count; ++c) // adding the entire row i to results
                        {
                            results[i, c] = columns[c].items[i];
                        }
                    }
                }
            }
            return results;
        }

        public bool Project()
        {
            throw new NotImplementedException();
        }

        public void Insert(List<string> cols, List<string> vals)
        {
            for (int i = 0; i < cols.Count; ++i)
            {
                for (int j = 0; j < columns.Count; ++j)
                {
                    if (columns[j].Name == cols[i])
                    {
                        columns[j].items.Add(vals[i]);
                    }
                }
            }
        }

        public void DeleteRow(int row)
        {
            for (int i = 0; i < columns.Count; ++i) // loops thru all cols in our table
            {
                for (int j = 0; j < columns[i].items.Count; ++j) // looping thru the contents of the column
                {
                    if (j == row) // found the index to be deleted
                    {
                        columns[i].items.RemoveAt(j);
                        break; // go to the next column
                    }
                }
            }
        }

        public void Remove(List<string> cols, List<string> vals)
        {
            // go thru all the rows of our table, go thru all the cols/vals, if the current row has it
            // where column[j].Name == cols[c] and columns[j].items[i] == vals[c], for all c, then call
            // DeleteRow on that row i

            // Does not work when more than one condition is specified...

            int satisfies = 0; // counter for how many conditions we satisfy
            for (int i = 0; i < columns[0].items.Count; ++i)
            { // looping thru rows of our table
                for (int j = 0; j < columns.Count; ++j)
                {// going thru ith row of each column
                    if (cols.Contains(columns[j].Name)) // name is in cols, should we remove this???
                    {
                        if (vals.Contains(columns[j].items[i])) // value of same column is in vals!!!
                        {
                            satisfies++; // we satisfie a requirement
                        }
                        else // its value does not belong in vals...
                        {
                            satisfies = 0;
                            break; // violated our requirement, move onto next row
                        }
                    }

                    if (j == columns.Count - 1 && satisfies == cols.Count) //delete the row, here we
                    // are on the last column of the row and have satisfied all the conditions
                    {
                        satisfies = 0;
                        DeleteRow(i);
                        break; // deleted this row, move onto next row
                    }
                }
            }
        }

        public void UpdateRow(List<string> cols, List<string> vals, int row)
        {
            for (int i = 0; i < columns.Count; ++i) // looping thru the columns of our table
            {
                for (int c = 0; c < cols.Count; ++c) // looping thru cols to update
                {
                    if (cols[c] == columns[i].Name) // this column should be updated at row with val[c]
                    {
                        columns[i].items[row] = vals[c]; // updating value
                        break; // move on to next column
                    }
                }
            }
        }

        public void Update(List<string> cols, List<string> vals, List<string> toCols, List<string> toVals)
        {
            int satisfies = 0; // counter for how many conditions we satisfie
            for (int i = 0; i < columns[0].items.Count; ++i)
            { // looping thru rows (i) of our table
                for (int j = 0; j < columns.Count; ++j)
                {// going thru ith row of each column

                    //for (int c = 0; c < toCols.Count; ++c)
                    //{
                    //    if (toCols[c] == columns[j].Name)
                    //    {
                    //        if (toVals[c] == columns[j].items[i]) // cond satisfied
                    //        {
                    //            satisfies++;
                    //        }
                    //        else // not satisfied, move on to next row
                    //        {
                    //            j = columns.Count - 1;
                    //            satisfies = 0;
                    //            break;
                    //        }
                    //    }
                    //}

                    if (toCols.Contains(columns[j].Name))
                    {
                        if (toVals.Contains(columns[j].items[i]))
                        {
                            satisfies++;
                        }
                        else
                        {
                            satisfies = 0;
                            break; // violated our requirement, move onto next row
                        }
                    }

                    if (j == columns.Count - 1 && satisfies == toCols.Count) // here we
                    // are on the last column of the row and have satisfied all the conditions
                    {
                        satisfies = 0;
                        // update the row we are on (i) with cols and vals
                        UpdateRow(cols, vals, i);
                        break; // updated this row, move onto next row
                    }
                }
            }
        }
        
        public bool AddColumn(string name, string type)
        {
            foreach (IntSchColumn col in columns) // adding a new column to our table, needs to be a diff name
            {
                if (col.Name == name)
                {
                    return false; // name already taken, addcolumn fails
                }
            }
            // name not taken if we get here
            columns.Add(new IntSchColumn(name, type)); // type specified here
            return true;
        }
    }
}
