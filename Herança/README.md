# Herança - Exercício

Escrever um programa onde devemos usar os conceitos de abstração, encapsulamento e herança para expressar o comportamento de contas bancárias considerando o seguinte cenário:

Em um banco temos clientes que possuem contas que são identificadas por um Número e Nome do cliente.

As operações que serão permitidas são operações básicas de depositar, sacar e exibir o saldo.

Devemos considerar 3 tipos de contas:

- Contas correntes comuns: São contas comuns dos clientes e realizam todas as operações básicas

- Contas poupanças: São contas especificas que se destacam por possuírem juros mensais que são aplicados ao saldo da conta

- Contas de investimento: São contas especificas que se destacam por possuir uma taxa de remuneração que é aplicado ao saldo da conta e uma taxa de imposto que é descontado do saldo da conta

Para simplificar o exercício considera as seguintes premissas:

a - O saldo inicial das contas é zero;

b - O juros da conta de poupança é 0,5% e os rendimentos devem ser calculados ao se efetuar um depósito e deve ser acrescido ao saldo da conta;

c - A taxa da conta de investimento é 0,9% e devem ser aplicada a cada depósito e acrescida ao saldo;

d - O imposto da conta de investimento é de 0,1% e deve ser aplicado a cada saque na conta e debitado do saldo;

e - As contas de poupança e de investimento não permitem que o saldo da conta fique negativo;

Realizar para cada conta a atribuição dos valores das propriedades e exibir no console

Fazer um depósito de R$1.000,00 e um saque de R$100,00 para cada tipo de conta exibindo o resultado no console

Fazer um saque de R$2.000,00 em cada conta e exibir o saldo no console.