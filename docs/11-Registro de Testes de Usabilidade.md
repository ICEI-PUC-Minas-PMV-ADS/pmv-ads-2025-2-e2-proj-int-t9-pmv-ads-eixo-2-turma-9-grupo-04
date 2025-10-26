# Registro de Testes de Usabilidade

O registro de testes de usabilidade é um documento ou planilha onde são coletadas e organizadas as informações sobre a experiência dos usuários ao interagir com um sistema. Ele inclui dados como tempo de execução de tarefas, taxa de sucesso, dificuldades encontradas, erros cometidos e _feedback_ dos usuários. Esse registro permite identificar padrões de uso, obstáculos/dificuldades encontrados na interface e oportunidades de melhoria, fornecendo _insights_ quantitativos e qualitativos para otimizar a experiência do usuário. Além disso, serve como base para análises, correções e futuras iterações do sistema, garantindo que ele atenda às necessidades do público-alvo de forma eficiente.

## Perfil dos usuários que participaram do teste
 * Usuário 1: 22 anos, estudante universitário, superior incompleto, conhecimento avançado de tecnologia.
 * Usuário 2: 34 anos, profissional de marketing, superior completo, conhecimento médio de tecnologia.
 * Usuário 3: 58 anos, autônomo, ensino médio completo, conhecimento básico de tecnologia.
 * Usuário 4: 29 anos, atleta amador, superior completo, conhecimento avançado de tecnologia.
 * Usuário 5: 47 anos, funcionária pública, ensino médio completo, conhecimento básico de tecnologia.


## Tabela de registro dos testes de usabilidade  

**Cenário 1**: O usuário precisa se cadastrar e preencher todas as informações solicitadas.
| **Usuários**   | **Tempo Total (seg)** | **Quantidade de cliques** | **Tarefa foi concluída?** (Sim/Não) | **Erros Cometidos** | **Feedback do Usuário** |
|-------------|--------------------|---------------------------------|-----------------|------------------------|------------------------------|
| Usuário 1    |   40 seg    |    10   |     Sim    |  Nenhum    |   "Bem rápido, achei o de sempre. O cadastro foi fácil de preencher."   |           |      
| Usuário 2    |   65 seg    |    14     |       Sim          |     Nenhum   |   "Processo tranquilo, padrão de outros cadastros"                       |                     |      
| Usuário 3    |   180 seg    |     32   |        Sim         |  Demorou para achar a cidade. Rolou a lista manualmente     |        "Demorei para achar minha cidade na lista"                      |                     |  
| Usuário 4    |   75 seg    |   16      |     Sim     |  Nenhum   |     "Funcionou tudo como esperado"                        |                     | 
| Usuário 5    | 150 seg    |    26      |   Sim   | Tentou avançar sem preencher todos os dados corretamente |   "Poderia mostrar melhor o que falta preencher"   |                     | 

**Cenário 2**:  O usuário precisa criar um grupo e preencher todos os requisitos.     
| **Usuário**  | **Tempo Total (seg)** | **Quantidade de cliques** | **Tarefa foi concluída?** (Sim/Não) | **Erros Cometidos** | **Feedback do Usuário** |
|-------------|--------------------|---------------------------------|-----------------|------------------------|------------------------------|
| Usuário 1   |        35 seg    |              9                   |     Sim            |       Nenhum                 |          "Consegui preencher os campos sem problemas"   |                     |      
| Usuário 2   |        60 seg    |             9                    |        Sim         |        Nenhum                |            "Criar o grupo foi bem fácil, mas selecionar a modalidade numa lista ou dar sugestões, facilitariam muito"               |                     |      
| Usuário 3   |        187 seg   |       20           |        Sim         |          Clicou em "cancelar" ao invés de salvar   |  "Tive que refazer tudo, seria melhor se tivesse um aviso antes de cancelar"                 |                     |  
| Usuário 4   |        72 seg    |              11                   |      Sim           |     Nenhum                   |         "Achei a interface simples, sem muitas coisas complicadas"                   |                     | 
| Usuário 5   |         145 seg  |              15                   |       Sim          |      Nenhum, apenas demorou para preencher os dados    |    "Achei difícil porque precisava escrever tudo, não tem jeito mais rápido"     |                     | 

## Relatório dos testes de usabilidade 

### Objetivo:
Avaliar a usabilidade do sistema em dois cenários: cadastro de usuário e criação de grupo, identificando problemas, dificuldades e propondo melhorias.

### Cenário 1: Cadastro de usuário

**Análise Quantitativa**
- Taxa de sucesso: 100%
- Tempo médio de conclusão: 102 segundos
- Número médio de cliques: 19,6
- Erros médios por usuário: 0,2
- Taxa de abandono: 0%

**Principais dificuldades e padrões observados:**
- Encontrar a cidade na lista foi problemático para alguns usuários.
- Falta de feedback visual sobre campos obrigatórios causou erro de preenchimento.

**Sugestões de melhoria:**
- __*Crítico*__: Nenhum
- __*Moderado*__: Implementar filtro ou pesquisa rápida para seleção de cidade e adicionar indicação clara dos campos obrigatórios e mensagens de alerta quando um campo não estiver preenchido corretamente.
- __*Leve*__: Revisar fluxo para reduzir o número de cliques e otimizar o tempo de cadastro.

### Cenário 2: Criação de grupo

**Análise Quantitativa**
- Taxa de sucesso: 100%
- Tempo médio de conclusão: 99,8 segundos
- Número médio de cliques: 12,8
- Erros médios por usuário: 0,2
- Taxa de abandono: 0%

**Principais dificuldades e padrões observados:**
- Risco de clicar em "cancelar" sem aviso.
- Seleção de modalidades ou preenchimento longos pode confundir usuários.
- Escrever todas as informações manualmente pode ser cansativo e demorado.

**Sugestões de melhoria:**
- __*Crítico*__: Adicionar confirmação antes de cancelar ou sair da tela para evitar perda de dados.
- __*Moderado*__: Implementar sugestões automáticas ou listas filtráveis para campos de seleção.
- __*Leve*__: Permitir salvamento parcial ou preenchimento rápido para otimizar o tempo.

### Conclusão
O sistema apresenta uma taxa de sucesso de 100% e interface simples, sem registros de abandono.
Principais dificuldades incluem campos de seleção longa, falta de feedback visual, risco de cancelamento acidental e processos demorados de preenchimento manual.

**Prioridade de ação:**
- __*Crítico*__: Cancelamento acidental.
- __*Moderado*__: Seleção de listas longas, e campos obrigatórios sem feedbacks claros.
- __*Leve*__: Fluxos demorados.

**Propostas de melhorias:**
- Adicionar feedback visual e alertas em tempo real para campos obrigatórios.
- Implementar pesquisa rápida em listas (cidades, modalidades).
- Adicionar confirmação ao cancelar para evitar perda de dados.
- Otimizar o preenchimento de formulários longos com sugestões ou auto-preenchimento.
- Revisar fluxo de cliques para reduzir esforço do usuário e aumentar eficiência.
