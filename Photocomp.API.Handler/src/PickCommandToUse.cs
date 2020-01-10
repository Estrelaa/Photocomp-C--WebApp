using System;
using System.Collections.Generic;
using System.Text;

namespace Photocomp.API.Handler
{
    class PickCommandToUse: Common
    {
        public void SelectRightCommand(int DownTheListOfAPICallsInOrder, int id = 0)
        {
            switch (DownTheListOfAPICallsInOrder)
            {
                //GET All images
                case 1:
                    {
                        buildURL("");
                        break;
                    }
                 //upload image
                case 2:
                    {
                        buildURL("");
                        break;
                    }
                //Get random image
                case 3:
                    {
                        buildURL("/random");
                        break;
                    }
                //Get top image
                case 4:
                    {
                        buildURL("/top");
                        break;
                    }
                //Upvote Image
                case 5:
                    {
                        buildURL("/id/" + id + "/vote/up");
                        break;
                    }
                //Downvote Image
                case 6:
                    {
                        buildURL("/id/" + id + "/vote/down");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
