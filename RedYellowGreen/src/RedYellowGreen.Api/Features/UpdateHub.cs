using Microsoft.AspNetCore.SignalR;
using RedYellowGreen.Api.Features.Equipment.Models;

namespace RedYellowGreen.Api.Features;

public interface IUpdateHub
{
    Task EquipmentStateChanged(Guid equipmentId, EquipmentState state);
    Task OrderAdded(Guid orderId, Guid equipmentId);
    Task OrderCompleted(Guid orderId);
}

public class UpdateHub : Hub<IUpdateHub>
{
}