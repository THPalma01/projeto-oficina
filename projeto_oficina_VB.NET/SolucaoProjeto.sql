
USE oficina;
CREATE TABLE tb_clientes(
id_cliente integer PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(50) NOT NULL,
cpf CHAR(14)unique,
telefone VARCHAR(20),
email VARCHAR(100)
);

CREATE TABLE tb_veiculos(
id_veiculos INTEGER PRIMARY KEY AUTO_INCREMENT,
id_cliente INTEGER NOT NULL,
marca VARCHAR(30),
cor VARCHAR(20),
modelo VARCHAR(30),
ano INTEGER(30),
placa CHAR(7) NOT NULL unique,
FOREIGN KEY(id_cliente) REFERENCES tb_clientes(id_cliente) ON delete CASCADE,
FOREIGN KEY(id_cliente) REFERENCES tb_clientes(id_cliente) ON update CASCADE
);

CREATE TABLE tb_orcamentos(
id_orcamento INTEGER PRIMARY key AUTO_INCREMENT,
id_veiculos INTEGER NOT NULL,
data_orca DATE NOT NULL,
hora_orca DATETIME NOT NULL,
valor_total DECIMAL(10,2) NOT NULL,
STATUS ENUM('pendente','aprovado','Recusado') DEFAULT 'Pendente',
FOREIGN KEY (id_veiculos) REFERENCES tb_veiculos(id_veiculos) ON DELETE CASCADE
);

CREATE TABLE tb_pecas_servicos(
id_itens INTEGER PRIMARY KEY AUTO_INCREMENT,
id_orcamento INTEGER NOT NULL,
descricao VARCHAR(100) NOT NULL,
quantidade INTEGER,
preco_unitario DECIMAL (10,2),
FOREIGN KEY (id_orcamento) REFERENCES  tb_orcamentos(id_orcamento) ON DELETE CASCADE
);

CREATE TABLE tb_checklist (
    id_checklist INTEGER PRIMARY KEY AUTO_INCREMENT,
    id_veiculos INTEGER NOT NULL,
    data DATE NOT NULL,
    documentos ENUM('Existente', 'Inexistente', 'Avariado') DEFAULT 'Inexistente',
    manual ENUM('Existente', 'Inexistente', 'Avariado') DEFAULT 'Inexistente',
    chave_de_roda ENUM('Existente', 'Inexistente', 'Avariado') DEFAULT 'Inexistente',
    macaco ENUM('Existente', 'Inexistente', 'Avariado') DEFAULT 'Inexistente',
    triangulo ENUM('Existente', 'Inexistente', 'Avariado') DEFAULT 'Inexistente',
    extintor ENUM('Existente', 'Inexistente', 'Avariado') DEFAULT 'Inexistente',
    radio ENUM('Existente', 'Inexistente', 'Avariado') DEFAULT 'Inexistente',
    tapetes ENUM('Existente', 'Inexistente', 'Avariado') DEFAULT 'Inexistente',
    calotas ENUM('Existente', 'Inexistente', 'Avariado') DEFAULT 'Inexistente',
    antena ENUM('Existente', 'Inexistente', 'Avariado') DEFAULT 'Inexistente',
    descricao_veiculo TEXT,
    FOREIGN KEY (id_veiculos) REFERENCES tb_veiculos(id_veiculos) ON DELETE CASCADE
);

CREATE TABLE tb_agendamentos (
    id_agendamento INTEGER PRIMARY KEY AUTO_INCREMENT,
    id_cliente INTEGER NOT NULL,
    id_veiculos INTEGER NOT NULL,
    data_hora DATETIME NOT NULL,
    status ENUM('Agendado', 'Concluído', 'Cancelado') DEFAULT 'Agendado',
    FOREIGN KEY (id_cliente) REFERENCES tb_clientes(id_cliente) ON DELETE CASCADE,
    FOREIGN KEY (id_veiculos) REFERENCES tb_veiculos(id_veiculos) ON DELETE CASCADE
);

SELECT * FROM tb_clientes;
SELECT * FROM tb_veiculos;
SELECT * FROM tb_pecas_servicos;
SELECT * FROM tb_orcamentos;
SELECT * FROM tb_checklist;
SELECT * FROM tb_agendamentos;