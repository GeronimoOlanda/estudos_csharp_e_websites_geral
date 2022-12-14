using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Repository;
using GeroOlanda.Domain.Services;

namespace GeroOlanda.Domain.Services.Impl
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;

        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public async Task<IList<Home>> Cadastrar(string Descricao)
        {
            var cadastro = new Home
            {
                Descricao = Descricao
            };
           var cadastrando = _homeRepository.Cadastrar(cadastro);

            return cadastrando;
        }

        public Task<IList<HomeDTO>> ConsultarDadosPorIdUsuario(decimal IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}