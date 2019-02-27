using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class VideoPost:post
    {
        public string VideoUrl { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic)
        {
            //The following properties and the GetNextID method are inherited from post
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            //Property ImageURL is a member of ImagePost, but not of post
            this.VideoUrl = videoURL;
        }

        //Virtual method override of the ToString method that is Inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}",
                this.ID, this.Title, this.VideoUrl, this.SendByUsername);
        }
    }
}
