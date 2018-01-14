﻿using System;
using System.Runtime.Serialization;

namespace Scorponok.Gateway.Pagamento.Services.Cliente.Messages {

    [DataContract(Namespace = "")]
    public class CreateBuyerResponse : BaseResponse {

        /// <summary>
        /// Chave do buyer
        /// </summary>
        [DataMember]
        public Guid BuyerKey { get; set; }

        /// <summary>
        /// Sucesso
        /// </summary>
        [DataMember]
        public bool Success { get; set; }
    }
}
