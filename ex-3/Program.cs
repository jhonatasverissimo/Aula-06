double salario, parcela, porcentagem;

Console.Write("Informe o seu salário: ");
salario = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor da parcela do empréstimo: ");
parcela = Convert.ToDouble(Console.ReadLine());

porcentagem = salario * 0.3;

if(parcela>porcentagem){
    Console.WriteLine("A parcela é maior que 30% do salário.");
}else{
    Console.WriteLine("Empréstimo liberado!");
}


