USE bdExemplo1;

-- UPDATE tb_clientes SET uf = LOWER (uf);
-- UPDATE tb_clientes SET uf = UPPER (uf);
UPDATE tb_clientes SET uf = UPPER (uf) WHERE idCliente = 8;

SELECT  * FROM tb_clientes;
