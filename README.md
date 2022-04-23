# TestePlenoAudaz
Tarefa para processo seletivo onde o código precisa cadastrar uma tarifa de ônibus relacionando as entidades "Operator" e "Fare", onde "Fare" é a tarifa e "Operator" a operadora de benefício de vale-transporte. Uma "Fare" só pode ser cadastrada caso aquela operadora não possua nenhuma tarifa ativa (Fare.Status == 1) de mesmo valor dentro de um período de 6 meses.

# FrameWorks utilizados 
FluentValidation.AspNetCore" Version="9.1.2
Microsoft.EntityFrameworkCore" Version="3.1.8
Microsoft.EntityFrameworkCore.Design" Version="3.1.8
Microsoft.EntityFrameworkCore.SqlServer" Version="3.1.8
Microsoft.EntityFrameworkCore.Tools" Version="3.1.8
Swashbuckle.AspNetCore" Version="5.6.3

Para o projeto rodar basta apontar a string de conexão do seu banco de dados SQLServer na "appsettings.json" e rodar os seguintes scripts da Migration para criar as 
tabelas em seu banco 

add-migration NomeDaMigration
update-database
