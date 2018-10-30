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

                //  Para hacer cosas en serie (Siempre devuelve true)
                string[] sqls = sql_string.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (sqls.Length > 1)
                {
                    foreach (string s in sqls)
                    {
                        C.CommandText = s;
                        C.ExecuteNonQuery();
                    }
                    return true;
                }

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
        /// <summary>
        /// Carga todas las preguntas de la base de datos
        /// </summary>
        /// <returns></returns>
        public static Question[] LoadQuestions()
        {
            return GetQuestions("SELECT *, 0 AS Result, 0 AS Type FROM questions");
        }
        /// <summary>
        /// Carga solo las preguntas de un concurso especifico
        /// </summary>
        /// <param name="ContestId"></param>
        /// <returns></returns>
        public static Question[] LoadQuestions(int ContestId)
        {
            return GetQuestions("SELECT * FROM used_questions WHERE ContestId = " + ContestId);
        }
        public static Question[] LoadUsedQuestions(int PlayerId, int RoundId)
        {
            return GetQuestions("SELECT q.*, u.Result, u.Type " +
                "FROM used_questions u " +
                "LEFT JOIN questions q ON q.Id = u.QuestionId " +
                "WHERE u.PlayerId = " + PlayerId +
                " AND u.RoundId = " + RoundId);
        }
        public static Question[] LoadUsedQuestions(int RoundId)
        {
            return GetQuestions("SELECT q.*, u.Result, u.Type " +
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
                        d["Question"].ToString(),
                        d["Category"].ToString(),
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
            string sql = "SELECT * FROM players";
            if (RoundId > 0)
                sql = "SELECT p.* FROM players p LEFT JOIN round_players r ON r.PlayerId = p.Id WHERE r.RoundId = " + RoundId;

            DataRowCollection D = Select(sql);
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
        public static Player[] LoadPlayers(Player[] Exclude, int RoundId = 0)
        {
            //  Sacamos los id para excluir
            string ids = "";
            for (int i = 0; i < Exclude.Length; i++)
                ids += (i == 0 ? "" : " AND") + " Id <> " + Exclude[i].Id;

            //  Preparamos la consulta
            string sql = "SELECT * FROM players" + (Exclude.Length > 0 && RoundId == 0 ? " WHERE " + ids : "");
            if (RoundId > 0)
                sql = "SELECT p.* FROM players p LEFT JOIN round_players r ON r.PlayerId = p.Id WHERE r.RoundId = " + RoundId + (RoundId > 0 ? " AND " + ids : "");



            DataRowCollection D = Select(sql);
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

        public static bool CreateNew(Contest Contest)
        {
            return Exec("INSERT INTO contest (ContestName) VALUES ('" + Contest.Name + "')");
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
            return Exec("INSERT INTO questions (Category, Question, Answer) VALUES ('" + Question.Category.Replace('\'', ' ') +
                "', '" + Question.Text.Replace('\'', ' ') + "', '" + Question.Answer.Replace('\'', ' ') + "')");
        }
        public static bool Update(Question Question)
        {
            return Exec("UPDATE questions SET Category = '" + Question.Category.Replace('\'', ' ') +
                "', Question = '" + Question.Text.Replace('\'', ' ') + "', Answer = '" +
                Question.Answer.Replace('\'', ' ') + "' WHERE Id = " + Question.Id);
        }
        public static bool Delete(Question Question)
        {
            return Exec("DELETE FROM questions WHERE Id = " + Question.Id);
        }

        public static bool CreateNew(Player Player)
        {
            return Exec("INSERT INTO players (Firstname, Lastname, Picture) VALUES ('" + Player.Firstname.Replace('\'', ' ') +
                "', '" + Player.Lastname.Replace('\'', ' ') + "', '" + Player.PictureFilename.Replace('\'', ' ') + "')");
        }
        public static bool Update(Player Player)
        {
            return Exec("UPDATE players SET Firstname = '" + Player.Firstname.Replace('\'', ' ') +
                "', Lastname = '" + Player.Lastname.Replace('\'', ' ') + "', Picture = '" +
                Player.PictureFilename.Replace('\'', ' ') + "' WHERE Id = " + Player.Id);
        }
        public static bool Delete(Player Player)
        {
            return Exec("DELETE FROM players WHERE Id = " + Player.Id);
        }


        public static bool ResetRound(int Id)
        {
            //  Quitamos las preguntas contestadas
            string sql = "DELETE FROM used_questions WHERE RoundId = " + Id;
            if (Exec(sql))
            {
                //  Quitamos los jugadores
                sql = "DELETE FROM round_players WHERE RoundId = " + Id;
                return Exec(sql);
            }
            return false;
        }
        public static bool InsertPlayersInRound(Player[] Players, int RoundId)
        {
            if (Players.Length > 0)
            {
                string sql = "";

                foreach (Player P in Players)
                    sql += "INSERT INTO round_players (RoundId, PlayerId) VALUES (" + RoundId + ", " + P.Id + ");";

                return Exec(sql);

            }
            //  Si no viene ningun jugador, siempre es correcto
            return true;
        }
        public static bool AddQuestionToPlayer(int RoundId, int PlayerId, int QuestionId, Question.QuestionType Type)
        {
            string sql = "INSERT INTO used_questions (PlayerId, QuestionId, RoundId, Type, Result) VALUES" +
                "(" + PlayerId + "," + QuestionId + ", " + RoundId + "," + (int)Type + ", 0)";
            return Exec(sql);
        }
        public static bool SetQuestionResult(int RoundId, int PlayerId, int QuestionId, Question.QuestionResult Result)
        {
            string sql = "UPDATE used_questions SET Result = " + (int)Result + " WHERE PlayerId = " + PlayerId + " AND QuestionId = " + QuestionId + " AND RoundId = " + RoundId;
            return Exec(sql);
        }
    }
}
