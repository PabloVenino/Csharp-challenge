/*
    Nesse desafio, recebemos um numero N, e imprimimos a quantidade de vezes os caracteres de uma palavra
    Ex: N=3 -> Aaauuulllaaa
        N=2 -> Eessccoollaa
        N=1 -> Direito
*/

using System;

class Desafio2{
    static void Main(){
        string confirmacao,palavra;
        char[] array;
        confirmacao=palavra="";
        repeticao:
        Console.Clear();
        Console.WriteLine("Digite uma palavra: ");
        palavra=Console.ReadLine();
        Console.WriteLine("Certo, você digitou: {0}, confirma? [s/n]: ",palavra);
        confirmacao=Console.ReadLine();

        switch(confirmacao){
            case "Sim":
            case "SIM":
            case "S":
            case "sim":
            case "si":
            case "sIM":
            case "s":
                confirmacao="s";
                break;
            case "não":
            case "N":
            case "nÃO":
            case "Não":
            case "NÃO":
            case "NÃo":
            case "NãO":
            case "n":
            case "nao":
                confirmacao="n";
                break;
            default:
                confirmacao=null;
                break;
        }
        if (confirmacao!="s" && confirmacao!="n"){
            Console.WriteLine("Você confirmou de maneira errada.");
            goto repeticao;
        }
        if (confirmacao=="n"){
            goto repeticao;
        }
        
        int n=0;
        quantidade:
        Console.WriteLine("Quantas vezes quer repetir cada caractere da letra? [maximo 5 vezes]");
        n=Convert.ToInt32(Console.ReadLine());
        if (n>5){
            Console.WriteLine("Você ultrapassou o máximo de caracteres!!");
            goto quantidade;
        }
        
        if (n<0){
            Console.WriteLine("Não pode-se usar números negativos!!");
            goto quantidade;
        }
        Console.WriteLine("Você escolheu a palavra: {0}, para ter as letras repetidas {1} vezes",palavra,n);
        array=palavra.ToCharArray();
        for(int i=0; i<array.Length; i++){   
            for(int j=0; j<n; j++){
                Console.Write(array[i]);
            }
        }
        Console.WriteLine("\nFim do Programa!\nQuer iniciar novamente? [s/n]");
        string confirm=Console.ReadLine();

        switch (confirm){
            case "s":
            case "sim":
            case "S":
            case "SIM":
            case "Sim":
            case "sIM":
            case "SI":
                confirm="s";
                break;
            case "n":
            case "N":
            case "não":
            case "nao":
            case "Não":
            case "Nao":
            case "NAO":
            case "NÃO":
            case "No":
                confirm="n";
                break;
            default:
                confirm=null;
                break;
        }
        if(confirm=="s"){
            goto repeticao;
        }
        Console.WriteLine("Obrigado por testar nosso programa! (ツ)");
    }
}