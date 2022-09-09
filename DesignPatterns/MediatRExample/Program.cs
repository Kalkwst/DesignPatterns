using MediatR;

namespace MediatRExample
{
    public static class Program
    {
        public static Task Main(string[] args)
        {
            var writer = new WrappingWriter(Console.Out);
            var mediator = BuildMediator(writer);
            return Runner.Run(mediator, writer);
        }

        private static IMediator BuildMediator(WrappingWriter writer)
        {
            var services = new ServiceCollection();

            services.AddSingleton<TextWriter>(writer);

            services.AddMediatR(typeof(Ping));

            /*            

                        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(GenericPipelineBehavior<,>));
                        services.AddScoped(typeof(IRequestPreProcessor<>), typeof(GenericRequestPreProcessor<>));
                        services.AddScoped(typeof(IRequestPostProcessor<,>), typeof(GenericRequestPostProcessor<,>));
                        services.AddScoped(typeof(IStreamPipelineBehavior<,>), typeof(GenericStreamPipelineBehavior<,>));*/

            var provider = services.BuildServiceProvider();

            return provider.GetRequiredService<IMediator>();
        }
    }
}
