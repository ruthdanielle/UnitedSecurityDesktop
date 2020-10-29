# UnitedSecurityDesktop
Projeto desktop para uma empresa fictícia feita em C# com integração com banco de dados local (SQL SERVER).
Tal projeto foi proposto pela Uninove como o projeto do semestre, feito também uma versão Web em PHP.

Nessa versão desktop, o usuário da United Security entra na aplicação através de um login que aparece no início da execução da aplicação. Ao ser feito o login, é aberto um formulário principal no qual é possível ver três botões: Um botão para a aba de cadastro e consulta de clientes, outro botão para cadastro e consulta de funcionários e por último um botão de ajuda com um tutorial de como mexer na aplicação e com uma breve história das diretrizes da empresa. 
Ao clicar no botão de cadastro de CLIENTE, é aberto um formulário com campos a serem preenchidos e um campo desativado, que é o código do cliente que será gerado automaticamente no banco de dados. 
Após fazer a inclusão do cliente, preenchendo as informações do cliente e selecionando os produtos que ele contratou nos checkboxes, e apertando no botão incluir, uma mensagem em pop-up aparece dizendo que a inclusão foi realizada com sucesso. Clicando no botão azul de CONSULTAR, é aberto outro formulário onde é possível ver em uma viewgrid todos os clientes cadastrados e quais produtos ele contratou (Produtos contratados indicados com 'SIM' e não contratados indicados com 'NÃO'). Selecionando o Cliente desejado e clicando no botao SELECIONAR, tais informações (até mesmo o código) são postos nos campos antes em branco. Então é possível fazer quaisquer alterações que desejar ou até mesmo excluir o cliente, clicando respectivamente nos botões ALTERAR e EXCLUIR. 

Voltando ao nosso menu principal na esquerda do formulário principal, é possível também ir para o formulário de funcionários clicando no botão que indica o cadastro de funcionário.  Lá, é usada a mesma fórmula para incluir, excluir, alterar e consultar. Tirando apenas os checkboxes que não são necessários nesse caso. 

No botão de AJUDA no menu principal, ao clicar nele automaticamente se abre uma aba no seu navegador principal onde em uma página html se pode ler um breve resumo das diretrizes da empresa e um tutorial para auxiliar aqueles com dificuldades em utilizar os formulários de cadastro.

