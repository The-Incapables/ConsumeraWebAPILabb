using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


public class Post
{
    [property: JsonPropertyName("name")]
    public string name { get; set; }

    [property: JsonPropertyName("description")]
    public string description { get; set; }

    [property: JsonPropertyName("html_url")]
    public string html_url { get; set; }

    [property: JsonPropertyName("homepage")]
    public string homepage { get; set; }
    
    [property: JsonPropertyName("watchers")]
    public int watchers { get; set; }

    [property: JsonPropertyName("pushed_at")]
    
    public DateTime pushed_at { get; set; }
    public override string ToString()
    {
        return $"Name: {this.name} \n Description: {this.description} \n HTML_URL: {this.html_url}" +
            $" \n Homepage: {this.homepage}  \n Watchers: {this.watchers}  \n Pushed_at: {this.pushed_at}";
    }
}


