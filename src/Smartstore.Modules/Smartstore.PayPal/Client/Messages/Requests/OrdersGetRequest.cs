﻿namespace Smartstore.PayPal.Client.Messages
{
    /// <summary>
    /// Shows details for an order by ID.
    /// </summary>
    public class OrdersGetRequest : PayPalRequest<OrderMessage>
    {
        public OrdersGetRequest(string orderId)
            : base("/v2/checkout/orders/{0}?", HttpMethod.Get)
        {
            try
            {
                Path = Path.FormatInvariant(Uri.EscapeDataString(orderId));
            }
            catch (IOException)
            {
            }
        }
    }
}
