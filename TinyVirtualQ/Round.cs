using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyVirtualQ
{
    public class Round
    {
        public enum RoundStatus { Open, Close, InCourse }

        public int Id { get; }
        public int RequiredPlayers { get; }
        public string Name { get; }
        public int QuestionsByPlayer { get; }

        public RoundStatus Status { get; set; }

        public List<Question> TotalQuestions { get; set; }
        public List<Question> UsedQuestions { get; set; }
        public List<Player> Players { get; set; }

        public Round(int Id)
        {
            TotalQuestions = new List<Question>();
            UsedQuestions = new List<Question>();
            Players = new List<Player>();
        }

        List<Question> LoadAllQuestions()
        {
            string sql = "SELECT * FROM questions";

        }

        public void AddQuestion(Question UsedQuestion, string UserId)
        {
            UsedQuestions.Add(UsedQuestion);
        }

    }
}
