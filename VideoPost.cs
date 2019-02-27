using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace inheritance
{
    class VideoPost:post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;
        //properties
        protected string VideoUrl { get; set; }
        protected int Length { get; set; }
        //call from base class
        public VideoPost() { }

        //specify details not called from base
        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            //The following properties and the GetNextID method are inherited from post
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.VideoUrl = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }
            
        }

        private void TimerCallBack(Object O)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0} seconds", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        //Virtual method override of the ToString method that is Inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} seconds video - by {4}",
                this.ID, this.Title, this.VideoUrl, this.Length, this.SendByUsername);
        }
    }
}
