using System;
using System.Threading.Tasks;
using CPAPP.Application.DTOs;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace CPAPP.API.CONSUMER
{
    public class ProdutoConsumer : IConsumer<ProdutoDTO>
    {
        private readonly ILogger<ProdutoConsumer> _logger;

        public ProdutoConsumer(ILogger<ProdutoConsumer> logger)
        {
            _logger = logger;
        }

        public async Task Consume(ConsumeContext<ProdutoDTO> context)
        {
            Console.Write($" Nova Mensagem Recebida: " 
                                    + $"{context.Message.Nome} {context.Message.CodigoProduto}");
        }
    }
}