using MechSoft.Models;
using MechSoft;
using Microsoft.AspNetCore.Mvc;


namespace SeuProjeto.Controllers
{
    public class TransacaoController : Controller
    {
        private static Conta conta = new Conta(1, "", 0);
        private static ControladorDeTransacoes controlador = new ControladorDeTransacoes(conta);

        // Página principal com saldo e histórico
        public IActionResult Index()
        {
            ViewBag.Saldo = controlador.ObterSaldo();
            ViewBag.Historico = controlador.ObterHistorico();
            return View();
        }

        // Ação para realizar o depósito
        [HttpPost]
        public IActionResult Depositar(decimal valor, string descricao)
        {
            controlador.RealizarDeposito(valor, descricao);
            return RedirectToAction("Index");
        }

        // Ação para realizar a retirada
        [HttpPost]
        public IActionResult Retirar(decimal valor, string descricao)
        {
            controlador.RealizarRetirada(valor, descricao);
            return RedirectToAction("Index");
        }
    }
}