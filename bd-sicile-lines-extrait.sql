DROP DATABASE IF EXISTS `bd-sicilylines`;

CREATE DATABASE IF NOT EXISTS `bd-sicilylines`;
USE `bd-sicilylines`;
# -----------------------------------------------------------------------------
#       TABLE : LIAISON
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LIAISON
 (
   ID INT(32) NOT NULL AUTO_INCREMENT  ,
   ID_REGROUPER INT(32) NOT NULL  ,
   ID_DEPART INT(32) NOT NULL  ,
   ID_ARRIVEE INT(32) NOT NULL  ,
   DUREE INT NOT NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE LIAISON
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_LIAISON_SECTEUR
     ON LIAISON (ID_REGROUPER ASC);

CREATE  INDEX I_FK_LIAISON_PORT
     ON LIAISON (ID_DEPART ASC);

CREATE  INDEX I_FK_LIAISON_PORT1
     ON LIAISON (ID_ARRIVEE ASC);

# -----------------------------------------------------------------------------
#       TABLE : TYPE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE
 (
   ID CHAR(32) NOT NULL  ,
   ID_CLASSER CHAR(32) NOT NULL  ,
   LIBELLE CHAR(32) NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE TYPE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_TYPE_CATEGORIE
     ON TYPE (ID_CLASSER ASC);

# -----------------------------------------------------------------------------
#       TABLE : SECTEUR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SECTEUR
 (
   ID CHAR(32) NOT NULL  ,
   LIBELLE CHAR(32) NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : BATEAU
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS BATEAU
 (
   ID CHAR(32) NOT NULL  ,
   NOM CHAR(32) NOT NULL  ,
   LONGUEUR CHAR(32) NULL  ,
   LARGEUR CHAR(32) NULL  ,
   VITESSE CHAR(32) NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : PERIODE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PERIODE
 (
   ID CHAR(32) NOT NULL  ,
   DATEDEBUT DATE NULL  ,
   DATEFIN CHAR(32) NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : PORT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PORT
 (
   ID CHAR(32) NOT NULL  ,
   NOM CHAR(32) NOT NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : CLIENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CLIENT
 (
   ID CHAR(32) NOT NULL  ,
   NOM CHAR(32) NOT NULL  ,
   ADRESSE CHAR(32) NULL  ,
   CP CHAR(32) NULL  ,
   VILLE CHAR(32) NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : TRAVERSEE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TRAVERSEE
 (
   ID CHAR(32) NOT NULL  ,
   ID_REALISER CHAR(32) NOT NULL  ,
   ID_EFFECTUER CHAR(32) NOT NULL  ,
   DATE DATE NOT NULL  ,
   HEURE TIME NOT NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE TRAVERSEE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_TRAVERSEE_LIAISON
     ON TRAVERSEE (ID_REALISER ASC);

CREATE  INDEX I_FK_TRAVERSEE_BATEAU
     ON TRAVERSEE (ID_EFFECTUER ASC);

# -----------------------------------------------------------------------------
#       TABLE : RESERVATION
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS RESERVATION
 (
   ID CHAR(32) NOT NULL  ,
   ID_RESERVER CHAR(32) NOT NULL  ,
   ID_CONCERNER CHAR(32) NOT NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE RESERVATION
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_RESERVATION_CLIENT
     ON RESERVATION (ID_RESERVER ASC);

CREATE  INDEX I_FK_RESERVATION_TRAVERSEE
     ON RESERVATION (ID_CONCERNER ASC);

# -----------------------------------------------------------------------------
#       TABLE : CATEGORIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CATEGORIE
 (
   ID CHAR(32) NOT NULL  ,
   LIBELLE CHAR(32) NOT NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : EQUIPEMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EQUIPEMENT
 (
   ID CHAR(32) NOT NULL  ,
   LIBELLE CHAR(32) NOT NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : PARTICIPER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PARTICIPER
 (
   ID CHAR(32) NOT NULL  ,
   ID_1 CHAR(32) NOT NULL  ,
   NOMBRE CHAR(32) NULL  
   , PRIMARY KEY (ID,ID_1) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE PARTICIPER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_PARTICIPER_RESERVATION
     ON PARTICIPER (ID ASC);

CREATE  INDEX I_FK_PARTICIPER_TYPE
     ON PARTICIPER (ID_1 ASC);

# -----------------------------------------------------------------------------
#       TABLE : PROPOSER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PROPOSER
 (
   ID CHAR(32) NOT NULL  ,
   ID_1 CHAR(32) NOT NULL  ,
   QUANTITE CHAR(32) NULL  
   , PRIMARY KEY (ID,ID_1) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE PROPOSER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_PROPOSER_BATEAU
     ON PROPOSER (ID ASC);

CREATE  INDEX I_FK_PROPOSER_EQUIPEMENT
     ON PROPOSER (ID_1 ASC);

# -----------------------------------------------------------------------------
#       TABLE : TARIFER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TARIFER
 (
   ID CHAR(32) NOT NULL  ,
   ID_1 CHAR(32) NOT NULL  ,
   ID_2 CHAR(32) NOT NULL  ,
   TARIF CHAR(32) NULL  
   , PRIMARY KEY (ID,ID_1,ID_2) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE TARIFER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_TARIFER_LIAISON
     ON TARIFER (ID ASC);

CREATE  INDEX I_FK_TARIFER_PERIODE
     ON TARIFER (ID_1 ASC);

CREATE  INDEX I_FK_TARIFER_TYPE
     ON TARIFER (ID_2 ASC);

# -----------------------------------------------------------------------------
#       TABLE : CONTENIR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CONTENIR
 (
   ID CHAR(32) NOT NULL  ,
   ID_1 CHAR(32) NOT NULL  ,
   NBMAX CHAR(32) NULL  
   , PRIMARY KEY (ID,ID_1) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE CONTENIR
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_CONTENIR_BATEAU
     ON CONTENIR (ID ASC);

CREATE  INDEX I_FK_CONTENIR_CATEGORIE
     ON CONTENIR (ID_1 ASC);


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE LIAISON 
  ADD FOREIGN KEY FK_LIAISON_SECTEUR (ID_REGROUPER)
      REFERENCES SECTEUR (ID) ;


ALTER TABLE LIAISON 
  ADD FOREIGN KEY FK_LIAISON_PORT (ID_DEPART)
      REFERENCES PORT (ID) ;


ALTER TABLE LIAISON 
  ADD FOREIGN KEY FK_LIAISON_PORT1 (ID_ARRIVEE)
      REFERENCES PORT (ID) ;


ALTER TABLE TYPE 
  ADD FOREIGN KEY FK_TYPE_CATEGORIE (ID_CLASSER)
      REFERENCES CATEGORIE (ID) ;


ALTER TABLE TRAVERSEE 
  ADD FOREIGN KEY FK_TRAVERSEE_LIAISON (ID_REALISER)
      REFERENCES LIAISON (ID) ;


ALTER TABLE TRAVERSEE 
  ADD FOREIGN KEY FK_TRAVERSEE_BATEAU (ID_EFFECTUER)
      REFERENCES BATEAU (ID) ;


ALTER TABLE RESERVATION 
  ADD FOREIGN KEY FK_RESERVATION_CLIENT (ID_RESERVER)
      REFERENCES CLIENT (ID) ;


ALTER TABLE RESERVATION 
  ADD FOREIGN KEY FK_RESERVATION_TRAVERSEE (ID_CONCERNER)
      REFERENCES TRAVERSEE (ID) ;


ALTER TABLE PARTICIPER 
  ADD FOREIGN KEY FK_PARTICIPER_RESERVATION (ID)
      REFERENCES RESERVATION (ID) ;


ALTER TABLE PARTICIPER 
  ADD FOREIGN KEY FK_PARTICIPER_TYPE (ID_1)
      REFERENCES TYPE (ID) ;


ALTER TABLE PROPOSER 
  ADD FOREIGN KEY FK_PROPOSER_BATEAU (ID)
      REFERENCES BATEAU (ID) ;


ALTER TABLE PROPOSER 
  ADD FOREIGN KEY FK_PROPOSER_EQUIPEMENT (ID_1)
      REFERENCES EQUIPEMENT (ID) ;


ALTER TABLE TARIFER 
  ADD FOREIGN KEY FK_TARIFER_LIAISON (ID)
      REFERENCES LIAISON (ID) ;


ALTER TABLE TARIFER 
  ADD FOREIGN KEY FK_TARIFER_PERIODE (ID_1)
      REFERENCES PERIODE (ID) ;


ALTER TABLE TARIFER 
  ADD FOREIGN KEY FK_TARIFER_TYPE (ID_2)
      REFERENCES TYPE (ID) ;


ALTER TABLE CONTENIR 
  ADD FOREIGN KEY FK_CONTENIR_BATEAU (ID)
      REFERENCES BATEAU (ID) ;


ALTER TABLE CONTENIR 
  ADD FOREIGN KEY FK_CONTENIR_CATEGORIE (ID_1)
      REFERENCES CATEGORIE (ID) ;
