# Atividade-Curso-AppEventos
Atividade da Agenda 15 de DSII do Curso técnico de Desenvolvimento De sistemas:  
Professor responsavel JUSSIMAR NASCIMENTO LEAL  

# O que foi requisitado na atividade:
Desenvolva um projeto em .NET MAUI que contenha uma tela para Cadastro de Eventos.  
A tela deve solicitar dados básicos do evento, como:

Nome do evento;  
Data de início;  
Data de término;  
Número de participantes;  
Local do evento;  
Custo por participante.  
Requisitos da Atividade:  

1. Utilize o BindingContext para associar os dados do evento a uma model de classe Evento.  
 Essa model deve incluir as propriedades mencionadas, além de uma lógica que calcule a duração do evento em dias  
 e o custo total do evento com base no número de participantes.  
 
2. Use a classe DateTime para calcular a duração do evento e a classe TimeSpan para exibir essa diferença no aplicativo.  

3. O projeto deve permitir que, ao completar o cadastro, os dados sejam apresentados em uma nova página,  
 mostrando o resumo do evento com todas as informações formatadas corretamente e o custo total calculado.  

# O que foi feito:

→ Estilização visual:  
Layout inspirado em design moderno porem simples com cantos arredondados e espaçamento equilibrado.  
Botão “Registrar” com fundo roxo e texto branco.  
Campos de entrada organizados verticalmente com espaçamento.  

→ Funcionalidades do aplicativo:  
Formulário para cadastrar evento com os seguintes campos: nome, data de início,  
data de término, número de participantes, local e custo por participante.  
Uso de BindingContext para associar os dados à classe Evento.  
Lógica automática para calcular duração do evento (em dias) usando TimeSpan.  
Cálculo do custo total com base no número de participantes e custo individual.  
Ao clicar em “Registrar”, exibe uma nova página com o resumo completo do evento.  
Dados apresentados formatados (datas no padrão dd/MM/yyyy, custo com 2 casas decimais em R$).  
