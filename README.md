# JackShopV3

Projeto simples em DotNet 7 - CleanArch - um projeto CRUD usando classes ricas e Dto para transporte de dados entre as camadas.

Não é MVC pos nao temos apenas 3 camadas e sim 6 camadas;

1 - WebUI
2 - Api
3 - Application
4 - Domain
5 - Data
6 - CrossCutting

Onde as injecoes de dependencia estao na CrossCutting e minha camada de APi só tem acesso a ela (crosscutting), evitando expor meus dados e dominio aos meus clientes;

projeto esta totalmente desacoplado, bastando mudar o framework usado no meu caso adoro o EF, mas o desenvolevedor pode usar um Dapper por exemple..ou mesmo um DAO com poucas mudanças tanto no código, quanto na base de dados utilizada, que no meu caso esta sendo o MySql, pois considero mais "leve" para rodar na minha maquina pessoal (não gosto do SQLExpress) ainda considero pesado para ser um "Express"

Obs.: Acabei nao implementando as validacoes no na minha camada de dominio, por ter considerado esse projeto de aula como concluido. Afinal eh um projeto de aula.

Mas no projeto real, JAMAIS se esqueça que validaçoes e regras de negocio sao definidas no dominio para seguir oq recomenda o DDD.

Os dados são tranportados todos por Dtos desde os meus repositorios ate o front. Nao implementei o CQRS nesse projeto de estudo, pois as aulas estavam usando o MediatR e quero agora continuar o projeto fazendo o CQRS na unha, sem uso de frameworks de terceiros pelo desempenho e para nao ficar dependente de 1 fornecedor de framework que amanha ou depois pode simplesmente descontinuar o produto.

Estou usando o AutoMapper apenas para mostrar como é simples a implementação do mesmo, mas lembro que é perfeitamente possivel trabahar com Dtos s/ AutoMapper. Outra tecnica que estou usando é jogar os dados de retorno para a APi / WebUI em classes RECORD, alem de simples e rapidas, elas tem a grande vantagem de ser imutaveis. Ou seja jogou os dados la..eles nao mudarao até a proxima instancia das mesmas.

estou usando tb o padrao Unit of Work para controlar a gravação dos dados com menos problemas de "lixo" na minha base MySql. Não sou especialista em frontEnd por isso o meu front eh tao pobre.

projeto base da minha aula desenvolvido por Marcoratti (excelente professor). Por minha conta foram agregadas algumas funcionalidades que considero melhores e o tema da aula tb foi substituido. De uma simples papelaria para um produto do mundo real extremamente conhecido como o Whiskey Jack Daniels. 

Agradeco pelas aulas fundamentais em C# e Dotnet(apesar de muitas aulas ainda serem em DotNet 5, 6 ate msm 3) onde hoje estamos usando Net 7(100% estavel) e em pouco tempo chega o Net 8 LTS. 

Muitos professores insistem nas plataformas muito desatualizas, até msm ja sem suporte como é o caso do Net 5 e anteriores
