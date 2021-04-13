using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace Minnow
{
    static class YouTubeManager
    { 
        public static void GetYouTubeVideo(string url)
        {
            YouTube youtube = YouTube.Default;
            var videos = Client.For(YouTube.Default).GetAllVideosAsync(url).GetAwaiter().GetResult();

            var test = videoInfos;
        }


    }
}
