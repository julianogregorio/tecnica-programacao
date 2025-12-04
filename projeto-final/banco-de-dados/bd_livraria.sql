-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.32-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.13.0.7147
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para livraria
CREATE DATABASE IF NOT EXISTS `livraria` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `livraria`;

-- Copiando estrutura para procedure livraria.sp_associar_autor_livro
DELIMITER //
CREATE PROCEDURE `sp_associar_autor_livro`(
    IN p_id_livro INT,
    IN p_id_autor INT
)
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM tb_lista
        WHERE id_livro = p_id_livro AND id_autor = p_id_autor
    ) THEN
        INSERT INTO tb_lista (id_livro, id_autor)
        VALUES (p_id_livro, p_id_autor);
    END IF;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria.sp_cadastrar_autor
DELIMITER //
CREATE PROCEDURE `sp_cadastrar_autor`(
    IN p_nome VARCHAR(50),
    IN p_nacao VARCHAR(50),
    OUT p_id_autor INT
)
BEGIN
    DECLARE v_id INT;

    SELECT id INTO v_id
    FROM tb_autor
    WHERE nome = p_nome AND nacao = p_nacao
    LIMIT 1;

    IF v_id IS NULL THEN
        INSERT INTO tb_autor (nome, nacao)
        VALUES (p_nome, p_nacao);
        SET v_id = LAST_INSERT_ID();
    END IF;

    SET p_id_autor = v_id;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria.sp_cadastrar_edicao
DELIMITER //
CREATE PROCEDURE `sp_cadastrar_edicao`(
    IN p_editora VARCHAR(50),
    IN p_ano INT,
    IN p_num_edicao INT,
    IN p_id_livro INT,
    OUT p_id_edicao INT
)
BEGIN
    INSERT INTO tb_edicoes (editora, ano, num_edicao, id_livro)
    VALUES (p_editora, p_ano, p_num_edicao, p_id_livro);
    
    SET p_id_edicao = LAST_INSERT_ID();
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria.sp_cadastrar_livro
DELIMITER //
CREATE PROCEDURE `sp_cadastrar_livro`(
    IN p_isbn VARCHAR(50),
    IN p_nome VARCHAR(50),
    OUT p_id_livro INT
)
BEGIN
    DECLARE v_id INT;

    SELECT id INTO v_id
    FROM tb_livro
    WHERE isbn = p_isbn
    LIMIT 1;

    IF v_id IS NULL THEN
        INSERT INTO tb_livro (isbn, nome)
        VALUES (p_isbn, p_nome);
        SET v_id = LAST_INSERT_ID();
    END IF;

    SET p_id_livro = v_id;
END//
DELIMITER ;

-- Copiando estrutura para tabela livraria.tb_autor
CREATE TABLE IF NOT EXISTS `tb_autor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `nacao` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `uq_autor_nome_nacao` (`nome`,`nacao`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela livraria.tb_edicoes
CREATE TABLE IF NOT EXISTS `tb_edicoes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `editora` varchar(50) NOT NULL DEFAULT '',
  `ano` int(11) NOT NULL DEFAULT 0,
  `num_edicao` int(11) NOT NULL DEFAULT 0,
  `id_livro` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_edicoes_livro` (`id_livro`),
  CONSTRAINT `fk_edicoes_livro` FOREIGN KEY (`id_livro`) REFERENCES `tb_livro` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela livraria.tb_lista
CREATE TABLE IF NOT EXISTS `tb_lista` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_livro` int(11) DEFAULT NULL,
  `id_autor` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `uq_lista_livro_autor` (`id_livro`,`id_autor`),
  KEY `id_livro` (`id_livro`),
  KEY `id_autor` (`id_autor`),
  CONSTRAINT `tb_lista_ibfk_1` FOREIGN KEY (`id_livro`) REFERENCES `tb_livro` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tb_lista_ibfk_2` FOREIGN KEY (`id_autor`) REFERENCES `tb_autor` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela livraria.tb_livro
CREATE TABLE IF NOT EXISTS `tb_livro` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `isbn` varchar(50) NOT NULL DEFAULT '',
  `nome` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`),
  UNIQUE KEY `uq_livro_isbn` (`isbn`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados foi desmarcado.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
