﻿using System.Runtime.Serialization;

namespace Scorponok.Shared.Adquirentes.Contracts.Stone.InstantBuy {

    [DataContract(Namespace = "")]
    public class UpdateInstantBuyDataResponse : BaseResponse {

        /// <summary>
        /// Indicador de sucesso
        /// </summary>
        [DataMember]
        public bool Success { get; set; }
    }
}
