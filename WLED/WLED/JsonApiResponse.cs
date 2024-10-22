using System;
using Xamarin.Forms;
using System.Text;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace WLED
{

    class JsonUsermodWled
    {
        [JsonPropertyName("Battery level")]
        public List<object> BatteryLevel { get; set; }
    }

    class JsonApiResponse
	{
        [JsonPropertyName("u")]
        public JsonUsermodWled Usermods { get; set; }
        [JsonPropertyName("ver")]
        public String version { get; set; }
    }
    
}
