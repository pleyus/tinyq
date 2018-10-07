using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyVirtualQ
{
    public class Round
    {
        int RequiredPlayers;
        string Name { get; set; }
        int QuestionsByPlayer;

        public List<Question> UsedQuestions { get; set; }
        public Player[] Players { get; set; }

        public Round(string name, int players, int question_by_player)
        {
            RequiredPlayers = players;
            Name = name;
            QuestionsByPlayer = question_by_player;
            UsedQuestions = new List<Question>();
        }

        public void AddQuestion(Question UsedQuestion, string UserId)
        {
            UsedQuestions.Add(UsedQuestion);
        }

    }
}
