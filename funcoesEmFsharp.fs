//Funções Nomeadas
let multiplicar x y = x * y

//Funções Recursivas
let rec fibonacci n = if n <= 1 then n else fibonacci (n - 1) + fibonacci (n - 2)


//Funções Anônimas(Lambda)
List.map (fun x -> x * 2) [1; 2; 3; 4]


//Funções de Ordem Superior
let aplicarDuasVezes f x = f (f x)


//Currying e Aplicação Parcial
	
let adicionar x y = x + y

    //Pode-se criar uma nova função a partir de "adicionar" fixando um dos argumentos:
let adicionarCinco = adicionar 5


//Exemplo usando >>: O operador >> faz a composição da função da esquerda para a direita, ou seja, a função que está à esquerda é aplicada primeiro, e depois a da direita.
let incrementar x = x + 1
let quadrado x = x * x
let incrementarEQuadrar = incrementar >> quadrado


(*incrementarEQuadrar é uma função que primeiro aplica incrementar a um valor x, incrementando-o em 1.
Em seguida, aplica quadrado ao resultado, elevando-o ao quadrado. *)

//Exemplo de uso:
//incrementarEQuadrar 3 // (3 + 1) ^ 2 = 16


//Operador Pipe ("|>")

//permite que o resultado de uma expressão seja passado como argumento para a próxima função

let resultado = 5 |> incrementar |> quadrado


// Clausuras e Captura de Contexto
let contador () = let mutable total = 0 (fun () -> total <- total + 1 total)

//A função "contador" retorna uma função anônima que, a cada chamada, incrementa e retorna o valor de "total", mantendo o estado entre as chamadas.

