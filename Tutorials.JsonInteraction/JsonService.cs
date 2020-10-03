using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tutorials.JsonInteraction
{
    public class JsonService
    {

        public static void ReadJsonFile(string jsonFileIn)
        {

            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(jsonFileIn));

            Console.WriteLine($"Today's Video is: {jsonFile["today_video"]}");

            Console.WriteLine($"Today's video is about: {jsonFile["video_information"]["title"]}");

            JToken VideoTitle = jsonFile.SelectToken("video_information.creator");
            JToken VideoPurpose = jsonFile.SelectToken("video_information.purpose");

            Console.WriteLine($"Creator's Name: {VideoTitle}");
            Console.WriteLine($"Purpose of this video: {VideoPurpose}");


        }


    }
}
