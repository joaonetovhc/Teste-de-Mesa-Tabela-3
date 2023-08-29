using System;
using System.ComponentModel;

class Calculos{

    public double valorPresente;
    public  double taxaJuros;
    public double meses;
    public double rendimentoFinal;
   
    public Calculos(double valorPresente, double taxaJuros, double meses) {
        this.valorPresente=valorPresente;
        this.taxaJuros=taxaJuros;
        this.meses=meses;
    

    }

    public double Formula(){
        rendimentoFinal = valorPresente * Math.Pow((1+taxaJuros),meses);
        return rendimentoFinal;

    }
}


class Problema6{

    static void Main() {

        /*valorPresente = 1000;
        taxaJuros = 3.0/100;
        meses = 8.333;*/

        Console.Write("\nQuanto vai ser investido?\n➯ ");
        double valorPresente = double.Parse(Console.ReadLine()); 

        Console.Write("Qual taxa de juros?\n➯ ");
        double taxaJuros = double.Parse(Console.ReadLine())/100;
       
        Console.Write("Qual periodo?\n➯ ");
        double meses = double.Parse(Console.ReadLine());
        double comparador = 1;
        Console.WriteLine();

        while (comparador <= meses){
        
            if (comparador == 8){
            meses = 8.333;
            Calculos mes = new Calculos(valorPresente,taxaJuros,meses);
            Console.WriteLine($"| Rendimento do Mes: {meses}   | {mes.Formula().ToString("C")} |");
            
            }else{

            Calculos mes = new Calculos(valorPresente,taxaJuros,comparador);
            Console.WriteLine($"| Rendimento do Mes: {comparador}       | {mes.Formula().ToString("C")} |");

            }
                comparador++;
        }
        
    }

}