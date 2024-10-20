
let comparaValores x y =
  if x = y then "iguais"
  elif x < y then "é menor"
  else "é maior"

printfn "%d %s %d." 40 (comparaValores 40 30) 30 // Resultado: 40 é maior que 30


// Padrão ativo para identificar números pares e ímpares
let (|Par|Ímpar|) n =
    if n % 2 = 0 then Par else Ímpar


// Uso do padrão ativo
let classificarNumero n =
    match n with
    | Par -> printfn "%d é par" n
    | Ímpar -> printfn "%d é ímpar" n


classificarNumero 7  // Saída: 7 é ímpar
classificarNumero 8  // Saída: 8 é par



//Laços de repetição
for i = 1 to 10 do
    printfn "Valor de i: %d" i 

//Irá printar os valores de 1 até 10

//Imprime os valores da lista
let lista_ = [ 1; 5; 125; 456; 789 ]
for i in lista_ do
   printfn "%d" i


//Imprime os valores de 1 até 10
let mutable i = 0
while i < 10 do
    printfn "i é: %d" i
    i <- i + 1