# JackShopV3

Projeto simples em DotNet 7 - CleanArch - um projeto CRUD usando classes ricas e Dto para transporte de dados entre as camadas.

Não é MVC pos nao temos apenas 3 camadas e sim 6 camadas;

1 - WebUI
2 - Api
3 - Application
4 - Domain
5 - Data
6 - CrossCutting

Onde as injecoes de depencia estao na CrossCutting e minha camada de APi só tem acesso a ela (crosscutting), evitando expor meus dados e dominio aos meus clientes;

Obs.: Acabei nao implementando as validacoes no na minha camada de dominio, por ter considerado esse projeto de aula como concluido. Afinal eh um projeto de aula.

Mas no projeto real, JAMAIS se esqueça que validaçoes e regras de negocio sao definidas no dominio para seguir oq recomenda o DDD.

Os dados são tranportados todos por Dtos desde os meus repositorios ate o front. Nao implementei o CQRS nesse projeto de estudo, pois as aulas estavam usando o MediatR e quero agora continuar o projeto fazendo o CQRS na unha, sem uso de frameworks de terceiros pelo desempenho e para nao ficar dependente de 1 fornecedor de framework que amanha ou depois pode simplesmente descontinuar o produto.

estou usando tb o padrao Unit of Work para controlar a gravação dos dados com menos problemas de "lixo" na minha base MySql. Não sou especialista em frontEnd por isso o meu front eh tao pobre.

projeto de aula desenvolvido por Marcoratti (excelente professor). Agradeco pelas aulas fundamentais em C# e Dotnet
