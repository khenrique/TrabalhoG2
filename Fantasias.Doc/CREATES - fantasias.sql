CREATE DATEBASE loja_fantasias;

CREATE TABLE IF NOT EXISTS loja_fantasias.clientes (
    id_cliente INT(11) NOT NULL AUTO_INCREMENT,
    nome_cli VARCHAR(45) NOT NULL,
    telefone VARCHAR(45) NOT NULL,
    endereco VARCHAR(45) NOT NULL,
    qtd_alugueis INT(11) NULL DEFAULT 0,
    PRIMARY KEY (id_cliente)
);

CREATE TABLE IF NOT EXISTS loja_fantasias.categorias (
    id_categoria INT(11) NOT NULL AUTO_INCREMENT,
    nome_cat VARCHAR(45) NOT NULL,
    PRIMARY KEY (id_categoria)
);

CREATE TABLE IF NOT EXISTS loja_fantasias.fantasias (
    id_fantasia INT(11) NOT NULL AUTO_INCREMENT,
    id_categoria INT(11) NOT NULL,
    descricao VARCHAR(45) NOT NULL,
    PRIMARY KEY (id_fantasia),
    FOREIGN KEY (id_categoria)
        REFERENCES loja_fantasias.categorias (id_categoria)
        ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE IF NOT EXISTS loja_fantasias.exemplares (
    id_exemplar INT(11) NOT NULL AUTO_INCREMENT,
    id_fantasia INT(11) NOT NULL,
    tamanho CHAR(2) NULL DEFAULT 'UN',
    PRIMARY KEY (id_exemplar),
    FOREIGN KEY (id_fantasia)
        REFERENCES loja_fantasias.fantasias (id_fantasia)
        ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE IF NOT EXISTS loja_fantasias.alugueis (
    id_aluguel INT(11) NOT NULL AUTO_INCREMENT,
    id_cliente INT(11) NOT NULL,
    id_exemplar INT(11) NOT NULL,
    data_retirada DATE NOT NULL,
    data_entrega DATE NULL DEFAULT '0000-00-00',
    PRIMARY KEY (id_aluguel),
    FOREIGN KEY (id_cliente)
        REFERENCES loja_fantasias.clientes (id_cliente)
        ON DELETE NO ACTION ON UPDATE NO ACTION,
    FOREIGN KEY (id_exemplar)
        REFERENCES loja_fantasias.exemplares (id_exemplar)
        ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE IF NOT EXISTS loja_fantasias.fornecedores (
    id_fornecedor INT(11) NOT NULL AUTO_INCREMENT,
    nome_forn VARCHAR(45) NULL DEFAULT NULL,
    qtd_fantacias_fornecidas VARCHAR(45) NULL DEFAULT NULL,
    PRIMARY KEY (id_fornecedor)
);

CREATE TABLE IF NOT EXISTS loja_fantasias.fantasias_por_fornecedor (
    id_fornecedor INT(11) NOT NULL,
    id_fantasia INT(11) NOT NULL,
    PRIMARY KEY (id_fornecedor , id_fantasia),
    FOREIGN KEY (id_fornecedor)
        REFERENCES loja_fantasias.fornecedores (id_fornecedor)
        ON DELETE NO ACTION ON UPDATE NO ACTION,
    FOREIGN KEY (id_fantasia)
        REFERENCES loja_fantasias.fantasias (id_fantasia)
        ON DELETE NO ACTION ON UPDATE NO ACTION
);