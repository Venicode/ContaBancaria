class ContaBancaria
{
    public ContaBancaria(int numeroConta, string nomeTitular, string senhaConta, double saldo)
    {
        NumeroConta = numeroConta;
        NomeTitular = nomeTitular;
        SenhaConta = senhaConta;
        SaldoConta = saldo;
    }

    public int NumeroConta { get; }
    public string NomeTitular { get; }
    public string SenhaConta { get; }
    public double SaldoConta { get; set; }

    public bool AlterarSenha(string senhaNova)
    {

        if (senhaNova == SenhaConta)
        {
            Console.WriteLine("Por favor, informe uma senha diferente da anterior");
            return false;
        }
        else
        {
            if (senhaNova.Length > 0)
            {
                senhaNova = SenhaConta;
                return true;
            }
            else
            {
                Console.WriteLine("Informe uma quantidade maior que 0");
                return false;

            }
        }
    }

    public void AdicionarSaldo(double novoValor)
    {
        if (novoValor <= 0)
        {
            Console.WriteLine("Informe um valor maior que zero!");
        }
        else
        {
            SaldoConta += novoValor;
            Console.WriteLine("Valor adicionado a sua carteira!\n");
            Console.WriteLine($"Novo saldo: {SaldoConta}");
        }
    }
    public void RetirarSaldo(double valorRetirar)
    {
        if (valorRetirar <= 0)
        {
            Console.WriteLine("Digite um valor de saque válido.");
        }
        else if (valorRetirar > SaldoConta)
        {
            Console.WriteLine("Valor maior do que o saldo em conta.");
        }
        else
        {
            SaldoConta -= valorRetirar;
            Console.WriteLine("Saque realizado com sucesso!");
        }
    }
}
