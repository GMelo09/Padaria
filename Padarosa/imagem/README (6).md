
#  Descrição

projetado para otimizar as operações diárias de estabelecimentos do setor. Ele simplifica o controle de comandas, produtos, usuários e operações de caixa, oferecendo uma interface intuitiva e amigável, com validações rigorosas para garantir a integridade dos dados. O sistema suporta diferentes níveis de acesso, permitindo que administradores gerenciem configurações avançadas, enquanto usuários comuns realizam tarefas operacionais com facilidade, promovendo uma gestão organizada e fluida.

![Padarosa](Padarosa/imagem/login.png)
![Padarosa](Padarosa/imagem/menu.png)
![Padarosa](Padarosa/imagem/produtos.png)
![Padarosa](Padarosa/imagem/Comandas.png)
![Padarosa](Padarosa/imagem/produto.png)
![Padarosa](Padarosa/imagem/usuarios.png)

## Funcionalidades

O sistema capacita a gestão eficiente de uma padaria por meio de autenticação segura com validação rigorosa de e-mail e senha para proteger o acesso, gerenciamento completo de usuários com funcionalidades de cadastro, edição e exclusão restritas a administradores (Id = 1), administração detalhada de produtos com suporte para associação a categorias e validações para garantir dados consistentes, lançamento intuitivo de produtos em comandas com controle preciso de quantidades e acompanhamento em tempo real, operações de caixa que permitem consultar comandas por número de ficha, exibir totais calculados automaticamente e encerrar transações com confirmação de pagamento, além de proporcionar uma interface fluida com mensagens claras de erro e sucesso para orientar o usuário e melhorar a experiência de uso
## Estrutura do Projeto

O projeto está organizado com um arquivo .gitattributes para normalização de arquivos de texto no Git, um arquivo de solução Padarosa.sln para o Visual Studio, e os principais formulários: Form1.cs para autenticação de usuários via login, FormMenuPrincipal.cs para o menu principal com opções restritas por nível de acesso, FrmGestaoUsuarios.cs para gerenciamento de usuários com funcionalidades de cadastro, edição e exclusão, FrmGestaoProdutos.cs para gerenciamento de produtos com suporte a categorias, FrmComandas.cs para lançamento de produtos em comandas, FrmCaixa.cs para operações de consulta e encerramento de comandas no caixa, e Program.cs como ponto de entrada da aplicação. As classes no namespace Model (Usuario.cs, Produto.cs, Categoria.cs, OrdemComanda.cs) gerenciam a manipulação de dados, interagindo com o banco de dados para operações de leitura e escrita. Além disso, o projeto inclui arquivos de configuração do Visual Studio, como .csproj, para gerenciamento de dependências e compilação, e pastas adicionais como Properties para configurações do aplicativo e Resources para eventuais arquivos de recursos, como ícones e imagens.