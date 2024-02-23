namespace Application;

public class Triangulo(){


    public static double perimetro(double ladoA,double ladoB, double ladoC){
        return ladoA+ladoB+ladoC;
    }

    public static double area (double ladoB, double altura){
        return (ladoB*altura)/2;
    }

    public static double volumen(double area,double altura){
        return altura*altura;
    }

}

