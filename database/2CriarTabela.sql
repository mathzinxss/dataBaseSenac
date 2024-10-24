USE bdExemplo1

CREATE TABLE tb_clientes (
    idCliente INT IDENTITY (1,1),
    nome VARCHAR(255) NOT NULL, 
    ddd INT NOT NULL,
    uf VARCHAR(2) NOT NULL,
    telefone VARCHAR(10) NOT NULL

    CONSTRAINT PK_tb_clientes PRIMARY KEY (idCliente)
)