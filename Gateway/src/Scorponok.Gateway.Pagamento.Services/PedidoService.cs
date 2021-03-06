﻿using Scorponok.Gateway.Pagamento.Domain.Models;
using Scorponok.Gateway.Pagamento.Domain.Models.Pedidos.IService;
using Scorponok.Shared.Contracts.Messages.Autorizar.Requests;
using Scorponok.Shared.Fluent.HttpClient;
using System.Threading.Tasks;
using Scorponok.Gateway.Pagamento.Domain.Models.Pedidos;

namespace Scorponok.Gateway.Pagamento.Services
{
    public class PedidoService : IPedidoService
    {
        public PedidoService()
        {

        }

        public Pedido AutorizaPagamentoAdquirente(Pedido pedido)
        {
            var response = HttpRequestFactory.Post($"http://localhost:54228/api/Adquirente/autorizar/Transacao"
                , new AuthOnlyMessageRequest())
                .Result;

	        if (!response.IsSuccessStatusCode)
	        {
		        //......
	        }

            return pedido;
        }
    }
}
