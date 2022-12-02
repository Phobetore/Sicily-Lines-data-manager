CREATE DATABASE IF NOT EXISTS `bd-sicilylines`;
DROP USER IF EXISTS 'dbmanager'@'localhost';
CREATE USER 'dbmanager'@'localhost'
  IDENTIFIED BY 'ceciEstUnGrosMotDePasse';
GRANT ALL
  ON bd-sicilylines.*
  TO 'dbmanager'@'localhost'
  WITH GRANT OPTION;


-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 01 déc. 2022 à 09:49
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bd-sicilylines`
--



USE `bd-sicilylines`;




-- --------------------------------------------------------

--
-- Structure de la table `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(100) NOT NULL,
  `passwd` varchar(256) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `admin`
--

INSERT INTO `admin` (`id`, `login`, `passwd`) VALUES
(1, 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

DROP TABLE IF EXISTS `bateau`;
CREATE TABLE IF NOT EXISTS `bateau` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) DEFAULT NULL,
  `longuer` varchar(100) DEFAULT NULL,
  `largeur` varchar(100) DEFAULT NULL,
  `vitesse` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `bateau`
--

INSERT INTO `bateau` (`id`, `nom`, `longuer`, `largeur`, `vitesse`) VALUES
(1, 'Eduardo', '37,20m', '8,60m', '20 noeuds'),
(2, 'Platone', '25m', '7m', '16 noeuds'),
(3, 'Marco', '[value-3]', '[value-4]', '[value-5]'),
(4, 'Mantegna', '[value-3]', '[value-4]', '[value-5]'),
(5, 'Antico', '[value-3]', '[value-4]', '[value-5]');

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`id`, `libelle`) VALUES
(1, 'A-Personne'),
(2, 'B-Véh.inf.2m'),
(3, 'C-Véh.sup.2m');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(100) DEFAULT NULL,
  `prenom` varchar(100) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `adresse` varchar(255) DEFAULT NULL,
  `code_postal` varchar(5) DEFAULT NULL,
  `num_telephone` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

