//Tipos (Primitivos, compostos e recursivos)

    //Primitivos
let numero = 22          // Inferido como int
let pi: float = 3.14         // Explicitado como float
let mensagem = "Projeto LP"  // Inferido como string
let condicao = true      // Inferido como bool
let digito: char = '2'  // Explicitado como char
let saudacao = "Olá, Leitores!"

//Variável mutável

let mutable count: int = 0
count <- count + 1



let array = [|1;3;9;12|] 

let lista = [1; 2; 3; 4; 5]

    // Unidades de Medida
[<Measure>] type m
let distancia: float<m> = 4.0<m> // Define 4 metros

    //Tupla
let pessoa = ("Augusto", 22, false) 

    //Records
type Pessoa = { Nome: string; Idade: int }
let cassiano = { Nome = "Cassiano"; Idade = 20 }

    //Unions Discriminados
type Opcao =
    | Nenhuma
    | Numero of int
    | Texto of string

    //Sequencias
let valores = seq { 1..100 } // Sequência de 1 a 100



