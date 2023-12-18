using Grpc.Core;
using ToDoGrpc;

namespace ToDoGrpc.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            //_logger.Log("This is the first service that is getting called");
            Message = "Hello " + request.Name
        });
    }
}
