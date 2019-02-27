using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    // IMagePost derives from post and adds a property(ImageUrl) and two constructors
    class ImagePost:post
    {
        public string ImageUrl { get; set; }

        //will be called implicitly
        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            //The following properties and the GetNextID method are inherited from post
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            //Property ImageURL is a member of ImagePost, but not of post
            this.ImageUrl = imageURL;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageUrl, this.SendByUsername);
        }
    }
}
