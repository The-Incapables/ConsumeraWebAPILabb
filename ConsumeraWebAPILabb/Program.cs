using System.Text;
using System.Text.Json;
using System.Net.Http.Json;
using HttpClient client = new()
{
    BaseAddress = new Uri("https://api.github.com/orgs/dotnet/repos")
};

Console.WriteLine("Retrieve Post");
var post = await GetPostAsync(client);


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{post[i]}\n");
}


static async Task<List<Post>> GetPostAsync(HttpClient client)
{
    await using Stream stream = await client.GetStreamAsync("posts");
    var result = await JsonSerializer.DeserializeAsync<List<Post>>(stream);

    return result ?? new();
}



static async Task<Post> SendPostAsync(HttpClient client, Post post)
{
    string jsonString = JsonSerializer.Serialize(post);
    HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
    var response = await client.PostAsync("/posts", content);

    response.EnsureSuccessStatusCode();
    var result = await response.Content.ReadFromJsonAsync<Post>();
    return result;
}