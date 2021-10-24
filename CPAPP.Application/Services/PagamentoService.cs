using System.Threading.Tasks;
using AutoMapper;
using CPAPP.Application.DTOs;
using CPAPP.Application.Interfaces;
using CPAPP.Domain.Entities;
using CPAPP.Domain.Interfaces;
using Microsoft.VisualBasic;

namespace CPAPP.Application.Services
{
    public class PagamentoService : IPagamentoService
    {
        private IPagamentoRepository _pagamentoRepository;

        private readonly IMapper _mapper;

        public PagamentoService(IPagamentoRepository pagamentoRepository, IMapper mapper)
        {
            _pagamentoRepository = pagamentoRepository;
            _mapper = mapper;
        }

        public async Task PagamentoCartao(PagamentoDTO pagamentoDto, Produto nome)
        {
            //var pagamentoEntity = _mapper.Map<Pagamento>(pagamento);
            var pagamentoMont = MountObject();
            await _pagamentoRepository.PagamentoCartao(pagamentoMont, nome);
        }

        public Pagamento MountObject()
        {
            var pagamento = new Pagamento();
            pagamento.DataValidade = "34/29";
            pagamento.CodigoSeguranca = 333;
            pagamento.NomeCartao = "teste";
            pagamento.NumeroCartao = "324242";
            return pagamento;
        }
    }
}