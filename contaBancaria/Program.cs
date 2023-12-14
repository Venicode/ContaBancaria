ContaBancaria novaConta = new(123, "Vitoria", "123", 0);
Console.WriteLine($"Bem vindo (a){novaConta.NomeTitular}");
Console.WriteLine("O que deseja fazer: \n");
Console.WriteLine("1 - Ver saldo");
Console.WriteLine("2 - Realizar saque");
Console.WriteLine("3 - Realizar depósito");
Console.WriteLine("4- Alterar senha");

string escolha = Console.ReadLine()!;

switch (escolha)
{
    case "1":
        {
            Console.WriteLine($"Saldo atual: {novaConta.SaldoConta}");
            break;
        }
    case "2":
        {
            Console.WriteLine("Quanto deseja retirar?");
            double saque = double.Parse(Console.ReadLine()!);
            novaConta.RetirarSaldo(saque);
            break;
        }
    case "3":
        {
            Console.WriteLine("Quanto deseja adicionar?");
            double valorAdicional = double.Parse(Console.ReadLine()!);
            novaConta.AdicionarSaldo(valorAdicional);
            break;
        }
    case "4":
        {
            while (true)
            {
                Console.WriteLine("\nDigite a senha atual:");
                string senhaAtual = Console.ReadLine()!;
                if (senhaAtual != novaConta.SenhaConta)
                {
                    Console.WriteLine("\nSenha inválida!");
                    continue;
                }
                else
                {

                    while (true)
                    {
                        Console.WriteLine("\nDigite a nova senha");
                        string novaSenha = Console.ReadLine()!;
                        novaConta.AlterarSenha(novaSenha);
                        if (novaConta.AlterarSenha(novaSenha) == false)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Senha alterada com sucesso!");
                            break;
                        }
                    }
                    
                }
                break;
            }
            break;
        }
        default:
        {
            Console.WriteLine("Opção inválida");
            break;
        }

}
