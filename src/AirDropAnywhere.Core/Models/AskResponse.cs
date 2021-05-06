using System;
using System.Text.Json;

namespace AirDropAnywhere.Core.Models
{
    /// <summary>
    /// Body of a response from the /Ask endpoint in the AirDrop HTTP API.
    /// </summary>
    public class AskResponse
    {
        public AskResponse(string computerName, string modelName)
        {
            ReceiverComputerName = computerName;
            ReceiverModelName = modelName;
        }
        
        /// <summary>
        /// Gets the receiver computer's name.
        /// </summary>
        public string ReceiverComputerName { get; }
        /// <summary>
        /// Gets the model name of the receiver.
        /// </summary>
        public string ReceiverModelName { get; }
    }
}