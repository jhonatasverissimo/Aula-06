double vendas;

Console.Write("Informe o valor total de vendas: ");
vendas = Convert.ToDouble(Console.ReadLine());

if(vendas < 1000){
    Console.WriteLine("Você não possui prêmios.");
}else if(vendas >= 1000 && vendas <3000){
    Console.WriteLine("Seu prêmio é de  R$ 150,00.");
}else if(vendas >= 3000){
    Console.WriteLine("Seu prêmio é de  R$ 300,00.");
}