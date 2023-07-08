# Exerc�cio 1

Crie um programa que implemente uma interface IVeiculo com dois m�todos, um para Dirigir
do tipo void e outro para Abastecer do tipo bool que possui um par�metro do tipo int com a
quantidade de gasolina a abastecer.(defina isso como uma propriedade)

Em seguida, crie uma classe Carro com um construtor que receba um par�metro com a
quantidade inicial de gasolina do carro e implemente os m�todos Dirigir e Abastecer do carro.

O m�todo Dirigir deve exibir na tela �Dirigindo o carro..�, se a gasolina for maior que 0, caso
contr�rio deve exibir �Sem gasolina...�, e o m�todo Abastecer deve aumentar a gasolina do
carro e retornar true.

Para testar, crie um objeto do tipo Carro com 0 de gasolina inicial e solicite ao usu�rio a
informa��o de uma quantidade de gasolina para abastecer via teclado e por fim execute o
m�todo Dirigir do carro.

# Exercicio 2

Crie um programa para gerenciar um �lbum de fotos usando os coceitos da programa��o
orientada a objetos.

Para come�ar, crie uma classe chamada LivroFotos com um atributo privado numPaginas do
tipo int. Defina tamb�m um m�todo p�blico GetNumeroPaginas que retornar� o n�mero de
p�ginas do �lbum de fotos.

O construtor padr�o dever� criar um �lbum com 16 p�ginas a classe deve possuir um
construtor adicional, com o qual podemos especificar o n�mero de p�ginas que queremos
no �lbum. Crie tamb�m uma classe SuperLivroFotos cujo construtor criar� um �lbum com
64 p�ginas.

Por fim, execute as seguintes a��es:
- Criar um �lbum de fotos padr�o e exibir o n�mero de p�ginas
- Criar um �lbum de fotos com 24 p�ginas e exibir o n�mero de p�ginas
- Criar um �lbum de fotos grande e exibir o n�mero de p�ginas

# Exercicio 3

Crie um programa que solicite ao usu�rio tr�s nomes de pessoas e os armazene em
uma matriz de objetos do tipo Pessoa. Haver� duas pessoas do tipo Aluno e uma
pessoa do tipo Professor.

Para isso, crie uma classe Pessoa que possua uma propriedade Nome do tipo string, um
construtor que receba o nome como par�metro e sobrescreva o m�todo ToString().

Ent�o crie mais duas classes que herdam da classe Pessoa, elas ser�o chamadas de
Aluno e Professor. A classe Aluno possui um m�todo Estudar que escreve pelo console
que o aluno est� estudando. A classe Professor ter� um m�todo Explicar que grava no
console que o professor est� explicando.

Lembre-se de tamb�m criar dois construtores nas classes filhas que chamam o
construtor pai da classe Pessoa.

Termine o programa lendo as pessoas (o professor e os alunos) e execute os m�todos
Explicar e Estudar.

# Exercic�o 4

Crie um programa que solicite ao usu�rio os nomes de tr�s pessoas e os armazene em uma
matriz de objetos do tipo Pessoa.

Para fazer isso, primeiro crie uma classe Pessoa que tenha uma propriedade Nome do tipo
string, um construtor que receba o nome como par�metro e sobrescreva o m�todo
ToString().

Finalize o programa lendo as pessoas e executando o m�todo ToString() na tela.