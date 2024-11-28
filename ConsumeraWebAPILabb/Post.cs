using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


public class Post
{
    [property: JsonPropertyName("Name")]
    public string name { get; set; }

    [property: JsonPropertyName("Description")]
    public string description { get; set; }

    [property: JsonPropertyName("HTML_URL")]
    public string html_url { get; set; }

    [property: JsonPropertyName("Homepage")]
    public string homepage { get; set; }

    [property: JsonPropertyName("Watchers")]
    public string watchers { get; set; }

    [property: JsonPropertyName("Pushed_at")]
    public string pushed_at { get; set; }
    public override string ToString()
    {
        return $"Post Name:{this.name} \n Description:{this.description} \n HTML_URL:{this.html_url}" +
            $" \n Homepage:{this.homepage}  \n Watchers:{this.watchers}  \n Pushed_at:{this.homepage}";
    }

}


