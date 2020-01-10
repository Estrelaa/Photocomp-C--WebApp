using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

namespace Photocomp
{
    class API: Common
    {
        public PictureAndMetaData SelectRightCommand(int DownTheListOfAPICallsInOrder, int id = 0)
        {
            switch (DownTheListOfAPICallsInOrder)
            {
                //GET All images
                case 1:
                    {
                        return RunAllFunctionsToCallServer("");
                    }
                //upload image
                case 2:
                    {
                        return RunAllFunctionsToCallServer("");
                    }
                //Get random image
                case 3:
                    {
                        return RunAllFunctionsToCallServer("/random");
                    }
                //Get top image
                case 4:
                    {
                        return RunAllFunctionsToCallServer("/top");
                    }
                //Upvote Image
                case 5:
                    {
                        return RunAllFunctionsToCallServer("/id/" + id + "/vote/up", "POST");
                    }
                //Downvote Image
                case 6:
                    {
                        return RunAllFunctionsToCallServer("/id/" + id + "/vote/down", "POST");
                    }
                default:
                    {
                        //return a blank object
                        return new PictureAndMetaData();
                    }
            }
        }

        public string CallToServer(string URL, string requestType)
        {
            var client = new RestClient();
            var request = new RestRequest(URL, DataFormat.Json);
            IRestResponse response;

            if (requestType == "POST")
            {
                response = client.Post(request);
            }
            else
            {
                response = client.Get(request);
            }

            return response.Content;
        }

        public PictureAndMetaData ParseJson(string ContentOfJson)
        {
            return JsonConvert.DeserializeObject<PictureAndMetaData>(ContentOfJson);
        }

        private PictureAndMetaData RunAllFunctionsToCallServer(string path, string requestType = "GET")
        {
            return ParseJson(
                CallToServer(
                buildURL(path), requestType));
        }

    }
}
