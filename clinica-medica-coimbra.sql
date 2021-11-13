-- Clínica Médica de Coimbra
-- Script de criação da base de dados

CREATE DATABASE `clinica_medica_coimbra`
	CHARACTER SET utf8
    COLLATE utf8_general_ci;

USE `clinica_medica_coimbra`;

CREATE TABLE `utilizadores` (
	`ID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Username` VARCHAR(20) NOT NULL,
    `Password` VARCHAR(255) DEFAULT NULL
);

CREATE TABLE `especialidades` (
	`ID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Designacao` VARCHAR(100) NOT NULL
);

CREATE TABLE `sistemas_saude` (
	`ID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Designacao` VARCHAR(100) NOT NULL
);

CREATE TABLE `medicos` (
	`ID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Nome` VARCHAR(255)  NOT NULL,
    `Especialidade_ID` INT(11) DEFAULT NULL,
    
    FOREIGN KEY (`Especialidade_ID`)
       REFERENCES `especialidades` (`ID`)
);

CREATE TABLE pacientes (
	`ID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Nome` VARCHAR(255) NOT NULL,
    `Email` VARCHAR(255) DEFAULT NULL,
    `Password` VARCHAR(255) DEFAULT NULL,
    `Morada` VARCHAR(255) DEFAULT NULL,
	`CodigoPostal` VARCHAR(8) DEFAULT NULL,
    `DataNascimento` DATE DEFAULT NULL,
	`NIF` VARCHAR(9) DEFAULT NULL,
	`Telefone` VARCHAR(9) DEFAULT NULL,
    `SistemaSaude_ID` INT(11) DEFAULT NULL,
    `NumeroSistemaSaude` VARCHAR(30) DEFAULT NULL,
    
    FOREIGN KEY (`SistemaSaude_ID`)
       REFERENCES `sistemas_saude` (`ID`)
);

CREATE TABLE `marcacoes` (
	`ID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Paciente_ID` INT(11) NOT NULL,
    `Medico_ID` INT(11) NOT NULL,
    `DataHora` DATETIME DEFAULT NULL,
    
    FOREIGN KEY (`Paciente_ID`)
       REFERENCES `pacientes` (`ID`),
       
    FOREIGN KEY (`Medico_ID`)
       REFERENCES `medicos` (`ID`)
);

-- INSERÇÃO DE DADOS

-- Utilizadores
INSERT INTO utilizadores(Username, Password) VALUES
('user1', '123');

-- Especialidades
INSERT INTO especialidades(Designacao) VALUES
('Cardiologia'),
('Dermatologia'),
('Gastrenterologia'),
('Medicina Dentária'),
('Medicina Geral e Familiar'),
('Medicina Interna'),
('Oftalmologia'),
('Ortopedia'),
('Pediatria'),
('Pneumologia');

-- Sistemas de Saúde
INSERT INTO sistemas_saude(Designacao) VALUES
('Açoreana - AdvanceCare'),
('ADSE'),
('Cruz Vermelha Portuguesa'),
('Fidelidade'),
('Generali - AdvanceCare'),
('Logo - AdvanceCare'),
('Medicare'),
('Multicare'),
('SAD GNR - Regime Convencionado'),
('SAD PSP - Regime Convencionado'),
('SNS - Serviço Nacional de Saúde');

-- Médicos
INSERT INTO `medicos`(`Nome`, `Especialidade_ID`) VALUES
('Benedita Neves', 9),
('João Coelho', 7),
('Domingos Rodrigues', 9),
('Afonso Rocha', 2),
('Domingos Costa', 1),
('Carina Costa', 5),
('Casimiro Santos', 5),
('Catarina Neves', 7),
('Daniel Mendes', 8),
('Daniel Oliveira', 10),
('João Simões', 3),
('Daniela Martins', 4);

-- Pacientes
INSERT INTO `pacientes`(`Nome`, `Email`, `Password`, `Morada`, `CodigoPostal`, `DataNascimento`, `NIF`, `Telefone`, `SistemaSaude_ID`, `NumeroSistemaSaude`) VALUES
('João Pereira', 'j.pereira@xyz.com', '123', 'Rua da Azenha, Póvoa do Pinheiro', '3025-139', '1982-01-01', '385974272', '911234567', 2, '01234567 SS'),
('Carlota Santos', 'carlota@xyz.pt', 'abc', 'Urbanização Bela Vista, Santa Clara', '3040-243', '1999-08-01', 769715839, 961234567, 7, '123456789'),
('Cidália Pereira', 'c.pereira@xyz.pt', '321', 'Rua de São Pedro, Almedina', '3000-370', '1960-03-12', '853929338', '921234567', 8, '987ABC4321');

-- Marcações
INSERT INTO `marcacoes`(`Paciente_ID`, `Medico_ID`, `DataHora`) VALUES
(1, 3, '2021-10-26 09:30:00'),
(2, 6, '2021-06-22 11:00:00'),
(3, 1, '2022-01-08 12:00:00'),
(3, 5, '2021-04-25 19:30:00'),
(2, 12, '2021-03-04 09:45:00'),
(3, 1, '2022-01-08 09:30:00'),
(1, 1, '2022-01-08 10:00:00'),
(2, 10, '2021-11-05 11:30:00'),
(2, 1, '2021-09-09 15:00:00');
