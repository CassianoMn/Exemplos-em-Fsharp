//Polimorfismo e seus tipos

//Tipo paramédico
// Exemplo de função genérica que troca os elementos de um par
let trocar (a: 'T, b: 'U) : ('U, 'T) = (b, a)

// Uso da função
let resultado = trocar (5, "cinco")
printfn "Resultado: %A" resultado  
// Saída: Resultado: ("cinco", 5)

//Polimorfimso de Subtipo
// Definição da interface IForma
type IForma =
   abstract member Area: unit -> float

type Circulo(raio: float) =
   interface IForma with
       member this.Area() = System.Math.PI * raio * raio

type Retangulo(largura: float, altura: float) =
   interface IForma with
      member this.Area() = largura * altura

let imprimirArea (forma: IForma) =
   printfn "A área é %f" (forma.Area())


// Instâncias dos tipos
let circulo = Circulo(5.0)
let retangulo = Retangulo(4.0, 6.0)

// Uso da função polimórfica
imprimirArea circulo    // Saída: A área é 78.539816
imprimirArea retangulo  // Saída: A área é 24.000000


//Sobrecarga de métodos...
type Impressora() =
    member this.Imprimir(valor: int) =
        printfn "Inteiro: %d" valor
    member this.Imprimir(valor: string) =
        printfn "String: %s" valor

let impressora = Impressora()
impressora.Imprimir(42)          // Saída: Inteiro: 42
impressora.Imprimir("Olá F#")    // Saída: String: Olá F#
