# Atividade Prática .NET-P003

## Residência em Tecnologia da Informação e Comunicação
### MÓDULO .NB – Formação .Net - Básico

### Objetivo da Atividade
Esta atividade visa aplicar e integrar os conceitos de tuplas, expressões lambda, LINQ e tratamento de exceções em um sistema de gerenciamento de estoque.

**Tempo estimado: 4 horas**

### Descrição
Crie um repositório no GitHub dedicado a esta atividade.

- No seu repositório da disciplina .NET, crie uma nova branch para esta atividade.
- No Moodle, publique o endereço do repositório e a branch onde está trabalhando.
  - Cada Instrução Prática (.NET-PXXX) deve possuir uma branch específica.
  - Identifique cada problema/questão da instrução em pastas ou arquivos específicos.
- Utilize o fórum do Moodle para esclarecer suas dúvidas.

### Objetivo
Desenvolver um sistema de gerenciamento de estoque que emprega os conceitos mencionados.

### Desenvolvimento

#### Produto
- Crie uma tupla representando um produto no estoque, contendo: código do produto, nome do produto, quantidade em estoque e preço unitário.

#### Cadastro de Produtos
- Permita o cadastro de novos produtos no estoque, incluindo código, nome, quantidade e preço.
- Utilize tratamento de exceções para lidar com possíveis erros, como entradas inválidas.

#### Consulta de Produtos
- Implemente uma função que permita buscar um produto pelo código.
  - Se o produto não existir, lance uma exceção personalizada indicando que não foi encontrado.

#### Atualização de Estoque
- Crie funções para atualizar a quantidade em estoque, considerando entradas ou saídas.
- Faça o tratamento para lidar com casos em que a quantidade atual seja insuficiente para uma saída.

#### Relatórios
- Use LINQ para gerar 3 tipos de relatórios:
  1. Lista de produtos com quantidade em estoque abaixo de um limite informado pelo usuário.
  2. Lista de produtos com valor entre um mínimo e um máximo informados pelo usuário.
  3. Informe o valor total do estoque e o valor total de cada produto de acordo com seu estoque.

### Dicas
- Utilize expressões lambda para cálculos específicos, como o valor total em estoque de um produto.
- Implemente consultas LINQ para gerar relatórios personalizados.
- Utilize tratamento de exceções para garantir uma experiência de usuário mais robusta e amigável.

### Referências
- [Tuplas em C#](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtintypes/value-tuples)
- [Expressões Lambda em C#](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/lambda-expressions)
- [Introdução ao LINQ](https://learn.microsoft.com/pt-br/dotnet/csharp/programmingguide/concepts/linq/introduction-to-linq-queries)
- [Tratamento de Exceções em C#](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/exceptions/)


# Autores

| [<img src="https://avatars.githubusercontent.com/u/85597024?s=400&u=a2e62cbd29eecb1443a99a47115f3a8be2695be3&v=4" width=115><br><sub>Ana Caroline </sub>](https://github.com/CarolineNeris) | 
|:-------------------------------------------------------------------------------------------------------------------------------------------------:|
