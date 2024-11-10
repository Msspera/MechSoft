using MechSoft;
using System;
using System.Collections.Generic;

namespace MechSoft.Models
{
    public class ControladorDeTransacoes
    {
        private Conta _conta;

        public ControladorDeTransacoes(Conta conta)
        {
            _conta = conta;
        }

        public void RealizarDeposito(decimal valor, string descricao)
        {
            _conta.Depositar(valor, descricao);
        }

        public void RealizarRetirada(decimal valor, string descricao)
        {
            _conta.Retirar(valor, descricao);
        }

        public decimal ObterSaldo()
        {
            return _conta.Saldo;
        }

        public List<Transacao> ObterHistorico()
        {
            return new List<Transacao>(_conta.HistoricoTransacoes);
        }
    }
}