# TournamentTracker
Aplicação desenvolvida para controle de torneios. Ao criar um torneio, a aplicação gera uma série de rodadas e uma sequência de chaves contendo os times participantes em cada rodada. Este Sistema foi desenvolvido ao longo do curso 'Create a C# Application from Start to Finish - Complete Course' na plataforma freecodecamp => https://www.freecodecamp.org/news/c-sharp-24-hour-course/

Após a finalização do curso, foram adicionadas a seguintes telas:
•	Tournaments Ratio (Relação de torneios) => Com diversos filtros para extrair a relação de torneios e fazer a sua análise dos torneios.
•	Tournaments Graphical View => Exibição gráfica das chaves e das rodadas de um torneio.
• Tela Initial Settings => para definir qual é o tipo de armazenamento de dados a ser utilizado (arquivo .txt ou sql server)
Também adicionado o botão Reset Initial Settings na telaTournamentsDashboardForm para permitir alternar entre os tipos de conexão.
• Botão Reset Initial Settings (Resetar configurações iniciais) para que o tipo de armazenamento de dados possa ser alternando (arquivo .txt ou sql server).

==== Testando o Sistema===
Para testar o Sitema: 
1) Baixe o arquivo TournamentTracker.rar que é a versão de liberação do Sitema
2) Copie para algum diretório e Descompacte na sua máquina.
3) Execute o arquivo setup.exe e comece a usar.

=== Utilizando o armazenamento em SQL Server==
Para utilizar o armazenamento em SQL Server
1) Tenha o Sql Server instalado na máquina (à partir do 2008 R2)
2) Crie um banco com o nome Tournaments.
3) Execute o arquivo TournamentTracker Structure.sql para criar a estrutura do banco (tabelas, procedures, etc.)
4) Pronto! agora é só executar o programa. Na tela Inital Settings, ao escolher a opção SQL Server, é possivel fazer um teste de conexão para verificar se está tudo certo.

