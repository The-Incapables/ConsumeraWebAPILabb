using System.Text;
using System.Text.Json;
using System.Net.Http.Json;
using HttpClient client = new()
{
    BaseAddress = new Uri("https://api.github.com/orgs/dotnet/repos")
};

client.DefaultRequestHeaders.Add("User-Agent", "MyGitHubApp");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Retrieve Post");
Console.ResetColor();

var post = await GetPostAsync(client);


foreach (var item in post)
{
    Console.WriteLine($"{item}\n");
}



static async Task<List<Post>> GetPostAsync(HttpClient client)
{   

    await using Stream stream = await client.GetStreamAsync("repos");
    var result = await JsonSerializer.DeserializeAsync<List<Post>>(stream);

    return result ?? new();
}



