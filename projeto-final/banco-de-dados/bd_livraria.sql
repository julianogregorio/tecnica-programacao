-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.27-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.11.0.7065
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

-- Copiando estrutura para tabela livraria.autor
CREATE TABLE IF NOT EXISTS `autor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `nacao` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Copiando dados para a tabela livraria.autor: ~0 rows (aproximadamente)

-- Copiando estrutura para tabela livraria.edicoes
CREATE TABLE IF NOT EXISTS `edicoes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `editora` varchar(50) NOT NULL DEFAULT '',
  `ano` int(11) NOT NULL DEFAULT 0,
  `num_edicao` int(11) NOT NULL DEFAULT 0,
  `id_livro` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_edicoes_livro` (`id_livro`),
  CONSTRAINT `fk_edicoes_livro` FOREIGN KEY (`id_livro`) REFERENCES `livro` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Copiando dados para a tabela livraria.edicoes: ~0 rows (aproximadamente)

-- Copiando estrutura para tabela livraria.lista
CREATE TABLE IF NOT EXISTS `lista` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_livro` int(11) DEFAULT NULL,
  `id_autor` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_livro` (`id_livro`),
  KEY `id_autor` (`id_autor`),
  CONSTRAINT `lista_ibfk_1` FOREIGN KEY (`id_livro`) REFERENCES `livro` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `lista_ibfk_2` FOREIGN KEY (`id_autor`) REFERENCES `autor` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Copiando dados para a tabela livraria.lista: ~0 rows (aproximadamente)

-- Copiando estrutura para tabela livraria.livro
CREATE TABLE IF NOT EXISTS `livro` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `isbn` varchar(50) NOT NULL DEFAULT '',
  `nome` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Copiando dados para a tabela livraria.livro: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
