﻿using Scorponok.Gateway.Pagamento.Domain.Core.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Scorponok.Gateway.Pagamento.Domain.Models
{
    public abstract class FormaPagamento : Entity
    {
        //public readonly FormaPagamentoCartaoCredito CartaoCredito = new FormaPagamentoCartaoCredito();
        //public readonly FormaPagamentoBoleto Boleto = new FormaPagamentoBoleto();
        //public readonly FormaPagamentoDebitoOnline DebitoOnline = new FormaPagamentoDebitoOnline();
        //public readonly FormaPagamentoPayPal PayPal = new FormaPagamentoPayPal();

        public Pedido Pedido { get; private set; }
    }
}
