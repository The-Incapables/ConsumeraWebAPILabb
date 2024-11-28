using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


public class PostLocation
{
    [JsonPropertyName("post code")]
    public string post_code { get; set; }

    [JsonPropertyName("places")]
    public List<Place> Places { get; set; }  // List of Place objects

    public override string ToString()
    {
        if (Places != null && Places.Count > 0)
        {
            var place = Places[0];  // Get the first place from the list
            return $"Post code: {this.post_code} \nLatitude: {place.Latitude} \nLongitude: {place.Longitude}";
        }
        return $"Post code: {this.post_code} \nNo places available";
    }
}

public class Place
{
    [JsonPropertyName("latitude")]
    public string Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string Longitude { get; set; }
}

