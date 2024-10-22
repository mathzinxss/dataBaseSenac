USE master;

CREATE DATABASE bdExemplo1
ON PRIMARY 
(NAME = 'bdExemplo1', FILENAME = 'C:\bdAulaInicial\mdf\bdExemplo1.mdf', SIZE=10MB, MAXSIZE=64, FILEGROWTH=10%)
LOG ON
(NAME = 'bdExemplo1_log', FILENAME = 'C:\bdAulaInicial\ldf\bdExemplo1.mdf', SIZE=10MB,MAXSIZE=64, FILEGROWTH=10%)