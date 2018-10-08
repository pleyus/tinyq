using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TinyVirtualQ
{
    public static class DataBase
    {
        static string CNN = @"Provider=Microsoft.Jet.OLEDB.4.0;Data source = " + Application.StartupPath + "\\questy-on.mdb";

        public static bool Exec(string sql_string, OleDbParameter[] Params = null)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = CNN;

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
        public static DataRowCollection Select(string sql_string, OleDbParameter[] Params = null)
        {
            string strAccessConn = CNN;

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

        public static Contest[] LoadContests()
        {
            DataRowCollection D = Select("SELECT * FROM contest");
            List<Contest> C = new List<Contest>();
            foreach (DataRow d in D)
                C.Add(new Contest(d["Id"].ToString(), d["ContestName"].ToString()));

            return C.ToArray();
        }
        public static Round[] LoadRounds(int ContestId = 0)
        {
            DataRowCollection D = Select("SELECT * FROM rounds " +
                (ContestId > 0 ? "WHERE ContestId = " + ContestId : "") + 
                " ORDER BY Id ASC");
            List<Round> R = new List<Round>();
            foreach (DataRow d in D)
                R.Add(
                    new Round(
                        d["Id"].ToString(),
                        d["RequiredPlayers"].ToString(),
                        d["QuestionsByPlayer"].ToString()
                    )
                );

            return R.ToArray();
        }
        public static Question[] LoadQuestions()
        {
            return GetQuestions("SELECT *, 0 AS Result, 0 AS Type FROM questions");
        }
        public static Question[] LoadUsedQuestions(int PlayerId, int RoundId)
        {
            return GetQuestions("SELECT q.*, u.Result " +
                "FROM used_questions u " +
                "LEFT JOIN questions q ON q.Id = u.QuestionId " +
                "WHERE u.PlayerId = " + PlayerId + 
                " AND u.RoundId = " + RoundId);
        }
        public static Question[] LoadUsedQuestions(int RoundId)
        {
            return GetQuestions("SELECT q.*, u.Result " +
                "FROM used_questions u " +
                "LEFT JOIN questions q ON q.Id = u.QuestionId " +
                "WHERE u.RoundId = " + RoundId);
        }
        static Question[] GetQuestions(string sql)
        {
            DataRowCollection D = Select(sql);
            List<Question> Q = new List<Question>();
            foreach (DataRow d in D)
            {
                Q.Add(new Question(
                        d["Id"].ToString(),
                        d["Category"].ToString(),
                        d["Question"].ToString(),
                        d["Answer"].ToString(),
                        d["Result"].ToString(),
                        d["Type"].ToString()
                    )
                );
            }
            return Q.ToArray();
        }
        public static Player[] LoadPlayers(int RoundId = 0)
        {
            DataRowCollection D = Select("SELECT * FROM players");
            List<Player> P = new List<Player>();

            foreach (DataRow d in D)
            {
                Player p = new Player(
                    d["Id"].ToString(),
                    d["Firstname"].ToString(),
                    d["Lastname"].ToString(),
                    d["Picture"].ToString()
                );
                if (RoundId > 0)
                    p.Questions.AddRange(LoadUsedQuestions(p.Id, RoundId));

                P.Add(p);
            }
            return P.ToArray();
        }

        public static bool CreateNew(Round Round, int ContestId)
        {
            return Exec("INSERT INTO rounds (ContestId, RequiredPlayers, QuestionsByPlayer) VALUES (" + ContestId + ", " + Round.RequiredPlayers + ", " + Round.QuestionsByPlayer + ")");
        }
        public static bool Update(Round Round)
        {
            return Exec("UPDATE rounds SET RequiredPlayers = " + Round.RequiredPlayers + 
                ", QuestionsByPlayer = " + Round.QuestionsByPlayer + " WHERE Id = " + Round.Id);
        }
        public static bool Delete(Round Round)
        {
            return Exec("DELETE FROM rounds WHERE Id = " + Round.Id);
        }

        public static bool CreateNew(Question Question)
        {
            return Exec("INSERT INTO questions (Category, Question, Answer) VALUES (" + Question.Category + ", "  + Question.Text + ", " + Question.Answer + ")");
        }
        public static bool Update(Question Question)
        {
            return Exec("UPDATE questions SET Category = '" + Question.Category + 
                "', Question = '" + Question.Text + "', Answer = '" + 
                Question.Answer + "' WHERE Id = " + Question.Id);
        }

    }
}
