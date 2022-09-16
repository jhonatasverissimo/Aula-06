double valor;

Console.Write("Informe um valor: ");
valor = Convert.ToDouble(Console.ReadLine());

if(valor>0){
    Console.Write("O valor é positivo.");
}else if(valor<0){
    Console.WriteLine("valor negativo");
}else{
    Console.WriteLine("O valor digitado foi 0.");
}