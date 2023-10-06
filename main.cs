using System;

public abstract class Forma {
  protected double Base;
  protected double Altura;

  public Forma(double Base, double Altura){
    this.Base = Base;
    this.Altura = Altura;
  }
  
  public abstract double CalculaArea();
}
  
class Quadrado : Forma {
  public Quadrado(double lado) : base(lado, lado) {
  }

  public override double CalculaArea() {
    return Base * Altura;
  }
}

class Program {
  public static void Main(string[] args) {
    Quadrado quad = new Quadrado(5);
    double areaQuadrado = quad.CalculaArea();
    Console.WriteLine("A área do quadrado é: " + areaQuadrado);
  }
}
