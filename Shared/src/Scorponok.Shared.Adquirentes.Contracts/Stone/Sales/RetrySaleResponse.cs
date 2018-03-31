﻿using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Scorponok.Shared.Adquirentes.Contracts.Stone.CreditCardTransactions;

namespace Scorponok.Shared.Adquirentes.Contracts.Stone.Sales {

    /// <summary>
    /// Resposta da retentativa
    /// </summary>
    [DataContract(Name = "RetrySaleResponse", Namespace = "")]
    public class RetrySaleResponse : BaseResponse {

        /// <summary>
        /// Lista de transações de cartão de crédito
        /// </summary>
        [DataMember]
        public Collection<CreditCardTransactionResult> CreditCardTransactionResultCollection { get; set; }
    }
}