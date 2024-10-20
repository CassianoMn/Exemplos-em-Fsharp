
// Exemplo de exceção personalizada
exception ErroDeConexao of string * int // Exceção com endereço e porta


let conectarAoServidor (endereco: string) (porta: int) =
    // Simulando uma falha de conexão se a porta for inválida
    if porta < 1024 then
        raise (ErroDeConexao(endereco, porta)) // Lançando a exceção personalizada
    else
        printfn "Conectado a %s na porta %d" endereco porta


// ... mais tarde no código...
try
    conectarAoServidor "localhost" 80 // Tentando conectar a uma porta inválida
with
| ErroDeConexao(endereco, porta) -> // Capturando a exceção personalizada
    printfn "Falha ao conectar a %s na porta %d. A porta deve ser >= 1024." endereco porta



// Try... with
let dividir x y =
    try
        x / y  // Código que pode lançar DivideByZeroException
    with
    | :? System.DivideByZeroException -> // Lidando com divisão por zero
        printfn "Erro: Divisão por zero!"
        0 // Retornando um valor padrão em caso de erro
    | :? System.OverflowException -> // Lidando com overflow
        printfn "Erro: Overflow!"
        0 // Retornando um valor padrão em caso de erro
    | _ -> // Capturando qualquer outra exceção
        printfn "Erro desconhecido!"
        0 // Retornando um valor padrão em caso de erro

let resultado = dividir 10 0 // Chamando a função com um divisor zero
printfn "Resultado: %d" resultado // Imprime "Resultado: 0"




//Try... finally
let lerArquivo (nomeArquivo : string) =
    let arquivo = 
        try
            System.IO.File.OpenText(nomeArquivo) // Pode lançar FileNotFoundException
        with
        | :? System.IO.FileNotFoundException ->
            printfn "Arquivo não encontrado: %s" nomeArquivo
            null
    try
        if arquivo <> null then  // Verifica se o arquivo foi aberto com sucesso
            printfn "Conteúdo do arquivo:"
            while not arquivo.EndOfStream do
                printfn "%s" (arquivo.ReadLine())
    finally  // Garante que o arquivo seja fechado
        if arquivo <> null then
            printfn "Fechando o arquivo."
            arquivo.Close()


lerArquivo "meuarquivo.txt"


//Levantando exceções por "raise"
let validarIdade idade =
    if idade < 0 then
        raise (System.ArgumentOutOfRangeException("idade", "A idade não pode ser negativa.")) // Lançando exceção com nome do parâmetro e mensagem.
    elif idade > 120 then
        raise (System.ArgumentOutOfRangeException("idade", "A idade é muito alta."))
    else
        printfn "Idade válida: %d" idade

try
    validarIdade -5   //  Lança ArgumentOutOfRangeException
with
| :? System.ArgumentOutOfRangeException as ex ->  // Capturando a exceção.
    printfn "Erro: %s" ex.Message  // Imprimindo a mensagem de erro da exceção.



//failwith
let processarDados dados =
    if dados = null then
        failwith "Dados inválidos: nulos"  // Lança uma exceção se os dados forem nulos
    // ... processamento …



//invalidArg
let calcularArea largura altura =
    if largura < 0.0 then
        invalidArg "largura" "A largura não pode ser negativa." // Lança exceção indicando o argumento inválido.
    elif altura < 0.0 then
        invalidArg "altura" "A altura não pode ser negativa."
    else
        largura * altura


//Uso do assert 
let calcular area =
    assert (area > 0.0)    // A asserção falha se a área for <= 0
    // ... cálculos usando a area ...

let resultado = calcular -10.0  // Isso causará uma falha de asserção no modo debug.