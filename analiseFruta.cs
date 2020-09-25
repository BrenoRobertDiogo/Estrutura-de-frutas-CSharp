using System;
class analiseFruta {
  
  public static double peso( string fruta ) {
    
    int pesoFruta;
    switch( fruta ) {
      case ("Goiaba"):
        pesoFruta = 95*2;
        break;
      case ("Coco"):
        pesoFruta = 1700;
        break;
      case ("Banana"):
        pesoFruta = 86;
        break;
      case ("Kiwi"):
        pesoFruta = 77;
        break;
      case ("Laranja"):
        pesoFruta = 140;
        break;
      case ("Maça"):
        pesoFruta = 130;
        break;
      case ("Melancia"):
        pesoFruta = 2500;
        break;
      case ("Melão"):
        pesoFruta = 1500; //1500 à 2500
        break;
      case ("Morango"):
        pesoFruta = 240; // 10 unidades 
        break;
      default:
        pesoFruta = 0;
        break;
    }

    pesoFruta = Aleatorizar.frutaAleatoria( pesoFruta, 100, 300, 5, 15, 30 );
    return pesoFruta;
  
  }

  public static int validade( string fruta ) {
    int validadeFruta;
    switch( fruta ) {
      case ("Goiaba"):
        validadeFruta = 30;
        break;
      case ("Coco"):
        validadeFruta = 60;
        break;
      case ("Banana"):
        validadeFruta = 7;
        break;
      case ("Kiwi"):
        validadeFruta = 5;
        break;
      case ("Laranja"):
        validadeFruta = 90;
        break;
      case ("Maça"):
        validadeFruta = 14;
        break;
      case ("Melancia"):
        validadeFruta = 7;
        break;
      case ("Melão"):
        validadeFruta = 7;
        break;
      case ("Morango"):
        validadeFruta = 7;
        break;
      default:
        validadeFruta = 0;
        break;
    }

    validadeFruta = Aleatorizar.frutaAleatoria( validadeFruta, 10, 30, 2, 5, 15 );
    
    return validadeFruta;
  }
}

