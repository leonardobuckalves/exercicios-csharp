# Exercício 1

Escreva um program onde o usuário é solicitado a informar um valor via teclado e armazenar o valor na
variável entrada do tipo string onde tem que verificar 3 condições diferentes:

- Se a entrada é nula, uma exceção ArgumentNullException é lançada com a mensagem "A entrada não pode ser
nula." (Verifique a diferença entre ArgumentException e ArgumentNullException)
-Se a entrada está vazia, uma exceção ArgumentException é lançada com a mensagem "A entrada não pode estar
vazia."
-Se a entrada passar nas verificações anteriores, a entrada é exibida na tela.
Realize o tratamento de erro para essas condições usando o bloco try-cath-finally

# Exercício 2

Escreva um programa que solicite ao usuário a informação da idade e do nome via teclado que deverão ser
armazenados nas variáveis idade do tipo int e nome do tipo string.
A seguir realize o tratamento de erro e lançando as exceções considerando as seguintes condições:

- Se a idade é negativa, uma exceção ArgumentException é lançada com a mensagem "A idade não pode ser
negativa."
- Se a idade é zero, uma exceção NotImplementedException é lançada com a mensagem "A idade ainda não foi
definida."
- Se o nome é nulo ou vazio, uma exceção NullReferenceException é lançada com a mensagem "O nome não pode
ser nulo nem vazio"
Nota: No item c use a expressão string.IsNullOrEmpty(nome)para verificar se o nome é null ou
vazio.

# Exercício 3

Dado um array de inteiros expresso da seguinte forma
int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
Exiba na janela do console os numeros do array e solicite via teclado ao usuário para informar o valor de um índice
do array para obter o seu respectivo valor.
Tratamento de erros
Realize o tratamento de exceções filtrando as exceções IndexOutOfRangeException e ArgumentNullException