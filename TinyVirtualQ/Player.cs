using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyVirtualQ
{
    public class Player
    {
        public string Firstname;
        public string Lastname;
        public string PictureFilename;

        public Player(string firstname, string lastname = "", string filename = "")
        {
            Firstname = firstname;
            Lastname = lastname;
            PictureFilename = filename;
        }
    }
}
