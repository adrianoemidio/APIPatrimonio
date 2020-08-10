USE BasePatrimonios;
go

CREATE TABLE Marcas(
	MarcaId BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nome VARCHAR(255) UNIQUE NOT NULL,

);

CREATE TABLE Patrimonios(

	MarcaId BIGINT    NOT NULL,
	Nome VARCHAR(255) NOT NULL,
	Descricao TEXT,
	N_Tombo BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL

);
ALTER TABLE Patrimonios
ADD CONSTRAINT fk_MarcaPatri FOREIGN KEY (MarcaId) REFERENCES Marcas (MarcaId)

