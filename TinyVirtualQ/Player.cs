using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyVirtualQ
{
    public class Player
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PictureFilename { get; set; }
        public List<Question> Questions { get; set; }
        

        public Player(string firstname, string lastname = "", string filename = "")
        {
            Firstname = firstname;
            Lastname = lastname;
            PictureFilename = filename;
            Questions = new List<Question>();
        }
        public Player(string firstname, Question[] questions)
        {
            Firstname = firstname;
            Questions.AddRange(questions);
            Lastname = "";
            PictureFilename = "";
        }
    }
}
