CREATE DATABASE aprova_mais;
USE aprova_mais;

CREATE TABLE usuario (
id_usu INT PRIMARY KEY AUTO_INCREMENT,
nome_usu VARCHAR(100),
email_usu VARCHAR(100),
senha_usu VARCHAR(100)
);

CREATE TABLE materia (
id_mat INT PRIMARY KEY AUTO_INCREMENT,
nome_mat VARCHAR(100),
descricao_mat VARCHAR(200)
);

CREATE TABLE topico (
id_top INT PRIMARY KEY AUTO_INCREMENT,
nome_top VARCHAR(100),
id_mat_fk INT,
FOREIGN KEY (id_mat_fk) REFERENCES materia(id_mat)
);

INSERT INTO usuario (nome_usu, email_usu, senha_usu) VALUES
('João Silva', 'joao@gmail.com', '123456'),
('Maria Souza', 'maria@gmail.com', '123456'),
('Pedro Santos', 'pedro@gmail.com', '123456');

INSERT INTO materia (nome_mat, descricao_mat) VALUES
('Matemática', 'Matemática para ENEM'),
('Português', 'Língua Portuguesa'),
('História', 'História do Brasil e do mundo'),
('Geografia', 'Geografia geral');

INSERT INTO topico (nome_top, id_mat_fk) VALUES
('Equações', 1),
('Geometria', 1),
('Funções', 1),
('Interpretação de Texto', 2),
('Gramática', 2),
('Brasil Colônia', 3),
('Revolução Industrial', 3),
('Geografia do Brasil', 4);

SELECT
materia.nome_mat AS Materia,
topico.nome_top AS Topico
FROM
materia INNER JOIN topico ON (materia.id_mat = topico.id_mat_fk);

SELECT
materia.nome_mat AS Materia,
topico.nome_top AS Topico
FROM materia LEFT JOIN topico ON (materia.id_mat = topico.id_mat_fk);