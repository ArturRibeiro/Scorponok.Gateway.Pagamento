﻿using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Scorponok.Adquirente.Pagamento.Unit.Test.Integration {

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