using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


public class PostLocation
{
    [property: JsonPropertyName("post code")]
    public int post_code { get; set; }

    [property: JsonPropertyName("latitude")]
    public double latitude { get; set; }

    [property: JsonPropertyName("longitude")]
    public double longitude { get; set; }

    public override string ToString()
    {
        return $"Post code: {this.post_code} \n Latitude: {this.latitude} \n Longitude: {this.longitude}";
    }

}


