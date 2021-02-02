# CalculaJuros
Para rodar o projeto em teste com <strong>https</strong> use um certificado autoassinado, para isso rode o comando <strong>dotnet dev-certs https --trust</strong>.
<br>
A api <strong>CalculaJuros</strong> tem uma dependência com a api <strong>TaxaJuros</strong>.
<br>
Para configurar a url da api <strong>TaxaJuros</strong> use a variável <strong>UrlTaxaJuros</strong> que fica no arquivo appsettings.json.
<br>
Para rodar o teste de integração com êxito é preciso que o arquivo appsettings esteja no bin da aplicação.
