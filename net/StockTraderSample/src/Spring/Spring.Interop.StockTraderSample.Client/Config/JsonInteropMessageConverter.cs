using System;
using Newtonsoft.Json.Serialization;
using Spring.Messaging.Amqp.Support.Converter;

namespace Spring.Interop.StockTraderSample.Client.Config
{
    public class JsonInteropMessageConverter : JsonMessageConverter
    {
        protected override void InitializeJsonSerializer()
        {
            this.jsonSerializer.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
    /*
    public class LowercaseContractResolver : DefaultContractResolver 
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToLower();
        }
    }*/
}