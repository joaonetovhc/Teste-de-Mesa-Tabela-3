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
    // formula de calcular o juros
    public double Formula(){
        rendimentoFinal = valorPresente * Math.Pow((1+taxaJuros),meses);
        return rendimentoFinal;
    }
}
class Problema8{
    static void Main() {

        Console.Write("\nQuanto vai ser investido?\n➯ ");
        double valorPresente = double.Parse(Console.ReadLine()); 

        Console.Write("Qual taxa de juros?\n➯ ");
        double taxaJuros = double.Parse(Console.ReadLine())/100;
       
        Console.Write("Qual periodo?\n➯ ");
        double meses = double.Parse(Console.ReadLine());
        double comparador = 1;
        double novoValorPresente = 0;
        double saque = 0; 
        double comparadorReiniciado = 1; // reinicia a contagem dos meses apos o saque

        while (comparador <= meses){  

            if(comparador == 5){ // verifica se o mes é igual a 5 para fazer o resgate 
            Console.WriteLine("--------------------------------------------");   
            Console.Write("Quer fazer um resgate de quanto?\n➯ ");
            saque = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");  
            novoValorPresente = valorPresente;
            novoValorPresente = novoValorPresente - saque;
            
            }else if(comparador <= 4){ 
                
                Calculos mes = new Calculos(valorPresente,taxaJuros,comparador);
                Console.WriteLine($"| Rendimento do Mes: {comparador}       | {mes.Formula().ToString("C")} |");
            } else{
                // mosta na tela o calculo dos juros depois que é feito o resgate
                Calculos mes = new Calculos(novoValorPresente,taxaJuros,comparadorReiniciado); 
                Console.WriteLine($"| Rendimento do Mes: {comparador}       | {mes.Formula().ToString("C")} |");
            }
                comparadorReiniciado++;
                comparador++;
        }
    }
}
