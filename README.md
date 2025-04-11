<h1>Questão 1</h1>

No .NET MAUI, a injeção de dependência é feita na classe MauiProgram, dentro do método CreateMauiApp(). Esse recurso permite que as classes recebam automaticamente os objetos de que precisam, deixando o código mais organizado e fácil de manter.

Nesse projeto, usamos builder.Services.AddSingleton<TInterface, TImplementacao>() para registrar os serviços como singleton, ou seja, a mesma instância será usada enquanto o app estiver rodando.

Entre os serviços registrados estão:

<b>Repositório de contatos:</b> a interface IRepositorioDeContatos é associada à implementação RepositorioContatosSqlLite, que é responsável por salvar e buscar os dados no banco SQLite.

<b>Casos de uso (Use Cases):</b> foram adicionadas as interfaces IVisualizarContatosUseCase, IApagarContatoUseCase, IAdicionarContatoUseCase e IEditarContatoUseCase, com suas implementações correspondentes. Essas classes cuidam da lógica de negócio relacionada aos contatos.

<b>Páginas da aplicação:</b> também registramos as páginas ContatosPage, EditarContatoPage e AdicionarContatoPage, permitindo que elas recebam as dependências automaticamente.


No MAUI, depois que os serviços são registrados, eles podem ser injetados direto nos construtores das classes. Por exemplo, quando a ContatosPage for criada, o MAUI já sabe quais dependências ela precisa e entrega tudo pronto. Isso evita a necessidade de criar os objetos manualmente e deixa o código mais limpo, reutilizável e fácil de testar.
