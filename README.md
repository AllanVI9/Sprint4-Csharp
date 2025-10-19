# Biblioteca API

API REST para gerenciamento de livros com ASP.NET Core.

<img width="1301" height="896" alt="GetUsers" src="https://github.com/user-attachments/assets/5948cae2-9bae-4556-ae43-c6e94ce2f9ee" />

<img width="1074" height="920" alt="criandoUser" src="https://github.com/user-attachments/assets/2567125d-e918-4fb8-95fe-8aceeee207f1" />

<img width="1286" height="857" alt="BuscandoPorID" src="https://github.com/user-attachments/assets/2f2817f0-82ea-4756-bad5-a206ed96ab3e" />


## Membros do grupo:

\- Allan Von Ivanov - RM98705 

\- Bianca Carvalho Dancs Firsoff - RM551645

\- João Rodrigo Solano Nogueira - RM551319

\- Giuliano Romaneto Marques - RM99694

\- Arthur Candido de Abreu - RM98283


## Funcionalidades



\- CRUD completo de livros

\- Filtros com LINQ (por autor, gênero)

\- Integração com Google Books API

\- Publicado na cloud via Render: https://dashboard.render.com/web/srv-d3qjcpc9c44c73cqouf0/deploys/dep-d3qjcpk9c44c73cqouog

<img width="1541" height="578" alt="Render" src="https://github.com/user-attachments/assets/c7c90158-4f08-43c4-a8bc-9ef7ca5c6bd6" />



## Como rodar



1\. `dotnet restore`

2\. `dotnet ef database update`

3\. `dotnet run`



## Documentação Swagger

Após rodar o projeto, abrir o swagger no caminho: http://localhost:5128/swagger/index.html

Disponível em: `/swagger`

Tire o `id` do body para funcionar o post



## API externa



Integração com \[Google Books API](https://developers.google.com/books/docs/v1/using)






