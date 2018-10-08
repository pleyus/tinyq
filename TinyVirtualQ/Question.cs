using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TinyVirtualQ
{
    public class Question
    {
        public enum QuestionResult { None, Correct, Wrong };

        public int Id { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public string Answer { get; set; }
        public QuestionResult Result { get; set; }

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

        public Question(int Id, string Text, string Category, string Answer, QuestionResult Result)
        {
            Set(Id, Text, Category, Answer, Result);
        }
        public Question(string Id, string Text, string Category, string Answer, string Result)
        {
            int id = 0;
            QuestionResult result = QuestionResult.None;
            try
            {
                id = int.Parse(Id);
                result = (QuestionResult)int.Parse(Result);
            }
            catch { }
            Set(id, Text, Category, Answer, result);
        }
        void Set(int Id, string Text, string Category, string Answer, QuestionResult Result)
        {
            this.Id = Id;
            this.Text = Text;
            this.Category = Category;
            this.Answer = Answer;
            this.Result = Result;
        }

    }

}
