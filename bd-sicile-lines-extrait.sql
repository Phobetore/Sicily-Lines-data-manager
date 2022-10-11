--
-- Base de données : `bd-sicilylines`
--
-- Structure de la table `liaison`
--

DROP TABLE IF EXISTS `liaison`;
CREATE TABLE IF NOT EXISTS `liaison` (
  `id` int(11) NOT NULL,
  `duree` varchar(6) NOT NULL,
  `port-depart` int(11) NOT NULL,
  `port-arrivee` int(11) NOT NULL,
  `idSecteur` int(2) NOT NULL,
  KEY `fk-depart` (`port-depart`),
  KEY `fk-arrivee` (`port-arrivee`),
  KEY `id` (`id`),
  KEY `duree` (`duree`),
  KEY `fk-Secteur` (`idSecteur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Donn�es de la table `liaison`
--

INSERT INTO `liaison` (`id`, `duree`, `port-depart`, `port-arrivee`, `idSecteur`) VALUES
(15, '1h30', 1, 2, 1);


--
-- Structure de la table `port`
--

DROP TABLE IF EXISTS `port`;
CREATE TABLE IF NOT EXISTS `port` (
  `id` int(11) NOT NULL,
  `nom` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `port`
--

INSERT INTO `port` (`id`, `nom`) VALUES
(1, 'Palerme'),
(2, 'Ustica'),
(3, 'Stromboli'),
(4, 'Lipari');

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

DROP TABLE IF EXISTS `secteur`;
CREATE TABLE IF NOT EXISTS `secteur` (
  `id` int(2) NOT NULL,
  `nom` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`id`, `nom`) VALUES
(1, 'Palerme'),
(2, 'Messine');


--
-- Structure de la table `traversee`
--

DROP TABLE IF EXISTS `traversee`;
CREATE TABLE IF NOT EXISTS `traversee` (
  `id` int(2) NOT NULL,
  `date` date NOT NULL,
  `heure` time NOT NULL,
  `id-liaison` int(2) NOT NULL,
  `id-Bateau` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk-liaison-traversee` (`id-liaison`),
  KEY `fk-bateau` (`id-Bateau`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `traversee`
--

INSERT INTO `traversee` (`id`, `date`, `heure`, `id-liaison`, `id-Bateau`) VALUES
(51000, '2021-09-21', '17:30:00', 15, 1);


--
-- Contraintes pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD CONSTRAINT `fk-Secteur` FOREIGN KEY (`idSecteur`) REFERENCES `secteur` (`id`),
  ADD CONSTRAINT `fk-arrivee` FOREIGN KEY (`port-arrivee`) REFERENCES `port` (`id`),
  ADD CONSTRAINT `fk-depart` FOREIGN KEY (`port-depart`) REFERENCES `port` (`id`);


