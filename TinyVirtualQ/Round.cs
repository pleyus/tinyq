using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyVirtualQ
{
    public class Round
    {

        // CQNEN: public enum RoundStatus { Open, Close, InCourse }

        public int Id { get; set; }
        public int RequiredPlayers { get; set; }
        public int QuestionsByPlayer { get; set; }

        public int UsedQuestions { get
            {
                return DataBase.LoadUsedQuestions(Id).Length;
            }
        }
        public List<Player> Players { get; set; }

        public Round(string Id, string RequiredPlayers, string QuestionsByPlayer)
        {
            int id = 0;
            int rp = 0;
            int qp = 0;
            try
            {
                id = int.Parse(Id);
                rp = int.Parse(RequiredPlayers);
                qp = int.Parse(QuestionsByPlayer);
            }
            catch { }
            Set(id, rp, qp);
        }
        public Round(int Id, int RequiredPlayers, int QuestionsByPlayer)
        {
            Set(Id, RequiredPlayers, QuestionsByPlayer);
        }


        void Set(int Id, int RequiredPlayers, int QuestionsByPlayer)
        {
            this.Id = Id;
            this.RequiredPlayers = RequiredPlayers;
            this.QuestionsByPlayer = QuestionsByPlayer;

            //UsedQuestions = new List<Question>();
            Players = new List<Player>();

         }

    }
}
