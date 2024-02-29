using System.Globalization;
using Accountex_Aula_81_CSharp.Models;

Account account;

Console.Write("Entre o número da conta: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
char escolha = Console.ReadKey().KeyChar;
Console.WriteLine();
if(escolha == 's') {
    Console.Write("Entre com o valor de depósito inicial: ");
    double depositoInicial = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
    account = new Account(numero, titular, depositoInicial);
}
else {
   account = new Account(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta:");
Console.WriteLine(account);

Console.WriteLine();
Console.Write("Entre com um valor para depósito: ");
double quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
account.Deposito(quantia);
Console.WriteLine("Dados da conta atualizados: "); 
Console.WriteLine(account);

Console.WriteLine();
Console.Write("Entre com um valor para saque: ");
quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
account.Saque(quantia);
Console.WriteLine("Dados da conta atualizados: "); 
Console.WriteLine(account);