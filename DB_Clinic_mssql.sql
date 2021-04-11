DROP DATABASE db_clinic;
CREATE DATABASE db_clinic;
USE db_clinic;


CREATE TABLE tb_turn (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    turn VARCHAR ( 20 ) NOT NULL UNIQUE
);
GO

CREATE TABLE tb_hour (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    entry TIME NOT NULL ,
    departure TIME NOT NULL ,
    id_turn INT NOT NULL ,
    FOREIGN KEY ( id_turn ) REFERENCES tb_turn ( id )
);
GO

CREATE TABLE tb_speciality (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    speciality VARCHAR ( 30 ) NOT NULL UNIQUE
);

CREATE TABLE tb_doctor (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    name VARCHAR ( 40 ) NOT NULL ,
    a_p VARCHAR ( 40 ) NOT NULL ,
    a_m VARCHAR ( 40 ) NOT NULL ,
    dni CHAR ( 8 ) NOT NULL UNIQUE ,
    password VARCHAR ( 256 ) NOT NULL ,
    id_hour INT NOT NULL ,
    id_speciality INT NOT NULL ,
	state BIT DEFAULT 1,
    FOREIGN KEY ( id_hour ) REFERENCES tb_hour ( id ) ,
    FOREIGN KEY ( id_speciality ) REFERENCES tb_speciality ( id )
);

CREATE TABLE tb_gender (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    gender VARCHAR ( 20 ) NOT NULL UNIQUE
);

CREATE TABLE tb_marital_status (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    marital_status VARCHAR ( 40 ) NOT NULL UNIQUE
);

CREATE TABLE tb_type_identification (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    type VARCHAR ( 40 ) NOT NULL UNIQUE
);

CREATE TABLE tb_health_insurance (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    name VARCHAR ( 50 ) NOT NULL UNIQUE
);

CREATE TABLE tb_clinic_history (
    id INT NOT NULL PRIMARY KEY
);

CREATE TABLE tb_district (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    district VARCHAR ( 50 ) NOT NULL UNIQUE , 
);

CREATE TABLE tb_patient (
    id VARCHAR ( 30 ) NOT NULL PRIMARY KEY ,
    name VARCHAR ( 30 ) NOT NULL ,
    a_p VARCHAR ( 50 ) NOT NULL ,
    a_m VARCHAR ( 50 ) NOT NULL ,
    phone CHAR ( 9 ) ,
    birthdate DATE NOT NULL ,
    address VARCHAR ( 50 ) NOT NULL ,
    seguro BIT NOT NULL DEFAULT 1 ,
    hopital_perteneciente VARCHAR ( 50 ) ,
    id_type_identification INT NOT NULL ,
    id_gender INT NOT NULL ,
    id_marital_status INT NOT NULL ,
    id_clinic_history INT NOT NULL ,
    id_health_insurance INT NOT NULL ,
    id_district INT NOT NULL ,
	state BIT DEFAULT 1,
    FOREIGN KEY ( id_gender ) REFERENCES tb_gender ( id ) ,
    FOREIGN KEY ( id_type_identification ) REFERENCES tb_type_identification ( id ) ,
    FOREIGN KEY ( id_marital_status ) REFERENCES tb_marital_status ( id ) ,
    FOREIGN KEY ( id_clinic_history ) REFERENCES tb_clinic_history ( id ) ,
    FOREIGN KEY ( id_health_insurance ) REFERENCES tb_health_insurance ( id ) ,
    FOREIGN KEY ( id_district ) REFERENCES tb_district ( id )
);

CREATE TABLE tb_diagnosis (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    reasons_for_consultation VARCHAR ( 80 ) NOT NULL ,
    current_illness VARCHAR ( 50 ) ,
    pathological_history VARCHAR ( 100 ) ,
    id_clinic_history INT NOT NULL ,
    id_doctor INT NOT NULL ,
    FOREIGN KEY ( id_clinic_history ) REFERENCES tb_clinic_history( id ) ,
    FOREIGN KEY ( id_doctor ) REFERENCES tb_doctor( id )
);

CREATE TABLE tb_receptionist (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    name VARCHAR ( 40 ) NOT NULL ,
    a_p VARCHAR ( 40 ) NOT NULL ,
    a_m VARCHAR ( 40 ) NOT NULL ,
    dni CHAR ( 8 ) NOT NULL UNIQUE ,
    password VARCHAR ( 256 ) NOT NULL,
	state BIT DEFAULT 1
);

CREATE TABLE tb_contrareferencia (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    est_ref_name VARCHAR ( 50 ) NOT NULL ,
    est_ref_dir VARCHAR ( 80 ) NOT NULL ,
    est_contref_name VARCHAR ( 50 ) NOT NULL ,
    est_contref_dir VARCHAR ( 80 ) NOT NULL ,
    est_contref_diagnosis VARCHAR( 80 ) NOT NULL ,
    treatment VARCHAR ( 100 ) ,
    ind_aps VARCHAR ( 256 ),
    date_contref DATE NOT NULL ,
    id_patient VARCHAR ( 30 ) NOT NULL ,
    id_doctor INT NOT NULL ,
    id_receptionist INT NOT NULL ,
	state BIT DEFAULT 1,
    FOREIGN KEY ( id_patient ) REFERENCES tb_patient ( id ) ,
    FOREIGN KEY ( id_doctor ) REFERENCES tb_doctor ( id ) ,
    FOREIGN KEY ( id_receptionist ) REFERENCES tb_receptionist ( id )
);

CREATE TABLE tb_appointment (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    hour TIME NOT NULL ,
    date DATE NOT NULL ,
    id_doctor INT NOT NULL ,
    id_patient VARCHAR ( 30 ) NOT NULL ,
    id_receptionist INT NOT NULL ,
	state BIT DEFAULT 1,
    FOREIGN KEY ( id_doctor ) REFERENCES tb_doctor ( id ) ,
    FOREIGN KEY ( id_patient ) REFERENCES tb_patient ( id ) ,
    FOREIGN KEY ( id_receptionist ) REFERENCES tb_receptionist ( id )
);

CREATE TABLE tb_cashier (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    name VARCHAR ( 40 ) NOT NULL ,
    a_p VARCHAR ( 40 ) NOT NULL ,
    a_m VARCHAR ( 40 ) NOT NULL ,
    dni CHAR ( 8 ) NOT NULL UNIQUE ,
	state BIT DEFAULT 1,
    password VARCHAR ( 256 ) NOT NULL
);

CREATE TABLE tb_proof_of_purchase (
    id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
    id_appointment INT NOT NULL UNIQUE ,
    id_cashier INT NOT NULL ,
    FOREIGN KEY ( id_appointment ) REFERENCES tb_appointment ( id ) ,
    FOREIGN KEY ( id_cashier ) REFERENCES tb_cashier ( id )
);

DROP TABLE tb_turn;
DROP TABLE tb_hour;
DROP TABLE tb_speciality;
DROP TABLE tb_doctor;
DROP TABLE tb_gender;
DROP TABLE tb_marital_status;
DROP TABLE tb_type_identification;
DROP TABLE tb_health_insurance;
DROP TABLE tb_clinic_history;
DROP TABLE tb_district;
DROP TABLE tb_patient;
DROP TABLE tb_diagnosis;
DROP TABLE tb_receptionist;
DROP TABLE tb_contrareferencia;
DROP TABLE tb_appointment;
DROP TABLE tb_cashier;
DROP TABLE tb_proof_of_purchase;

select * from tb_patient





