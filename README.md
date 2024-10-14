# Banco de Dados - Senac

## **Categorias de BD**

Os bancos de dados podem ser categorizados de várias maneiras, sendo que uma das principais delas aponta para a sua arquitetura, a qual pode ser centralizada, descentralizada, distribuída e replicada.

## **Tipagens de Dados mais utilizados**
=====================================

`int` - númerico inteiro
`char` ou `varchar` - string (letras e números)
`decimal` - número com casa (bom para valores em reais)
`float` ou `double` - númerico com casas decimais
`date` - data
`datetime` - data e hora
`bool` - valor lógico (sim/não)
`bolean` - verdadeiro ou falso

---

### 1. `IDENTITY`
- **Função**: É utilizado para criar uma coluna que gera automaticamente um valor exclusivo para cada nova linha inserida. Isso é comum em colunas que funcionam como chaves primárias.
- **Exemplo**: `id_usuario INT PRIMARY KEY IDENTITY(1,1)` significa que `id_usuario` é uma coluna do tipo inteiro que será incrementada automaticamente a cada nova inserção, começando em 1.

### 2. `NOT NULL`
- **Função**: Esta restrição garante que uma coluna não pode ter valores nulos. Em outras palavras, é obrigatório fornecer um valor para essa coluna ao inserir uma nova linha.
- **Exemplo**: `nome VARCHAR(100) NOT NULL` significa que a coluna `nome` não pode ser deixada em branco; um valor deve ser fornecido.

### 3. `UNIQUE`
- **Função**: Garante que todos os valores em uma coluna sejam diferentes entre si. Isso impede a duplicação de dados nessa coluna.
- **Exemplo**: `email VARCHAR(100) UNIQUE NOT NULL` significa que o valor do `email` deve ser exclusivo para cada registro, e não pode ser nulo.

### 4. `DEFAULT`
- **Função**: Define um valor padrão que será atribuído a uma coluna quando uma nova linha é inserida e nenhum valor explícito for fornecido para essa coluna.
- **Exemplo**: `criado_em DATETIME DEFAULT GETDATE()` significa que, se nenhum valor for fornecido para `criado_em`, a data e hora atuais serão usadas como padrão.

### 5. `REFERENCES`
- **Função**: É utilizado para estabelecer uma relação entre duas tabelas, criando uma chave estrangeira. A coluna que possui a cláusula `REFERENCES` refere-se à coluna de chave primária em outra tabela.
- **Exemplo**: `FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario)` significa que a coluna `id_usuario` na tabela atual deve corresponder a um valor existente na coluna `id_usuario` da tabela `Usuarios`. Isso ajuda a garantir a integridade referencial entre as tabelas.

### Resumo
Essas cláusulas ajudam a garantir a integridade e a estrutura do banco de dados, evitando dados duplicados, nulos ou inconsistentes, e facilitando o gerenciamento e a relação entre diferentes tabelas.
