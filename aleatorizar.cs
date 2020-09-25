using System;
// Classe usada para fazer os números aleatórios responsivamente com os dados enviados
class Aleatorizar {
  public static int frutaAleatoria( int atribuido, int compara1, int compara2, int range1, int range2, int range3 ) {
    Random numAleatorio = new Random();
    if( atribuido <= compara1 && atribuido-2 > 0 ) {
      atribuido = numAleatorio.Next(atribuido-range1, atribuido+range1);

    } else if ( atribuido > compara1 && atribuido <= compara2 ) {
      atribuido = numAleatorio.Next(atribuido-range2, atribuido+range2);

    } else {
      atribuido = numAleatorio.Next(atribuido-range3, atribuido+range3);
    }
    return atribuido;
  }
}