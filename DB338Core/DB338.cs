using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DB338Core
{
    public class DB338
    {
        private SQLParser sqlParser;
        private DB338TransactionMgr transactionMgr;

        public DB338()
        {
            sqlParser = new SQLParser();
            sqlParser.Setup();
            transactionMgr = new DB338TransactionMgr();
        }

        public string[,] SubmitQuery(string query)
        {
            TextReader scriptText = new StringReader(query);

            List<string> tokens = sqlParser.Parse(scriptText);

            //sqlParser.Parse will always return the tokens of the query if accepted
            //the TYPE of the query is passed into the transaction manager, so you know what to check

            string queryType = tokens[tokens.Count - 3];
            string done = tokens[tokens.Count - 2];
            string accepted = tokens[tokens.Count - 1];

            tokens.RemoveAt(tokens.Count - 1);
            tokens.RemoveAt(tokens.Count - 1);
            tokens.RemoveAt(tokens.Count - 1);

            if (accepted == "True")
            {
                string[,] results = transactionMgr.Process(tokens, queryType);
                return results;
            }
            else
            {
                return null;
            }
        }

    }
}