DROP TABLE IF EXISTS `contenir`;
CREATE TABLE IF NOT EXISTS `contenir` (
  `nbMax` int(25) NOT NULL AUTO_INCREMENT,
  `idBateau` int(11) NOT NULL,
  `idCate` int(11) NOT NULL,
  PRIMARY KEY (`nbMax`),
  KEY `idBateau` (`idBateau`),
  KEY `idCate` (`idCate`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

DROP TABLE IF EXISTS `equipement`;
CREATE TABLE IF NOT EXISTS `equipement` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `equipement`
--

INSERT INTO `equipement` (`id`, `libelle`) VALUES
(1, 'Accès Handicapé'),
(2, 'Bar'),
(3, 'Pont Promenade'),
(4, 'Salon Vidéo');

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

DROP TABLE IF EXISTS `liaison`;
CREATE TABLE IF NOT EXISTS `liaison` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `duree` varchar(6) DEFAULT NULL,
  `id-secteur` int(11) NOT NULL,
  `port-depart` int(11) NOT NULL,
  `port-arrivee` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idSecteur` (`id-secteur`),
  KEY `portDepart` (`port-depart`),
  KEY `portArrivee` (`port-arrivee`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `liaison`
--

INSERT INTO `liaison` (`id`, `duree`, `id-secteur`, `port-depart`, `port-arrivee`) VALUES
(10, '700', 1, 8, 6),
(11, '50mm', 3, 3, 6),
(15, '1h30', 1, 1, 5),
(16, '1h25', 2, 2, 7),
(17, '1h45', 2, 2, 8),
(19, '2h50', 2, 2, 9),
(21, '30mm', 4, 4, 11),
(24, '4h', 1, 1, 6),
(25, '40mm', 3, 3, 8);

-- --------------------------------------------------------

--
-- Structure de la table `participer`
--

DROP TABLE IF EXISTS `participer`;
CREATE TABLE IF NOT EXISTS `participer` (
  `nombre` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `periode`
--

DROP TABLE IF EXISTS `periode`;
CREATE TABLE IF NOT EXISTS `periode` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `dateDebut` date DEFAULT NULL,
  `dateFin` date DEFAULT NULL,
  `tarifer_periode` int(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

DROP TABLE IF EXISTS `port`;
CREATE TABLE IF NOT EXISTS `port` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `port`
--

INSERT INTO `port` (`id`, `nom`) VALUES
(1, 'Palerme'),
(2, 'Messine'),
(3, 'Milazzo'),
(4, 'Trapani'),
(5, 'Ustica'),
(6, 'Lipari'),
(7, 'Stromboli'),
(8, 'Vulcano'),
(9, 'Panarea'),
(10, 'Pantelleria'),
(11, 'Favignagna');

-- --------------------------------------------------------

--
-- Structure de la table `proposer`
--

DROP TABLE IF EXISTS `proposer`;
CREATE TABLE IF NOT EXISTS `proposer` (
  `quantite` int(11) NOT NULL,
  `idEquipement` int(11) NOT NULL,
  `idBateau` int(11) NOT NULL,
  PRIMARY KEY (`quantite`),
  KEY `idEquipement` (`idEquipement`),
  KEY `idBateau` (`idBateau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idClient` int(3) NOT NULL ,
  `nombreP` int(25) NOT NULL,
  `idTraversee` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idClient` (`idClient`),
  KEY `nombreP` (`nombreP`),
  KEY `idTraversee` (`idTraversee`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

DROP TABLE IF EXISTS `secteur`;
CREATE TABLE IF NOT EXISTS `secteur` (
  `id` int(11) NOT NULL,
  `nom` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`id`, `nom`) VALUES
(1, 'Palerme'),
(2, 'Messine'),
(3, 'Milazzo'),
(4, 'Trapani');

-- --------------------------------------------------------

--
-- Structure de la table `tarifer`
--

DROP TABLE IF EXISTS `tarifer`;
CREATE TABLE IF NOT EXISTS `tarifer` (
  `tarif` int(11) NOT NULL,
  `idType` int(11) NOT NULL,
  `idPeriode` int(11) NOT NULL,
  PRIMARY KEY (`tarif`),
  KEY `idType` (`idType`),
  KEY `idPeriode` (`idPeriode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `traversee`
--

DROP TABLE IF EXISTS `traversee`;
CREATE TABLE IF NOT EXISTS `traversee` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` date DEFAULT NULL,
  `heure` varchar(255) DEFAULT NULL,
  `idBateau` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idBateau` (`idBateau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `traversee`
--

INSERT INTO `traversee` (`id`, `date`, `heure`, `idBateau`) VALUES
(1, '2021-09-21', '07:45', 3),
(2, '2021-09-21', '09:15', 4),
(3, '2021-09-21', '10:50', 5);

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

DROP TABLE IF EXISTS `type`;
CREATE TABLE IF NOT EXISTS `type` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(100) DEFAULT NULL,
  `nombreP` int(25) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `nombreP` (`nombreP`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD CONSTRAINT `contenir_ibfk_1` FOREIGN KEY (`idBateau`) REFERENCES `bateau` (`id`),
  ADD CONSTRAINT `contenir_ibfk_2` FOREIGN KEY (`idCate`) REFERENCES `categorie` (`id`);

--
-- Contraintes pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD CONSTRAINT `liaison_ibfk_1` FOREIGN KEY (`id-secteur`) REFERENCES `secteur` (`id`),
  ADD CONSTRAINT `liaison_ibfk_2` FOREIGN KEY (`port-depart`) REFERENCES `port` (`id`),
  ADD CONSTRAINT `liaison_ibfk_3` FOREIGN KEY (`port-arrivee`) REFERENCES `port` (`id`);

--
-- Contraintes pour la table `proposer`
--
ALTER TABLE `proposer`
  ADD CONSTRAINT `proposer_ibfk_1` FOREIGN KEY (`idEquipement`) REFERENCES `equipement` (`id`),
  ADD CONSTRAINT `proposer_ibfk_2` FOREIGN KEY (`idBateau`) REFERENCES `bateau` (`id`);

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`idClient`) REFERENCES `client` (`id`),
  ADD CONSTRAINT `reservation_ibfk_2` FOREIGN KEY (`nombreP`) REFERENCES `participer` (`nombre`),
  ADD CONSTRAINT `reservation_ibfk_3` FOREIGN KEY (`idTraversee`) REFERENCES `traversee` (`id`);

--
-- Contraintes pour la table `tarifer`
--
ALTER TABLE `tarifer`
  ADD CONSTRAINT `tarifer_ibfk_1` FOREIGN KEY (`idType`) REFERENCES `type` (`id`),
  ADD CONSTRAINT `tarifer_ibfk_2` FOREIGN KEY (`idPeriode`) REFERENCES `periode` (`id`);

--
-- Contraintes pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD CONSTRAINT `traversee_ibfk_1` FOREIGN KEY (`idBateau`) REFERENCES `bateau` (`id`);

--
-- Contraintes pour la table `type`
--
ALTER TABLE `type`
  ADD CONSTRAINT `type_ibfk_1` FOREIGN KEY (`nombreP`) REFERENCES `participer` (`nombre`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
