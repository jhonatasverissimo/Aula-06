 double valor, x;
        
        Console.Write("Digite um valor: ");
        
        valor = Convert.ToDouble(Console.ReadLine());
        
        if(valor >20 ){
           x = valor / 2;
           Console.WriteLine("A metade do valor digitado: "+ x);
           
        } else if(valor <20) {
            Console.WriteLine("O Dobro do valor digitado: "+ (valor*2));
        }else if(valor == 20){
            Console.WriteLine("Valor igual a 20.");
        }else{
            Console.WriteLine("Valor inválido. ");
            Console.ReadKey();
        }
