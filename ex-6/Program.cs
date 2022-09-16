double valor;

Console.Write("Informe um valor: ");
valor = Convert.ToDouble(Console.ReadLine());

if(valor % 3 == 0 && valor % 7 == 0 ){
    Console.WriteLine("O valor é Multiplo de 3 e de 7.");
}else{
    Console.WriteLine("Não é múltiplo");
}