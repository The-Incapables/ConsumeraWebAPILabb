using System.Text;
using System.Text.Json;
using System.Net.Http.Json;
using HttpClient client = new()
{
    BaseAddress = new Uri("https://api.github.com/orgs/dotnet/repos")
};

using HttpClient clientPost = new()
{
    BaseAddress = new Uri("https://api.zippopotam.us/US/07645")
};

client.DefaultRequestHeaders.Add("User-Agent", "MyGitHubApp");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Retrieve Post G Part");
Console.ResetColor();

var post = await GetPostsAsync(client);


foreach (var item in post.Take(5))
{
    Console.WriteLine($"{item}\n");
}


static async Task<List<Post>> GetPostsAsync(HttpClient client)
{   

    await using Stream stream = await client.GetStreamAsync("repos");
    var result = await JsonSerializer.DeserializeAsync<List<Post>>(stream);

    return result ?? new();
}
//-------------------------------------------------------------------------------------------------------------

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Retrieve Post VG Part");
Console.ResetColor();

var postLocation = await GetPostAsync(clientPost);

foreach (var item in postLocation)
{
    Console.WriteLine($"{item}\n");
}
static async Task<List<PostLocation>> GetPostAsync(HttpClient clientPost)
{
    
    await using Stream streamPost = await clientPost.GetStreamAsync("07645");
    var resultPost = await JsonSerializer.DeserializeAsync<List<PostLocation>>(streamPost);

    return resultPost ?? new();
}

