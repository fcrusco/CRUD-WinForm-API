# CRUD - WinForms com Integração via API REST (.NET 8)<br>
<br>
Este projeto demonstra uma aplicação **Windows Forms (.NET 8)** conectada a uma **API RESTful**, que realiza operações de CRUD (Create, Read, Update, Delete) sobre a entidade `Usuario`.<br>
<br>
A solução é composta por:<br>
- ✅ **Projeto WinForms** com uma tela para cadastro, listagem, edição e exclusão de usuários.<br>
- ✅ **API REST em .NET 8**, com autenticação via JWT.<br>
- ✅ **Integração via pacote NuGet**, consumido pelo projeto WinForms.<br>
- ✅ Código limpo, assíncrono (`async/await`), seguro e reutilizável.<br>
<br>
## 🧩 Tecnologias Utilizadas<br>
- .NET 8<br>
- Windows Forms<br>
- ASP.NET Core Web API<br>
- JWT (JSON Web Token)<br>
- HttpClient<br>
- System.Net.Http.Json<br>
- Swagger<br>
- Visual Studio 2022<br>
- NuGet (pacotes próprios e externos)<br>
<br>
## 📂 Estrutura da Solução<br>
/CRUD-WinForm-API<br>
├── CRUD.Model # Classes de domínio (Usuario, LoginModel, etc.)<br>
├── CRUD.Interface # Interfaces dos serviços<br>
├── CRUD.Service # Lógica de negócio / acesso a banco<br>
├── CRUD.API # Projeto da API REST (endpoints, controllers, autenticação)<br>
├── CRUD.Client # Cliente HTTP (HttpClient wrapper) empacotado via NuGet<br>
└── CRUD.WinForms # Interface do usuário (WinForms) que consome a API<br>
<br>
## 🔐 Autenticação<br>
A autenticação na API é realizada via JWT. O login é feito através da rota:<br>
POST /api/auth/login<br>
Body: { "usuario": "Admin", "senha": "Admin" }<br>
O token retornado é incluído automaticamente no `Authorization Header` das chamadas subsequentes pelo `ApiCliente`.<br>
<br>
<br>
## 📦 Integração via NuGet<br>
A API cliente (`UsuarioApiClient`) foi empacotada como um pacote NuGet e adicionada ao projeto WinForms:<br>
var http = new HttpClient { BaseAddress = new Uri("https://localhost:7058") };<br>
var client = new UsuarioApiClient(http);<br>
await client.LoginAsync("Admin", "Admin");<br>
Todas as chamadas como InserirAsync, ListarAsync, AtualizarAsync e DeletarAsync são feitas via HTTP usando esse cliente.<br>
<br>
🖥️ Funcionalidades do WinForms<br>
Listar usuários ao iniciar a aplicação<br>
Inserir novo usuário<br>
Editar dados do usuário existente<br>
Excluir usuário<br>
Integração com API via HttpClient + JWT<br>
Exibição de mensagens em caso de sucesso ou erro<br>
<br>
▶️ Como Executar<br>
Clonar o repositório<br>
git clone https://github.com/seu-usuario/CRUD-WinForm-API.git<br>
Executar o projeto da API (CRUD.API) no Visual Studio<br>
Executar o projeto WinForms (CRUD.WinForms)<br>
O Form fará o login na API, carregará os dados e permitirá CRUD completo.<br>
<br>
📌 Observações<br>
O endereço da API (https://localhost:7058) está hardcoded no WinForms. Em ambiente de produção, recomenda-se mover para um appsettings.json ou Settings.<br>
É possível adicionar logs, tratamento centralizado de exceções e envio de e-mail a partir da API.<br>

