USE BasePatrimonios;
GO

--Exemplos para tabela de Marcas
INSERT INTO Marcas(Nome) VALUES("Takashi Retífica")
INSERT INTO Marcas(Nome) VALUES("Funilaria João")

--Exemplos de dados para a tabela de patrimonios
INSERT INTO Patrimonios(MarcaID,Nome,Descricao) VALUES(1,'Furadeia','Furadeira de Bancada')
INSERT INTO Patrimonios(MarcaID,Nome,Descricao) VALUES(1,'Computadores','Computadores para calibração')
INSERT INTO PAtrimonios(MarcaID,Nome,Descricao) VALUES(1,'Torno','Torno CNC')
INSERT INTO PAtrimonios(MarcaID,Nome,Descricao) VALUES(1,'Fresa','Fresa CNC')
INSERT INTO PAtrimonios(MarcaID,Nome,Descricao) VALUES(1,'Eletro-Erosao','Máquina de trabalho de eletro-erosão')

INSERT INTO Patrimonios(MarcaID,Nome,Descricao) VALUES(2,'Compressor','Compressor de ar')
INSERT INTO Patrimonios(MarcaID,Nome,Descricao) VALUES(2,'Solda MIG','Máquina de solda')
INSERT INTO Patrimonios(MarcaID,Nome,Descricao) VALUES(2,'Parafusadeira','Parafusadeira pneumática')

