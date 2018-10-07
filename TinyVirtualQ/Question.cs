using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TinyVirtualQ
{
    public class Question
    {
        public enum QuestionResult { None, Correct, Wrong };
        public string Id;
        public string Text;
        public string Category;
        public QuestionResult Result;

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
        public Question(string QuestionText, string QuestionCategory)
        {
            Text = QuestionText;
            Category = QuestionCategory;
            Result = QuestionResult.None;
        }
        public Question(string id, string text, string category, QuestionResult result)
        {
            Id = id;
            Text = text;
            Category = category;
            Result = result;
        }
        public static Question[] FromFile(string Filename)
        {
            List<Question> QList = new List<Question>();
            if (File.Exists(Filename))
            {
                foreach (string linea in File.ReadAllLines(@"questions.db"))
                {
                    string[] campos = linea.Split(new string[] { "[&x]" }, StringSplitOptions.RemoveEmptyEntries);
                    if (campos.Length > 2)
                        QList.Add(new Question(campos[0], campos[1], campos[2], Question.QuestionResult.None));
                }
            }
            return QList.ToArray();
        }
    }

}
