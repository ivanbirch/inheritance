using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class post
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        public string Title { get; set; }
        protected string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        //default constructor. If a derived class does not invoke a base class explicitly
        //the default costructor is called implicity
        public post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Ivan Birch";
        }

        //Instance constructor with 3 parameters
        public post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //Virtual method override of the ToString method that is Inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
