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

        public List<Question> UsedQuestions { get; set; }
        public List<Player> Players { get; set; }

        public Round(int Id)
        {
            UsedQuestions = new List<Question>();
            Players = new List<Player>();
        }

        public void AddQuestion(Question UsedQuestion, string UserId)
        {
            UsedQuestions.Add(UsedQuestion);
        }

    }
}
