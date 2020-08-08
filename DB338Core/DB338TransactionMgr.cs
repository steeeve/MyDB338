using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB338Core
{
    class DB338TransactionMgr
    {
        //the List of Internal Schema Tables holds the actual data for DB338
        //it is implemented using Lists, which could be replaced.
        List<IntSchTable> tables;

        public DB338TransactionMgr()
        {
            tables = new List<IntSchTable>();
        }

        public string[,] Process(List<string> tokens, string type) //Process function
        {
            string[,] results = new string[1,1];
            bool success;

            if (type == "create")
            {
                success = ProcessCreateTableStatement(tokens); // implemented
            }
            else if (type == "insert")
            {
                success = ProcessInsertStatement(tokens); // implemented
            }
            else if (type == "select")
            {
                results = ProcessSelectStatement(tokens); // implemented
            }
            else if (type == "alter")
            {
                results = ProcessAlterStatement(tokens);
            }
            else if (type == "delete")
            {
                results = ProcessDeleteStatement(tokens); // will implement
            }
            else if (type == "drop")
            {
                results = ProcessDropStatement(tokens);
            }
            else if (type == "update")
            {
                results = ProcessUpdateStatement(tokens); // will implement
            }
            else
            {
                results = null; // wrong syntax?
            }
            //other parts of SQL to do...

            // where, group by, having?

            return results;
        }

        private string[,] ProcessSelectStatement(List<string> tokens)
        {
            // <Select Stm> ::= SELECT <Columns> <From Clause> <Where Clause> <Group Clause> <Having Clause> <Order Clause>

            List<string> colsToSelect = new List<string>(); // list of names of cols
            int tableOffset = 0;

            for (int i = 1; i < tokens.Count; ++i)
            {
                if (tokens[i] == "from")
                {
                    tableOffset = i + 1; // next is the table to be selected?
                    break;
                }
                else if (tokens[i] == ",")
                {
                    continue;
                }
                else
                {
                    colsToSelect.Add(tokens[i]);
                }
            }

            string tableToSelectFrom = tokens[tableOffset]; // table we are selecting from

            for (int i = 0; i < tables.Count; ++i)
            {
                if (tables[i].Name == tableToSelectFrom) // found it
                {
                    return tables[i].Select(colsToSelect); // select worked
                }
            }

            return null; // select failed
        }

        private bool ProcessInsertStatement(List<string> tokens)
        {
            // <Insert Stm> ::= INSERT INTO Id '(' <ID List> ')' VALUES '(' <Expr List> ')'

            string insertTableName = tokens[2]; // table to insert into

            foreach (IntSchTable tbl in tables)
            {
                if (tbl.Name == insertTableName) // found it
                {
                    List<string> columnNames = new List<string>();
                    List<string> columnValues = new List<string>();

                    int offset = 0;

                    for (int i = 4; i < tokens.Count; ++i) // loops through '(' <ID List> ')'
                    {
                        if (tokens[i] == ")")
                        {
                            offset = i + 3;
                            break;
                        }
                        else if (tokens[i] == ",")
                        {
                            continue;
                        }
                        else
                        {
                            columnNames.Add(tokens[i]);
                        }
                    }

                    for (int i = offset; i < tokens.Count; ++i) // loops through VALUES '(' <Expr List> ')'
                    {
                        if (tokens[i] == ")") 
                        {
                            break;  // looped through entire insert statement
                        }
                        else if (tokens[i] == ",")
                        {
                            continue;
                        }
                        else
                        {
                            columnValues.Add(tokens[i]);
                        }
                    }

                    if (columnNames.Count != columnValues.Count)
                    {
                        return false; // insert failed
                    }
                    else
                    {
                        tbl.Insert(columnNames, columnValues);
                        return true; // insert worked
                    }
                }
            }

            return false; // insert failed
        }

        private bool ProcessCreateTableStatement(List<string> tokens)
        {
            // assuming only the following rule is accepted
            // <Create Stm> ::= CREATE TABLE Id '(' <ID List> ')'  ------ NO SUPPORT for <Constraint Opt>

            string newTableName = tokens[2];

            foreach (IntSchTable tbl in tables)
            {
                if (tbl.Name == newTableName)
                {
                    //cannot create a new table with the same name
                    return false; // only time create will not work
                }
            }

            List<string> columnNames = new List<string>(); // just like insert?!
            List<string> columnTypes = new List<string>();

            int idCount = 2;
            for (int i = 4; i < tokens.Count; ++i) // looping through '(' <ID List> ')'
            {
                if (tokens[i] == ")")
                {
                    break; // looped through entire create statement
                }
                else if (tokens[i] == ",")
                {
                    continue;
                }
                else
                {
                    if (idCount == 2)
                    {
                        columnNames.Add(tokens[i]);
                        --idCount;
                    }
                    else if (idCount == 1)
                    {
                        columnTypes.Add(tokens[i]);
                        idCount = 2;
                    }
                }
            }

            IntSchTable newTable = new IntSchTable(newTableName);

            for (int i = 0; i < columnNames.Count; ++i) // creating our table
            {
                newTable.AddColumn(columnNames[i], columnTypes[i]);
            }

            tables.Add(newTable); // table has been created

            return true; 
        }

        private string[,] ProcessUpdateStatement(List<string> tokens) // tokens represents the SQL code for the command to be run
        {
            throw new NotImplementedException();
            // <Update Stm> ::= UPDATE <Tablename> SET '(' <<col> = <val>, ... > ')' WHERE '(' <<col> = <val>, ... >) 


            string updateTableName = tokens[1]; // table to update

            foreach (IntSchTable tbl in tables)
            {
                if (tbl.Name == updateTableName) // found table to update
                {
                    List<string> columnNames = new List<string>();
                    List<string> columnValues = new List<string>();

                    List<string> toColumnNames = new List<string>();
                    List<string> toColumnValues = new List<string>();

                    int offset = 0;

                    for (int i = 4; i < tokens.Count; ++i) // loops through {SET} <<col> = <val>, ...>
                    {
                        if (tokens[i] == ")")    // conditions will be different to add to columnNames
                        {
                            offset = i + 3;
                            break;
                        }
                        else if (tokens[i] == ",")
                        {
                            continue;
                        }
                        else if (tokens[i] == "=")
                        {
                            i++;
                            columnValues.Add(tokens[i + 1]);
                        }
                        else
                        {
                            columnNames.Add(tokens[i]);
                        }
                    }

                    for (int i = offset; i < tokens.Count; ++i) // loops through {WHERE} <<col> = <val>, ...> 
                    {
                        if (tokens[i] == ")")   // conditions will be different to add to columnValues
                        {
                            break;  // looped through entire insert statement
                        }
                        else if (tokens[i] == ",")
                        {
                            continue;
                        }
                        else if (tokens[i] == "=")
                        {
                            i++;
                            toColumnValues.Add(tokens[i + 1]);
                        }
                        else
                        {
                            toColumnNames.Add(tokens[i]);
                        }
                    }



                    // by now we have columnNames and columnValues as well as the columnnames and vals of
                    //     where we would like to insert to

                    // Check for validity and perform our update
                    // Check we are updating x columns with x pieces of data
                    // delete the columns to be updated, insert at the same place? or just swap override vals?
                }
            }
        }

        private string[,] ProcessDropStatement(List<string> tokens)
        {
            throw new NotImplementedException();
        }

        private string[,] ProcessDeleteStatement(List<string> tokens)
        {
            throw new NotImplementedException();

            string[,] results = new string[1, 1];
            // Delete FROM <tbl_name> WHERE '(' col = val, .... ')'

            string deleteTableName = tokens[2];

            foreach (IntSchTable tbl in tables)
            {
                if (tbl.Name == deleteTableName)
                {
                    List<string> columnNames = new List<string>();
                    List<string> columnValues = new List<string>();

                    for (int i = 5; i < tokens.Count; ++i) // loops through  <<col> = <val>, ...>
                    {
                        if (tokens[i] == ")")
                        {
                            break;
                        }
                        else if (tokens[i] == ",")
                        {
                            continue;
                        }
                        else if (tokens[i] == "=")
                        {
                            i++;
                            columnValues.Add(tokens[i + 1]);
                        }

                        else
                        {
                            columnNames.Add(tokens[i]);
                        }
                    }

                    if (columnNames.Count != columnValues.Count)
                    {
                        return null; // delete failed
                    }
                    else
                    {
                        tbl.Remove(columnNames, columnValues);
                        results = tbl.Select(columnNames); // return the table we deleted from
                        return results; // delete worked
                    }
                }
            }
            return null; //delete failed
        }

        private string[,] ProcessAlterStatement(List<string> tokens)
        {
            throw new NotImplementedException();
        }
    }
}
