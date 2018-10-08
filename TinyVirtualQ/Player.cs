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
    }
}
