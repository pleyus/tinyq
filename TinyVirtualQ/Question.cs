using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyVirtualQ
{
    public class Question
    {
        public enum QuestionResult { None, Correct, Wrong };
        public string Text;
        public string Category;
        public QuestionResult Result;

        public Question(string QuestionText, string QuestionCategory)
        {
            Text = QuestionText;
            Category = QuestionCategory;
            Result = QuestionResult.None;
        }
    }
}
