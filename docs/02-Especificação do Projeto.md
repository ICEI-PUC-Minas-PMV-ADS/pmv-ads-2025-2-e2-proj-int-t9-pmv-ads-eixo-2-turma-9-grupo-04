https://github.com/user-attachments/assets/cdd32c84-e8bd-412d-81b6-e91ef6e3ec0c
# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Apresentação do Projeto


## Personas

### Persona 1
<img width="856" height="510" alt="Giovanna Elisa Pereira" src="https://github.com/user-attachments/assets/ad23b670-6a97-4c6c-bb42-f78b250a0fcd" />

### Persona 2 
<img width="856" height="510" alt="Pedro Souza dos Reis" src="https://github.com/user-attachments/assets/003ad835-bee8-4c7b-ba91-9de2bf78ae9f" />

### Persona 3
<img width="856" height="510" alt="Jorge Henrique Costa" src="https://github.com/user-attachments/assets/e12b74e2-f0d3-4ddf-94f3-b2904bf91d80" />

### Persona 4
<img width="856" height="510" alt="Priscila Martins Oliveira" src="https://github.com/user-attachments/assets/ada623aa-dbc5-49ab-a6a2-15daeffe7beb" />

### Persona 5
<img width="856" height="510" alt="William Porter Ferreira" src="https://github.com/user-attachments/assets/c798befb-d54c-4c60-96b2-982f9521a13e" />

### Persona 6
<img width="856" height="510" alt="Tereza Castro Rodriguez" src="https://github.com/user-attachments/assets/663734a6-e9be-42e0-90cc-cb9affe61a5e" />

## Histórias de Usuários

Com base na análise das personas foram identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Giovanna  | Participar de aulas de dança fitness em grupo          |Me exercitar de forma divertida e criar vínculos sociais               |
|Pedro      | Participar de jogos de futebol com grupos próximos               | Me manter ativo e conhecer novas pessoas |
|Jorge  | Encontrar grupos que se adaptem ao meu nível e tempo livre          | Aliviar o estresse sem comprometer meu dia          
|Priscila  |Praticar yoga e meditação em grupo          | Equilibrar mente e corpo, reduzindo o estresse        |
|William      | Achar amigos para treinar skate e funcionais ao ar livre               | Evoluir nas habilidades e me divertir ||
|Tereza      | Encontrar caminhadas e atividades leves para minha idade                |Cuidar da saúde, evitar lesões e socializar |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| A aplicação deve permitir o cadastro de usuários | ALTA | 
|RF-02 | A aplicação deve apresentar uma tela de login, para que os usuários cadastrados possam se identificar e acessar a aplicação    | ALTA |
|RF-03 | A aplicação deve apresentar uma tela de alteração cadastral de usuários, onde nela será possível a edição de informações fornecidas na etapa de cadastro | MÉDIA |
|RF-04 | A aplicação deve permitir a exclusão de usuários, para caso algum usuário não queira mais utilizar a aplicação  | MÉDIA |
|RF-05| A aplicação deve permitir a criação de grupos  | ALTA |
|RF-06| A aplicação deve permitir a entrada de usuários em grupos  | ALTA |
|RF-07| A aplicação deve permitir que um grupo tenha um número limite de participantes | BAIXA |
|RF-08| A aplicação deve permitir que um usuário administrador de um grupo exclua um integrante | MÉDIA |
|RF-09| A aplicação deve apresentar uma tela de edição de um grupo  | MÉDIA |
|RF-10| A aplicação deve permitir a exclusão de um grupo | MÉDIA |
|RF-11| A aplicação deve permitir a pesquisa de grupos, seja por nome ou localidade | MÉDIA |
|RF-12| A aplicação deve permitir que o usuário saia de um grupo em que ele é participante  | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| A aplicação deve ser responsiva, sendo possível acessá-la a partir da maioria dos dispositivos disponíveis | ALTA | 
|RNF-02| A aplicação deve possuir um sistema de autenticação e autorização, a fim de evitar que usuários alterem dados de um grupo onde ele não é administrador |  ALTA | 
|RNF-03| A aplicação deve possuir integrações com APIs externas  |  BAIXA | 
|RNF-04| A aplicação deve possuir mensagens de erros e sucessos claras, para assim proporcionar uma melhor experiência de usuário |  BAIXA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| A primeira etapa do projeto que consiste na documentação e levantamento de requisitos deve ser entregue até o dia 31/08/2025 |
|02| A segunda etapa do projeto que consiste na criação de wireframes, planos de testes e metodologia deve ser entregue até o dia 28/09/2025        |
|03| A terceira etapa do projeto que consiste na primeira parte do desenvolvimento da solução deve ser entregue até o dia 26/10/2025        |
|04| A quarta etapa do projeto que consiste na segunda parte do desenvolvimento da solução deve ser entregue até o dia 23/11/2025        |
|05| A quinta etapa do projeto que consiste na entrega da solução e dos relatórios de testes deve ser entregue até o dia 07/12/2025        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso
<img alt="Diagrama de Casos de Uso" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-2-e2-proj-int-t9-pmv-ads-eixo-2-turma-9-grupo-04/blob/c870d3724f6920e322c2ad22ddd2da5783556eb7/docs/img/DiagramaDeCasosDeUso.png"/>
O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
