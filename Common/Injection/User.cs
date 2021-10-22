using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Injection
{
    public class User
    {
        private int id;
        private string name;
        private string title;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Title1{ get => title; set => title = value; }

        public User()
        {
            id = 1;
            name = "Bob Morane";
            title = "L'aventurier";
        }
    }
}
