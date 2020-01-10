using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Photocomp.API.Handler
{
    class ParseResponse
    {
        public PictureAndMetaData ParseJson(string ContentOfJson)
        {
            var meta = JsonConvert.DeserializeObject<PictureAndMetaData>(ContentOfJson);
            return meta;
        }
    }
}
