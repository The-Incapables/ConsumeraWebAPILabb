using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;




public class Post
{
    [property: JsonPropertyName("Name")]
    public int Name { get; set; }

    [property: JsonPropertyName("Description")]
    public int Description { get; set; }

    [property: JsonPropertyName("HTML_URL")]
    public string HTML_URL { get; set; }

    [property: JsonPropertyName("Homepage")]
    public string Homepage { get; set; }

    [property: JsonPropertyName("Watchers")]
    public string Watchers { get; set; }

    [property: JsonPropertyName("Pushed_at")]
    public string Pushed_at { get; set; }
    public override string ToString()
    {
        return $"Post Name:{this.Name} \n Description:{this.Description}, \n HTML_URL:{this.HTML_URL}," +
            $" \n Homepage:{this.Homepage},  \n Watchers:{this.Watchers},  \n Pushed_at:{this.Homepage}";
    }

}


