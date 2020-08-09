using System;
using System.Collections.Generic;
using System.Text;

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
            for (int i = 0; i < columns.Count; ++i) // loops thru all cols
            {
                for (int j = 0; j < columns[i].items.Count; ++j) // looping thru the contents of the column
                {
                    if (j == row) // found the index to be deleted
                    {
                        columns[i].items.RemoveAt(j);
                    }
                }
            }
        }

        public void Remove(List<string> cols, List<string> vals)
        {
            // go thru all the rows of our table, go thru all the cols/vals, if the current row has it
            // where column[j].Name == cols[c] and columns[j].items[i] == vals[c], for all c, then call
            // DeleteRow on that row i
            int satisfies = 0; // counter for how many conditions we satisfie
            for (int i = 0; i < columns[0].items.Count; ++i)
            { // looping thru rows of our table
                for (int j = 0; j < columns.Count; ++j)
                {// going thru ith row of each column
                    if (cols.Contains(columns[j].Name)
                    {
                        if (vals.Contains(columns[j].items[i]))
                        {
                            satisfies++;
                        }
                        else
                        {
                            break; // violated our requirement
                        }
                    }
                    else
                    {
                        continue;
                    }

                    if (j == columns.Count - 1 && satisfies == cols.Count) //delete the row when we
                    // are on the last column of the row and have satisfied all the conditions
                    {
                        DeleteRow(i);
                    }
                }
            }
        }


        
        public bool AddColumn(string name, string type)
        {
            foreach (IntSchColumn col in columns)
            {
                if (col.Name == name)
                {
                    return false;
                }
            }

            columns.Add(new IntSchColumn(name, type));
            return true;
        }
    }
}
