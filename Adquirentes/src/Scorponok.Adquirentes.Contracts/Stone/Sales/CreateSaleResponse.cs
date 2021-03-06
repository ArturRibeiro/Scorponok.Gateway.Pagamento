﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Scorponok.Adquirentes.Contracts.Stone.BoletoTransactions;
using Scorponok.Adquirentes.Contracts.Stone.CreditCardTransactions;
using Scorponok.Adquirentes.Contracts.Stone.Orders;

namespace Scorponok.Adquirentes.Contracts.Stone.Sales {

    /// <summary>
    /// Resposta da criação de uma nova venda
    /// </summary>
    [DataContract(Name = "CreateSaleResponse", Namespace = "")]
    public class CreateSaleResponse : BaseResponse {

        /// <summary>
        /// Lista de transações de cartão de crédito
        /// </summary>
        [DataMember]
        public List<CreditCardTransactionResult> CreditCardTransactionResultCollection { get; set; }

        /// <summary>
        /// Lista de transações de boleto
        /// </summary>
        [DataMember]
        public List<BoletoTransactionResultCollection> BoletoTransactionResultCollection { get; set; }

        /// <summary>
        /// Dados de retorno do pedido
        /// </summary>
        [DataMember]
        public OrderResult OrderResult { get; set; }

        /// <summary>
        /// Chave do comprador. Utilizada para identificar um comprador no gateway
        /// </summary>
        [DataMember]
        public virtual Guid BuyerKey { get; set; }
    }
}