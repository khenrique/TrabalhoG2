INSERT INTO categorias (nome_cat) VALUES ('Masculino');
INSERT INTO categorias (nome_cat) VALUES('Feminino');
INSERT INTO categorias (nome_cat) VALUES('Infaltil');


INSERT INTO fantasias (id_categoria, descricao)
VALUES (2, 'Fantasia de Fada');
INSERT INTO fantasias (id_categoria, descricao)
VALUES (1, 'Fantasia de Pirata');
INSERT INTO fantasias (id_categoria, descricao)
VALUES (3, 'Fantasia de Princesa');
INSERT INTO fantasias (id_categoria, descricao)
VALUES (1, 'Fantasia de Chapeleiro Maluco');
INSERT INTO fantasias (id_categoria, descricao)
VALUES (2, 'Fantasia de Rainha de Copas');
INSERT INTO fantasias (id_categoria, descricao)
VALUES (3, 'Fantasia de Sininho');
INSERT INTO fantasias (id_categoria, descricao)
VALUES (2, 'Fantasia de Caveira Mexicana');
INSERT INTO fantasias (id_categoria, descricao)
VALUES (1, 'Fantasia de Cowboy');

INSERT INTO exemplares(id_fantasia) VALUES (1)
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (1, 'M');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (1, 'P');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (2, 'M');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (2, 'G');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (3, 'P');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (3, 'M');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (3, 'G');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (4, 'UN');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (5, 'M');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (5, 'G');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (6, 'UN');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (6, 'UN');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (7, 'UN');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (7, 'GG');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (8, 'P');
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (8, 'M'); 
INSERT INTO exemplares(id_fantasia, tamanho) VALUES (8, 'GG');

INSERT INTO fornecedores(nome_forn) VAlUES ('Fornecedor 1');
INSERT INTO fornecedores(nome_forn) VAlUES ('Fornecedor 2');
INSERT INTO fornecedores(nome_forn) VAlUES ('Fornecedor 3');

INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (1, 2);
INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (1, 3);
INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (1, 5);
INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (1, 4);
INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (2, 1);
INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (2, 4);
INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (2, 5);
INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (2, 6);
INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (3, 8);
INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (3, 7);
INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (3, 3);
INSERT INTO fantasias_por_fornecedor 
(id_fornecedor, id_fantasia) VALUES (3, 1);

INSERT INTO clientes (nome_cli, telefone, endereco)
VALUES ('Mariana', '(51) 8215-2659', 'Av. Fernandes Bastos, 2767');
INSERT INTO clientes (nome_cli, telefone, endereco)
VALUES ('Pedro Victor', '(51) 9919-8475', 'Rua Castro Alves, 474');
INSERT INTO clientes (nome_cli, telefone, endereco)
VALUES ('Ana Luiza', '(11) 9457-5586', 'Rua Santa Maria, 4851');
INSERT INTO clientes (nome_cli, telefone, endereco)
VALUES ('Giovani', '(55) 8356-9562', 'Av. Paraguassu, 1168');
INSERT INTO clientes (nome_cli, telefone, endereco)
VALUES ('Thais', '(51) 8145-0545', 'Av. Fernandes Bastos, 1020');

INSERT INTO alugueis (id_cliente, id_exemplar,data_retirada)
VALUES (1, 1, '2015-05-31');
INSERT INTO alugueis (id_cliente, id_exemplar,data_retirada)
VALUES (2, 16, '2015-05-31');
INSERT INTO alugueis (id_cliente, id_exemplar,data_retirada)
VALUES (3, 14, '2015-06-08');
INSERT INTO alugueis (id_cliente, id_exemplar,data_retirada)
VALUES (4, 5, '2015-06-10');
INSERT INTO alugueis (id_cliente, id_exemplar,data_retirada)
VALUES (5, 12, '2015-06-08');