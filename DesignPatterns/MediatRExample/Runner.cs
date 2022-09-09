using MediatR;

namespace MediatRExample
{
    public static class Runner
    {
        public static async Task Run(IMediator mediator, WrappingWriter writer)
        {
            await writer.WriteLineAsync("Sending Ping...");
            var pong = await mediator.Send(new Ping { Message = "Ping" });
            await writer.WriteLineAsync("Received: " + pong);
            await writer.WriteLineAsync();
        }
    }
}
