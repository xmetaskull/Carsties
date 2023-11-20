using Contracts;
using MassTransit;
using MongoDB.Entities;

namespace SearchService;

public class AuctionDeletedConsumer
{
    public async Task Consume(ConsumeContext<AuctionDeleted> context)
    {
        Console.WriteLine("--> Consuming AuctionDeleted: " + context.Message.id);

        var result = await DB.DeleteAsync<Item>(context.Message.id);

        if(!result.IsAcknowledged)
            throw new MessageException(typeof(AuctionDeleted), "Problem deleting auction.");
    }
}
