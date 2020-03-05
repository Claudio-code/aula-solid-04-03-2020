using aula_solid_04_03_2020.Entidades;
using aula_solid_04_03_2020.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula_solid_04_03_2020.Servicos
{
  public class ServicosBancarios : ServicoBancario
  {
    public void Depositar(Conta conta, decimal valor)
    {
      conta.Deposito(valor);
    }

    public void GetSaldo(Conta conta)
    {
      conta.GetSaldo();
    }

    public void Sacar(Conta conta, decimal valor)
    {
      conta.Saque(valor);
    }
  }
}