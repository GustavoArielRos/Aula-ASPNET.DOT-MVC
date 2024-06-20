01 – CRIANDO O MODEL “EXPENSE”

-As  views são a parte da visualização do site aquilo que o usuário vê
-la que tem o html

 ![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/91117115-0fc9-45e7-a68d-171996e1141c)


- aquilo que colocamos na base de dados(database) é aquilo que colocamos nos modelos(Models)


![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/caf63f61-0ffa-4bcd-a7e1-2eb08b776b9b)

 
- o Required obriga a gente colocar um valor  naquele método

  
 ![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/3baffa73-6362-45d1-bfb7-d940986a6dc1)


02 – ADICIONANDO O PRIMEIRO VIEW E AJUSTANDO O TEMPLATE




-Temos que criar uma view para esse model criado 

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/25481bff-9f60-4b0b-b248-603bd87cac40)
 
- isso é aquele título que aparece la em cima na aba da página

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/640dddcf-2f50-4ca4-8948-1ec8d3623562)
 
 
- em “program.cs” no “app.MapControllerRoute” define o padrão de caminho 
 
![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/e0983e41-1748-4022-8ff7-10249d0aa8f0)



- tenho que ir no HomeController.ca para ter o método que retorna o view da página criada

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/988286a3-ba6f-42de-94e4-24e5a7db9c30)

 
- conseguimos agora entrar nessa view pela url , porém temos que criar um caminho
- Na página Shared no arquivo “Layout.cshtml” é onde devemos criar o link para poder levar o usuário até a essa página

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/2e091601-1281-4007-9541-c49329994d35)

 
- Só tem que trocar o “asp-action” para Expense

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/f3755a98-6a48-4944-a354-3cf0dd945726)

  
 
- alterando o “index” que é a view principal , nelavai o botão que leva para a página 
- agora clicando ali você muda para a página expenses

03 – Criando novas “expenses”(gastos)”
- a home esta dentro de view
- na home vamos criar uma new view
- razor  view – empty

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/a4a73f30-84ee-461f-a7d3-c6014b9f2bc0)


 
- no homecontroller vamos criar essa pagina
- no home controller criamos os métodos que chamam as páginas criadas

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/0d028ac7-6d52-499b-8eb7-aa1d5d1f1e56)
 
- Criando o botão na principal que vai levar o usuário até essa página

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/fc48cca1-af03-4d79-89fb-22addc96decf)


- só lembrar de trocar o nome do botão que ta como “Overview”
- agora no html da  página createedit expense montaremos o que o usuário irá ver nela


![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/cfc37dfa-05da-4434-b867-5f02c960087d)

 

- perceba acima que eu importei o “model” para usar os o expense.cs e no input no “asp-for” ele tem haver com as variavels que eu coloquei no models
- agora eu quero que quando o usuário preencher o formulário os dados sejam captados e ele seja redirecionado para a página dos Expenses() gastos

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/50cab7e3-46f2-43a9-8c39-b3e356e32bc5)

 
![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/2232ce77-de2e-45c2-874a-1e42fec503d1)

 
- perceba que o HomeController sempre trabalha com as páginas  e nesse esse método recebe as informações do formulário no parâmetro e seu return é um redirecionamento para a página “Expenses”






04 – CONECTANDO UM FRAMEWORK DE ENTIDADE NO BASE DE DADOS DA MEMORIA

- vamos criar um database para pegar as informações do forms
- idenpendente de armazenar na memoria ou no sql vamos usar a entidade
- tem que baixar isso 


![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/54c284ac-ce26-484a-85aa-e3a478dbc742)


 
- nesse caso a gente vai armazenar essas informações na nossa RAM na memoria do pc mesmo

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/a9a84b64-5075-45a6-89cb-f5e207069511)

 
- Vamos criar uma classe DbContext para termos ali a configuração de banco de dados do nosso programa

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/cdaa1f16-8ed6-4cd7-9864-a9108ecdc64d)

  
- temos que realizar um builder no “Program.cs” para realmente termos acesso a esse db
- na real é basicamente configurar para levar o dado a onde será armazenado


![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/98280969-4f37-4ec8-898a-7067f0b6e7eb)

- vamos no homecontroller fazer essa chamada de contexto

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/123039c5-cb64-4f7d-aa56-db3df5ca75a8)

 
- vamos fazer isso pq recebemos as informações do formulário no método que ta em HomeController


![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/630139fa-a48d-424c-b274-43719ba68e68)


05 – MOSTRANDO UMA VISÃO GERAL DE TODAS AS “EXPENSES”(GASTOS)

- perceba que agora essa view recebe algo que é o allExpenses

 ![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/7dd3a17d-1ca8-4d38-9d39-f36a46b3d24a)

 ![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/212260ac-31cd-407c-9427-f6f550ddc0ca)

 ![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/cf0345d5-7590-4cc8-bfba-c7673d595dcb)


 
06 – “delete” e “edit” “EXPENSES”(GASTOS)

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/84b80a55-c577-46d0-9da2-44a592dc3d2a)

 
- perceba que eu estou acionando a página “CreateEditExpense” e passando para ela o valor do id, então la na homecontroller eu tenho que fazer que essa página receba no parâmetro isso

- o delete é mais simples de fazer

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/ff11046f-ea1f-44dd-9d46-1e27349b71c6)

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/3e205a0b-8e04-4bfa-855b-275f79cd55bc)
 
- o para fazermos o edit , temos que modificar algumas coisas

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/e918d47a-ce40-496f-ac96-8e8418404d70)

- temos que modificar também o nosso ExpenseForm
- antes do forms entrar no banco seu id é sempre igual a zero,por isso que a gente faz essa verificação antes

 ![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/e3597782-1c8c-4d34-955b-25958b4574d6)

![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/1d7379a3-b63c-4dc7-b43d-402bc3dada81)

 
- coloque o id oculto pq agora ele já cria automaticamente

06 – FAZER O TOTAL DE “EXPENSES”
 
![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/d90ca178-b611-4e18-bb91-78cd11f7d2ea)

 
![image](https://github.com/GustavoArielRos/Aula-ASPNET.DOT-MVC/assets/101509337/36d64c01-aaae-4ca7-9620-da87da0028bb)

