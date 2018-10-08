using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyVirtualQ
{
    public class Player
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PictureFilename { get; set; }
        public List<Question> Questions { get; set; }

        public Player(int Id, string Firstname, string Lastname = "", string Filename = "")
        {
            Set(Id, Firstname, Lastname, Filename);
        }
        public Player(string Id, string Firstname, string Lastname = "", string Filename = "")
        {
            int id = 0;
            try { id = int.Parse(Id); }
            catch { }
            Set(id, Firstname, Lastname, Filename);
        }
        void Set(int Id, string Firstname, string Lastname, string Picture)
        {
            this.Id = Id;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            PictureFilename = Picture;
            Questions = new List<Question>();
        }

        public enum CounterParams { Correct, Normal, NormalCorrects, TieBreak, TieBreakCorrect }
        public int CountQuestions(CounterParams Condition)
        {
            int i = 0;

            foreach (Question Q in Questions)
            {
                if (Condition == CounterParams.Correct)
                {
                    if (Q.Result == Question.QuestionResult.Correct)
                        i++;
                }
                if(Condition == CounterParams.Normal)
                {
                    if (Q.Type == Question.QuestionType.Normal)
                        i++;
                }
                if(Condition == CounterParams.NormalCorrects)
                {
                    if (Q.Type == Question.QuestionType.Normal && Q.Result == Question.QuestionResult.Correct)
                        i++;
                }
                if (Condition == CounterParams.TieBreak)
                {
                    if (Q.Type == Question.QuestionType.TieBreak)
                        i++;
                }
                if (Condition == CounterParams.TieBreakCorrect)
                {
                    if (Q.Type == Question.QuestionType.TieBreak && Q.Result == Question.QuestionResult.Correct)
                        i++;
                }
            }

            return i;
        }
    }
}
