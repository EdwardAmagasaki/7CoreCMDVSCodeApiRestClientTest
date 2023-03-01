

# netCoreHttpClientApiTokenJWT

Autenticando uma aplicação de linha de comando com o VSCode .NET Core 7 com uma WebApi2 ASP.NET com Identity Framework & .NET HttpClient

Desenvolvimento da WebApi 2 ASP.NET nesse link:

Tela com o resultado de nosso teste com a extensão RAPIDAPI do VSCode:

![Imagem 1](./img/img1.png "Imagem 1 desenvolvimento")
![Imagem 1](./img/img3.png "Imagem 1 desenvolvimento")
![Imagem 1](./img/img2.png "Imagem 1 desenvolvimento")

![Imagem 1](./img/img4.png "Imagem 1 desenvolvimento")

Através do Rest Client, e nosso primeiro teste obtendo o token JWT de acesso, podemos utilizar uma sujestão para o código desejado. No nosso caso, estaremos utilizando a biblioteca .NET HttpClient.

```
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
    Content = new StringContent("grant_type=password&username=amagasaki.edward%40gmail.com&password=suaSenh@")
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
```
Após implementação no arquivo Program.cs , obtemnos o resultado solicitado pelo código onde em: Console.WriteLine(body); obtemos o resultado consurme a imagem abaixo:

![Imagem 1](./img/img6.png "Imagem 1 desenvolvimento")
