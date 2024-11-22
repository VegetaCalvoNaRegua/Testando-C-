// PROGRAMACAO ORIENTADA A OBJETOS

// se baseia na ideia de objetos que contem dados na forma de campos (ou atributos) e codigos na forma de procedimentos e tambem de
// de metodos

// pilares da POO> encapsulamento, heranca, polimorfismo (sobrescrista e sobrecarga) e abstracao

// encapsulamento: esconde os detalhes internos de uma classe, expondo ao usuario somento o que o programador quer

//modificadores de acesso: public - torna o membro acessivel a qualquer outra calsse
//                         private - acesso somente pela propria classe
//                         protected - membro acessivel na propria classe e nas subclasses
//                         protected internal


//Encapsulamento: Gatter > utilizado para obter o valor de um atributo , permite a leitura de um valor de um atributo privado fora da
//                         classe.
//                Setter > utilizado para definir ou modificar o valor de um atributo.

// 1. controle de acesso e validacao:
// com metodo sett podemos adicionar validacoes para assegurar que apenas valores validos sejam atribuidos a um atributo

// 2. flexibilidade a mudancas internas:




// exercicio 1 > encapsulamento

using poo-csharp.Modelo;

Veiculo objVeiculo = new Veiculo("Renault", "Sandero", 2018, 27.8);

objVeiculo.Acelerar(45.8);
objVeiculo.Frear(24.5);

