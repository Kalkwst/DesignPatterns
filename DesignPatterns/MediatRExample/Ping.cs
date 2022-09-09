using MediatR;

namespace MediatRExample
{
    public class Ping : IRequest<string>
    {
        public string Message { get; set; }
    }
}
