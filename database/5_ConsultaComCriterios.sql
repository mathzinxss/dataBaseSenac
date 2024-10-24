USE bdExemplo1;

-- SELECT * FROM tb_clientes; Seleção de todos os campos usados;
-- SELECT nome, uf FROM tb_clientes Seleção de apenas dois campos;

-- SELECT * FROM tb_clientes WHERE idCliente = 5 --> Quando se utiliza o igual, procura sua informação de forma EXATA que foi acrescentada no código
-- SELECT * FROM tb_clientes WHERE ddd = 11
-- SELECT * FROM tb_clientes WHERE uf = 'sp'
-- SELECT * FROM tb_clientes WHERE telefone = '12345-6789'
-- SELECT * FROM tb_clientes WHERE nome = 'Mathias Fernando'
-- SELECT * FROM tb_clientes WHERE nome LIKE '%m%'
-- SELECT * FROM tb_clientes WHERE telefone LIKE '%-%'
-- SELECT * FROM tb_clientes ORDER BY nome ASC --> Para chamar produtos em ordem crescentes, como ordem alfabetica
-- SELECT * FROM tb_clientes ORDER BY nome DESC  --> Para chamar produtos em ordem decrescentes, como ordem alfabetica invertida
-- SELECT * FROM tb_clientes WHERE nome LIKE '%z%' AND telefone  LIKE '%2%'