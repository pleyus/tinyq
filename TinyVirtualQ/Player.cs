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

        public enum CounterParams { Correct, Normal, NormalCorrects, TieBreak, TieBreakCorrect, NormalWrong, TieBreakWrong }
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
                if (Condition == CounterParams.TieBreakWrong)
                {
                    if (Q.Type == Question.QuestionType.TieBreak && Q.Result == Question.QuestionResult.Wrong)
                        i++;
                }
                if (Condition == CounterParams.NormalWrong)
                {
                    if (Q.Type == Question.QuestionType.Normal && Q.Result == Question.QuestionResult.Wrong)
                        i++;
                }
            }

            return i;
        }

        /// <summary>
        /// Devuelve el numero de preguntas del jugador, filtrando segun los resultado y el tipo
        /// </summary>
        /// <param name="ResultIs">Si es None, se interpreta como todas</param>
        /// <param name="TypeIs">Tipo de pregunta</param>
        /// <param name="RoundId">Id de la ronda, si no se pone, se obtiene de todas las tondas</param>
        /// <returns></returns>
        public int CountQuestions(Question.QuestionResult ResultIs, Question.QuestionType TypeIs, int RoundId = 0)
        {
            string sql = "SELECT PlayerId FROM used_questions WHERE PlayerID = " + Id +
                (RoundId > 0 ? " AND RoundId = " + RoundId : "") +
                (ResultIs == Question.QuestionResult.None ? "" : " AND Result = " + (int)ResultIs) + 
                " AND Type = " + (int)TypeIs;

            return DataBase.Select(sql).Count;
        }
        public Question GetCurrentQuestion()
        {
            foreach (Question q in Questions)
                if (q.Result == Question.QuestionResult.None)
                    return q;

            return null;
        }
    }
}
