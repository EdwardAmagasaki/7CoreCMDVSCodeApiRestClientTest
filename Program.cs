using System.Net.Http;
using System.Net.Http.Headers;

var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Post,
    RequestUri = new Uri("https://localhost:44328/token"),
    Headers =
    {
        { "Accept", "*/*" },
    },
    Content = new StringContent("grant_type=password&username=amagasaki.edward%40gmail.com&password=Edw%40123")
    {
        Headers =
        {
            ContentType = new MediaTypeHeaderValue("text/plain")
        }
    }
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}