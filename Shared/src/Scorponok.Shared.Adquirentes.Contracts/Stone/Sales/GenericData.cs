﻿using System.Runtime.Serialization;

namespace Scorponok.Shared.Adquirentes.Contracts.Stone.Sales {

    /// <summary>
    /// Dados genericos do pedido
    /// </summary>
    [DataContract(Name = "GenericData", Namespace = "")]
    public class GenericData {

        /// <summary>
        /// Nome do item gerenico
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Dado do item gerenico
        /// </summary>
        [DataMember]
        public string Value { get; set; }
    }
}
