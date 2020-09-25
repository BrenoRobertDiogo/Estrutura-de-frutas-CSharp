using System;

class MainClass {
  public static void Main () {
    Console.WriteLine (@"
Seja bem vindo ao supermercado Estrutura de Frutas.
Como não queremos ter que jogar frutas fora por estrago, temos uma promoção especial
caso falte menos de 8 dias para que elas estraguem, espero que aproveitem!!!
OBS.: São R$5 Kilo 
  CATALOGO:
[x] | Nome | Quantidade disponível | Peso médio | Validade
");

  Random numAleatorio = new Random();

  string[] frutas = new string[9] {
    "Goiaba",
     "Coco",
     "Banana",
     "Kiwi",
     "Laranja",
     "Maça",
     "Melancia",
     "Melão",
     "Morango" 
     };
  //

  double[,] todosDados = new double[frutas.Length, 3];

  // Colocando os valores das variáveis
  for( int i = 0; i < frutas.Length; i++ ) {
    Produto valorTeste    = new Produto();
    // Nome
    valorTeste.Nome       = frutas[i];
    // Quantidade
    valorTeste.Quantidade = numAleatorio.Next(40, 60);
    todosDados[i, 0] = valorTeste.Quantidade;
    // Peso
    todosDados[i, 1] = analiseFruta.peso(valorTeste.Nome);
    valorTeste.Peso  = todosDados[i, 1];
    // Validade
    todosDados[i, 2]    = analiseFruta.validade(valorTeste.Nome);
    valorTeste.Validade = todosDados[i, 2];
    }

    for( int i=0; i < frutas.Length; i++ ) {
      Console.WriteLine($@"[{i}] | {frutas[i]}
           |          {todosDados[i, 0]} Unidades  |    {todosDados[i, 1]}Kg   |      {todosDados[i, 2]} Dias 
--------------------------------------------------------------------------");
    }
  
  string ateQuando;
  double carrinho = 0;
  double preco = 0;
  double aumentar = 0;
  do {
    Console.WriteLine("Digite o número do pedido e depois a quantidade: ");
    Console.Write("Número: ");
    int acrescentaLista = int.Parse(Console.ReadLine());
    Console.Write("Quantidade: ");
    double quantidadeProduto = double.Parse(Console.ReadLine());

    aumentar = analisePreco.analise(todosDados[acrescentaLista, 1], quantidadeProduto, todosDados[acrescentaLista, 2]);
    preco += aumentar/100;
    todosDados[acrescentaLista, 0] -= quantidadeProduto;

    Console.Write("Digite 'sair' caso já comprou o que queria: ");
    ateQuando = Console.ReadLine();

    carrinho += quantidadeProduto;

  } while(ateQuando!="sair");
  
  Console.Write("Você vai pagar: ");

  Console.ForegroundColor = ConsoleColor.Red;
  Console.Write(preco);
  Console.ResetColor();

  Console.Write(" por ");

  Console.ForegroundColor = ConsoleColor.Red;
  Console.Write(carrinho);
  Console.ResetColor();

  Console.Write(" frutas");
  
  }

}