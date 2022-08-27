namespace Microsoft.eShopOnContainers.Services.Ordering.API.Application.Commands;
using Microsoft.eShopOnContainers.Services.Ordering.API.Application.Models;
public class CompleteOrderCommand : IRequest<bool>
{

    [DataMember]
    public int OrderNumber { get; private set; }

    public CompleteOrderCommand(int orderNumber)
    {
        OrderNumber = orderNumber;
    }

}
