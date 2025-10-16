📌 Desafio em C#

Foi proposto o seguinte desafio pelo senai A ExoApi contratou você para desenvolver a nova demanda que será realizada para o lançamento de seu novo aplicativo. O aplicativo consiste em armazenar todos os projetos que a empresa realiza para ter maior controle e melhorar a gestão e visibilidade do que está sendo feito por seus funcionários.
  
A aplicação deverá ter também uma área de usuários responsável pelas permissões de acesso.
  
Essa demanda consiste em desenvolver a interface (API) para disponibilizar os dados que serão apresentados e utilizados pela equipe de mobile e exige os seguintes critérios:
Ler todos os projetos (id do projeto, nome do projeto, área e status) e usuários (id do usuário, e-mail e senha) da aplicação;
Buscar informações somente de um projeto ou usuário;
Deletar um projeto ou usuário;
Atualizar todas as informações de um projeto/usuário ou somente uma informação específica;
Disponibilizar a documentação da API;
Retornar os status de respostas corretos de acordo com as melhores práticas;
Retornar os dados em formato JSON;
Utilizar frameworks para a criação de API;
Disponibilizar o recurso de deletar ou atualizar um projeto, somente para usuários que possuem permissão.
  

Para concluir esse projeto, você deverá solucionar os seguintes desafios:
Desenvolver a API do aplicativo, disponibilizando os recursos para leitura, escrita, atualização e deleção dos projetos e usuários.
Restringir o acesso aos recursos da API aos usuários autenticados, visando a integridade e segurança da informação.


🚀 Tecnologias

Linguagem: C#

Banco de Dados: SQL Server

Framework: .NET 9.0

Tipo de aplicação: WebApi


⚙️ Como Executar

Pré-requisitos: Instalar o .NET SDK (versão recomendada: 8.0 e 9.0), Banco de Dados SQL Server

Clonar o repositório git clone https://github.com/RafasDev/https://github.com/RafasDev/ExoApi.git

Compilar e executar no terminal use: dotnet run, e coloque no postman ou no insomnia https://localhost:7154

!Atenção! atualizar ou deletar usuários ire ser necessário gerar um token com 15 minutos de validade.
