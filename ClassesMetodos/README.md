# Exerc�cio Pr�tico

1- Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e
potencia com os tipos de dados string, string, string, int e int.
Crie tamb�m o comportamento Acelerar que n�o retorna nada e apenas exiba a mensagem �Acelerando...�

a- Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110

b- Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120

c- Exiba os valores dos atributos no console para cada um dos objetos criados e chame o m�todo Acelerar
para cada objeto

d- Altere o m�todo Acelerar para receber um par�metro do tipo string chamado marca e a seguir altere a
mensagem para exibir o texto �Acelerando o meu {marca}� , seguido da marca do carro.

e- Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos :
modelo, montadora, marco, ano e potencia (use a palavra this para identificar a inst�ncia da classe)

f- Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o
m�todo Acelerar passando o valor do argumento para o par�metro no m�todo Acelerar

Obs- Utilize a nomenclatura Pascal Case para definir os nomes e o modificador de acesso public para todos os
membros da classe

# Exerc�cio Pr�tico 2

a- Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (n�o 
use a palavra-chave this)

b- Crie um m�todo chamado VelocidadeMaxima que recebe um par�metro do tipo int chamado potencia que 
vai retornar um double representando a velocidade m�xima do carro
( Para calcular a velocidade multiplique a potencia por 1.75)