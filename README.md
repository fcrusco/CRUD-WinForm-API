# CRUD - WinForms com Integração via API REST (.NET 8)

Este projeto demonstra uma aplicação **Windows Forms (.NET 8)** conectada a uma **API RESTful**, que realiza operações de CRUD (Create, Read, Update, Delete) sobre a entidade `Usuario`.

A solução é composta por:
- ✅ **Projeto WinForms** com uma tela para cadastro, listagem, edição e exclusão de usuários.
- ✅ **API REST em .NET 8**, com autenticação via JWT.
- ✅ **Integração via pacote NuGet**, consumido pelo projeto WinForms.
- ✅ Código limpo, assíncrono (`async/await`), seguro e reutilizável.

## 🧩 Tecnologias Utilizadas
- .NET 8
- Windows Forms
- ASP.NET Core Web API
- JWT (JSON Web Token)
- HttpClient
- System.Net.Http.Json
- Swagger
- Visual Studio 2022
- NuGet (pacotes próprios e externos)

## 📂 Estrutura da Solução
/CRUD-WinForm-API
├── CRUD.Model # Classes de domínio (Usuario, LoginModel, etc.)
├── CRUD.Interface # Interfaces dos serviços
├── CRUD.Service # Lógica de negócio / acesso a banco
├── CRUD.API # Projeto da API REST (endpoints, controllers, autenticação)
├── CRUD.Client # Cliente HTTP (HttpClient wrapper) empacotado via NuGet
└── CRUD.WinForms # Interface do usuário (WinForms) que consome a API

## 🔐 Autenticação
A autenticação na API é realizada via JWT. O login é feito através da rota:
POST /api/auth/login
Body: { "usuario": "Admin", "senha": "Admin" }
O token retornado é incluído automaticamente no `Authorization Header` das chamadas subsequentes pelo `ApiCliente`.


## 📦 Integração via NuGet
A API cliente (`UsuarioApiClient`) foi empacotada como um pacote NuGet e adicionada ao projeto WinForms:
var http = new HttpClient { BaseAddress = new Uri("https://localhost:7058") };
var client = new UsuarioApiClient(http);
await client.LoginAsync("Admin", "Admin");
Todas as chamadas como InserirAsync, ListarAsync, AtualizarAsync e DeletarAsync são feitas via HTTP usando esse cliente.

🖥️ Funcionalidades do WinForms
Listar usuários ao iniciar a aplicação
Inserir novo usuário
Editar dados do usuário existente
Excluir usuário
Integração com API via HttpClient + JWT
Exibição de mensagens em caso de sucesso ou erro

▶️ Como Executar
Clonar o repositório
git clone https://github.com/seu-usuario/CRUD-WinForm-API.git
Executar o projeto da API (CRUD.API) no Visual Studio
Executar o projeto WinForms (CRUD.WinForms)
O Form fará o login na API, carregará os dados e permitirá CRUD completo.

📌 Observações
O endereço da API (https://localhost:7058) está hardcoded no WinForms. Em ambiente de produção, recomenda-se mover para um appsettings.json ou Settings.
É possível adicionar logs, tratamento centralizado de exceções e envio de e-mail a partir da API.

