 double valor;
Console.Write("Insira um valor para verificar se ele é multiplo de 5: ");

valor = Convert.ToDouble(Console.ReadLine());

if(valor % 2 == 0){
    Console.WriteLine("É multiplo de 5.");
}else{
    Console.WriteLine("Não é multiplo de 5");
}

