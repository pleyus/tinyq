using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TinyVirtualQ
{
    public class Question
    {
        public enum QuestionResult { None, Correct, Wrong };
        public enum QuestionType { Normal, TieBreak };

        public int Id { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public string Answer { get; set; }
        public QuestionResult Result { get; set; }
        public QuestionType Type { get; set; }

        public static Question Current(Question[] Questions)
        {
            foreach (Question q in Questions)
                if (q.Result == QuestionResult.None)
                    return q;
            return null;
        }
        public static Question Current(List<Question> Questions)
        {
            return Current(Questions.ToArray());
        }

        public Question(int Id, string Text, string Category, string Answer, QuestionResult Result, QuestionType Type)
        {
            Set(Id, Text, Category, Answer, Result, Type);
        }
        public Question(string Id, string Text, string Category, string Answer, string Result, string Type)
        {
            int id = 0;
            QuestionResult result = QuestionResult.None;
            QuestionType type = QuestionType.Normal;
            try
            {
                id = int.Parse(Id);
                result = (QuestionResult)int.Parse(Result);
                type = (QuestionType)int.Parse(Type);
            }
            catch { }
            Set(id, Text, Category, Answer, result, type);
        }
        void Set(int Id, string Text, string Category, string Answer, QuestionResult Result, QuestionType Type)
        {
            this.Id = Id;
            this.Text = Text;
            this.Category = Category;
            this.Answer = Answer;
            this.Result = Result;
            this.Type = Type;
        }

    }

}
