using aula_solid_04_03_2020.Entidades;

namespace aula_solid_04_03_2020.Interfaces
{
    public interface ServicoBancario
    {
        void GetSaldo(Conta conta);
        void  Depositar(Conta conta, decimal valor);
        void Sacar(Conta conta, decimal valor);
    }
}