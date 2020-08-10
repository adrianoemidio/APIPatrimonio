# APIPatrimonio
Uma API para controle de patrimonio

Adriano (adriano.emidio0@gmail.com)

* Aviso Legal: Este programa é apenas uma demostração e seu uso é autorizado para qualquer finalidade, desde que obedecidos os regimentos da lei. O Autor não se resposabiliza por nenhum dano ou perca de dados causados ao usuário ou à terceiros decorrente do uso deste software. 

O software foi testado utilizando as seguintes configurações de software:
* SO: Manjaro Linux 5.7.9-1 x86_64
* Dot Net Core 3.1.103
* Microsoft SQL Server 2019 (RTM-CU5) (KB4552255) - 15.0.4043.16 Developer Edition (64-bit) on Linux

Caso haja qualquer problema em configurar a aplicação em outras configuração de software, sinta-se a vontade de me contatar por e-mail.

# Sobre a solução

Para resover o problema dado, foi pensado uma arquitetura simples do bando de dados. Foi considerado que o projeto seria implantando em uma nova base de dados chamada BasePatrimonios. Foi criada duas tabelas, uma para se amarzenar os dados da marca e outra para se armazenar os patrimonios. Considerando como chave para a tabela marcas o campo MarcaId e para os patrimônios o campo N_Tombo. O campo MarcaId dentro da tabela patrimonios é uma chave estrangeira tendo seu valor atrelado
a uma marca, assim, para cada patrimonio, haverá uma marca que é propritária deste patrimônio. Nesta solução não se pode haver patrimonios sem uma marca proprietária, deste modo, caso se queira deletar uma marca, seus patrimônios serão deleatdos automaticamente.

A implementação da API em C# foi realizada em camadas, onde cada camada está ligado à um diretório dentro do repositório. Os Diretórios que contém o código são:
* Models: Declaração das classes da entidades.
* DAL: Intefaces e classes de acessos aos dados no banco de dados realizando as operações CRUD.
* Controller: Implementação dos controles para a API.
* SQL: Scripts para inicialização do Banco de dados.

* Endpoints Patrimônios:

        ◦ GET patrimonios - Obter todos os patrimônios 
        ◦ GET patrimonios/{id} - Obter um patrimônio por ID 
        ◦ POST patrimonios - Inserir um novo patrimônio 
        ◦ PUT patrimonios/{id} - Alterar os dados de um patrimônio 
        ◦ DELETE patrimonios/{id} - Excluir um patrimônio 

* Endpoints Marcas:

        ◦ GET marcas - Obter todas as marcas 
        ◦ GET marcas/{id} - Obter uma marca por ID 
        ◦ GET marcas/{id}/patrimônios – Obter todos os patrimônios de uma marca 
        ◦ POST marcas - Inserir uma nova marca 
        ◦ PUT marcas/{id} - Alterar os dados de uma marca 
        ◦ DELETE marcas/{id} - Excluir uma marca
        
 # Instruções de Execução:
 
 * Configurando o banco de dados: Deve-se executar o script "create_objects.sql", para se criar as tabelas e o script "load_data.sql" que preeche alguns dados para exemplo.
 
 * Configurando o programa: Na linha 3 do aqruivo "appsettings.json" deve se inserir as configurações do servidor. Após isso é só construir tulizando o comando: "dotnet build" e executando com o comando "dotnet run".
        
        


