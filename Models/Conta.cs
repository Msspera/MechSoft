using MechSoft.Models;
using System;
using System.Collections.Generic;


namespace MechSoft{
    public class Conta
    {
        public int Id { get; private set; }
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }
        private List<Transacao> _historicoTransacoes;

        public IReadOnlyList<Transacao> HistoricoTransacoes => _historicoTransacoes.AsReadOnly();

        public Conta(int id, string titular, decimal saldoInicial = 0)
        {
            Id = id;
            Titular = titular;
            Saldo = saldoInicial;
            _historicoTransacoes = new List<Transacao>();
        }

        public void Depositar(decimal valor, string descricao)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do depósito deve ser positivo.");

            Saldo += valor;
            var transacao = new Transacao(TipoTransacao.Deposito, valor, descricao);
            _historicoTransacoes.Add(transacao);
        }

        public void Retirar(decimal valor, string descricao)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor da retirada deve ser positivo.");

            if (valor > Saldo)
                throw new InvalidOperationException("Saldo insuficiente para realizar a retirada.");

            Saldo -= valor;
            var transacao = new Transacao(TipoTransacao.Retirada, valor, descricao);
            _historicoTransacoes.Add(transacao);
        }
    }

    public class Transacao
    {
        public TipoTransacao Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public Transacao(TipoTransacao tipo, decimal valor, string descricao)
        {
            Tipo = tipo;
            Valor = valor;
            Data = DateTime.Now;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"{Data:dd/MM/yyyy HH:mm:ss} - {Tipo}: {Valor:C} - {Descricao}";
        }
    }

    public enum TipoTransacao
    {
        Deposito,
        Retirada
    }
}