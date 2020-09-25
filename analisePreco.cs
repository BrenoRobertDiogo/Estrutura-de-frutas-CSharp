using System;
class analisePreco {
  
  public static double analise(double pesoFruta, double quantProduto, double validade) {
    double resultado = (pesoFruta/10*5)*quantProduto;
    if( validade < 8.0 ) {
      resultado -= resultado*0.1;
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Desconto aplicado!!!");
      Console.ResetColor();
    }
    return resultado;
    // 5$ por kilo

  }
}