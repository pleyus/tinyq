﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyVirtualQ
{
    public class Contest
    {
        public int Id { get; set; }
        public Round[] Rounds { get; set; }
        public string Name { get; set; }
        public Question[] Questions { get; set; }
        public int AvailableQuestions()
        {
            int i = 0;
            foreach (Question q in Questions)
                i = i + (q.Result == Question.QuestionResult.None ? 1 : 0);
            return i;
        }
        public Contest(int Id, string Name)
        {
            Set(Id, Name);
        }
        public Contest(string Id, string Name)
        {
            int id = 0;
            try
            {
                id = int.Parse(Id);
            }
            catch {  }
            Set(id, Name);
        }
        void Set(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public int RequiredQuestions
        {
            get
            {
                int round_required_questions = 0;
                foreach (Round R in Rounds)
                    round_required_questions += R.RequiredPlayers * R.QuestionsByPlayer;

                return round_required_questions;
            }
        }
        public int RecomendedQuestions
        {
            get { return RequiredQuestions + (int)(RequiredQuestions * 0.5); }
        }
    }
}
