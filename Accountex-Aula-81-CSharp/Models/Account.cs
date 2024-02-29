using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Accountex_Aula_81_CSharp.Models
{
    public class Account
    {
        public int Numero {get; private set; }
        public string Titular { get; set; } 
        public double Saldo { get; private set; }

        public Account(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public Account(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public void Deposito(double quantia){
            Saldo += quantia;
        }

        public void Saque(double quantia){
            Saldo -= quantia + 5.0;
        }

        public override string ToString() {
            return "Conta "
            + Numero
            + ", "
            + "Titular: "
            + Titular
            + ", "
            + "Saldo: "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}