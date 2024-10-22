using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WLED
{

    

    class JsonApiResponseParser
    {
        public static JsonApiResponse ParseApiResponse(string json)
        { 
            if (json == null) return null;
            try
            {
            JsonApiResponse resp = JsonSerializer.Deserialize<JsonApiResponse>(json);
                return resp;
            }
            catch (global::System.Exception)
            {

            }
            return null;
        }
        
    }
}
