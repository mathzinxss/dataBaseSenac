# Banco de Dados - Senac

#### Os tipos de dados no SQL são organizados nas seguintes **categorias:**

- Cadeia de caracteres: `char` | `varchar` | `text`
- Numéricos exatos: `bigint` | `numeric` | `bit` | `smallint` | `decimal` | `smallmoney` | `int` | `tinyint` | `money` 
- Numéricos aproximados: `float` | `real`
- Data e hora: `date` | `datetimeoffset` | `datetime2` | `smalldatetime` | `datetime` | `time`
- Cadeia de caracteres binária: `binary` | `varbinary` | `image,`
- Cadeia de caracteres Unicode:  `ntext` | `nvarchar` | `nchar`
- Outros tipos de dados: `cursor` | `rowversion` | `hierarchvid` | `uniqueidentifier` | `sql variant` | `xml` | `Tipos de geometria espacial` | `table`

---

## **Categorias de BD**

Os bancos de dados podem ser categorizados de várias maneiras, sendo que uma das principais delas aponta para a sua arquitetura, a qual pode ser centralizada, descentralizada, distribuída e replicada.

## **Tipagens de Dados mais utilizados**

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

---

```sql
CREATE TABLE alunos (
id_aluno INT,
nome VARCHAR(50),
nascimento DATE,
endereco VARCHAR(80),
email VARCHAR(100),
celular VARCHAR(25),
mensalidade DECIMAL,
PRIMARY KEY (id_aluno)
)
Execute

ALTER TABLE alunos CHANCE id_aluno 'id_aluno'
INT(11) NOT NULL AUTO_INCREMENT;
Execute // aqui o campo id_aluno será auto incremental
```

Para incluír um registro em uma tabela:

insert into alunos (nome, nascimento, endereço, mensalidade, email, celular) value ('Francisco Alves', '1980-12-10', 'Rua tito, 800', '450', 'chico@gmail.com', '11987654321')

Para alterar:
update alunos set mensalidade='500', celular='11987654321'
  where id_aluno = 1

Para excluír:
delete from alunos where id_alunos = 1

Para consultar:
select * from alunos where mensalidade > 300

## **Consulta com Critérios**

##### Seleção de todos os campos usados

```sql
USE bancoDeDados;

SELECT * FROM tabela;
```

##### Seleção de apenas dois campos

```sql
USE bancoDeDados;

SELECT coluna1, coluna2 FROM tabela
```

##### Quando se utiliza o igual, procura sua informação de forma EXATA que foi acrescentada no código 

```sql
USE bancoDeDados;

SELECT * FROM tabela WHERE coluna = 'produto da coluna'
```

#### **Exemplos:**

```sql
USE bancoDeDados;

SELECT * FROM tb_clientes WHERE ddd = 11
```
---
```sql
USE bancoDeDados;

SELECT * FROM tb_clientes WHERE uf = 'sp'
```
---
```sql
USE bancoDeDados;

SELECT * FROM tb_clientes WHERE telefone = '12345-6789'
```
---
```sql
USE bancoDeDados;

SELECT * FROM tb_clientes WHERE nome = 'Mathias Fernando'
```

##### Para filtrar a pesquisa utilizando poucas informações do produto, utilizamos o `%` para  indicar que queremos buscar por qualquer coisa antes ou depois da palavra que foi digitada.

**Exemplo:**

```sql
USE bancoDeDados;

SELECT * FROM tabela WHERE coluna LIKE '%fração do produto%'
```

- Quando é utilizando apenas  o `%` no início da palavra, ele procura por qualquer coisa antes da palavra que foi digitada.
- Quando é utilizado o `%`  no final da palavra, ele procura por qualquer coisa depois da palavra que foi digitada.
- Quando é utilizado o `%` no início e no final da palavra, ele procura por  qualquer coisa antes e depois da palavra que foi digitada.

##### Para filtrar a pesquisa por ordem crescentes e decrescentes utilizamos o `ORDER BY`

- Para ordem crescentes utilizamos o `ASC`: 

```sql
USE bancoDeDados;

SELECT * FROM tabela ORDER BY coluna ASC
```

- Para ordem decrescente utilizamos o `DESC`: 

```sql
USE bancoDeDados;

SELECT * FROM tabela ORDER BY coluna DESC
```

##### Para utilizar mais de um filtro na pesquisa utilizamos o `AND` ou `OR`

**Exemplo:**

- Para pesquisar um produto expecífico que necessariamente precisa conter dois valores ou mais expecíficos, utilizamos o `AND`. "Quero que  o produto seja azul **E** tenha 10 cm de comprimento".


```sql
USE bancoDeDados;

SELECT * FROM tabela WHERE coluna1 LIKE '%critério1%' AND coluna2  LIKE '%critério2%'
```

- Para pesquisar um produto expecífico que não precisam conter dois valores ou mais expecíficos, utilizamos o `OR`. "Eu preciso de um lápis de cor azul **OU** o vermelho, tanto faz a cor."

```sql
USE bancoDeDados;

SELECT * FROM tabela WHERE coluna1 LIKE '%critério1%' OR coluna2  LIKE '%critério2%'
```


