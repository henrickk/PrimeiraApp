# PrimeiraApp

PrimeiraApp é um projeto de exemplo desenvolvido seguindo o curso **Fundamentos do ASP.NET MVC** da [Desenvolvedor.io](https://desenvolvedor.io). Este projeto utiliza ASP.NET Core Razor Pages e demonstra a criação, edição, visualização e exclusão de registros de alunos.

## Funcionalidades

- Listar alunos
- Adicionar novo aluno
- Editar aluno existente
- Visualizar detalhes do aluno
- Excluir aluno

## Estrutura do Projeto

- **Controllers**: Contém os controladores que gerenciam as requisições HTTP.
  - `AlunosController.cs`: Controlador responsável pelas operações CRUD dos alunos.
- **Models**: Contém as classes de modelo que representam os dados da aplicação.
  - `Aluno.cs`: Modelo que representa um aluno.
- **Views**: Contém as páginas Razor que renderizam a interface do usuário.
  - `Alunos/Create.cshtml`: Página para criar um novo aluno.
  - `Alunos/Edit.cshtml`: Página para editar um aluno existente.
  - `Alunos/Details.cshtml`: Página para visualizar os detalhes de um aluno.
  - `Alunos/Index.cshtml`: Página para listar todos os alunos.
- **Data**: Contém a classe de contexto do banco de dados.
  - `AppDbContext.cs`: Contexto do banco de dados que gerencia a conexão e as operações com o banco de dados.

## Requisitos

- .NET 9.0
- Visual Studio 2022

## Configuração

1. Clone o repositório:

2. Navegue até o diretório do projeto:

3. Restaure as dependências do projeto:

4. Atualize o banco de dados:

5. Execute o projeto:

## Uso

1. Acesse `http://localhost:5000/Alunos` no seu navegador.
2. Utilize a interface para adicionar, editar, visualizar e excluir alunos.

## Curso

Este projeto foi desenvolvido seguindo o curso da [Desenvolvedor.io](https://desenvolvedor.io). O curso aborda os seguintes tópicos:

- Introdução ao ASP.NET Core
- Criação de projetos Razor Pages
- Configuração do Entity Framework Core
- Operações CRUD com Razor Pages
- Validação de dados
- Boas práticas de desenvolvimento

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

   
