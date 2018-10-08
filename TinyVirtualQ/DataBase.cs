using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TinyVirtualQ
{
    public static class DataBase
    {
        public static Contest[] LoadContests()
        {
            DataRowCollection D = db_select("SELECT * FROM contest");
            List<Contest> C = new List<Contest>();
            foreach (DataRow d in D)
                C.Add(new Contest(d["Id"].ToString(), d["ContestName"].ToString()));

            return C.ToArray();
        }
        public static Question[] LoadQuestions()
        {
            DataRowCollection D = db_select("SELECT * FROM questions");
            List<Question> Q = new List<Question>();
            foreach (DataRow d in D)
                Q.Add(new Question(
                        d["Id"].ToString(),
                        d["Category"].ToString(),
                        d["Question"].ToString(),
                        d["Answer"].ToString()
                    )
                );

            return Q.ToArray();
        }
        public static Player[] LoadPlayers()
        {
            DataRowCollection D = db_select("SELECT * FROM players");
            List<Player> P = new List<Player>();
            foreach (DataRow d in D)
                P.Add(new Player(
                        d["Id"].ToString(),
                        d["Firsname"].ToString(),
                        d["Lastname"].ToString(),
                        d["Picture"].ToString()
                    )
                );
            return P.ToArray();
        }

        public static bool db_exect(string sql_string, OleDbParameter[] Params = null)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + Application.ExecutablePath + "\\questy-on.mdb";

            try
            {
                conn.Open();
                OleDbCommand C = new OleDbCommand();
                C.Connection = conn;
                if (Params != null)
                    C.Parameters.AddRange(Params);
                C.CommandText = sql_string;
                C.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataRowCollection db_select(string sql_string, OleDbParameter[] Params = null)
        {
            string strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.ExecutablePath + "\\questy-on.mdb";

            // Create the dataset and add the Categories table to it:
            DataSet myDataSet = new DataSet();
            OleDbConnection myAccessConn = null;
            try
            {
                myAccessConn = new OleDbConnection(strAccessConn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                myAccessConn.Open();
                OleDbCommand myAccessCommand;
                OleDbDataAdapter myDataAdapter;

                foreach (string s in sql_string.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                    if (s.Trim() != "")
                    {
                        myAccessCommand = new OleDbCommand(s.Trim(), myAccessConn);
                        myDataAdapter = new OleDbDataAdapter(myAccessCommand);
                        myDataAdapter.Fill(myDataSet);
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                myAccessConn.Close();
            }
            return (myDataSet.Tables.Count > 0 ? myDataSet.Tables[0].Rows : null);
        }
    }
}
