using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Repository;
using GeroOlanda.Domain.Services;

namespace GeroOlanda.Domain.Services.Impl
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;
        public HomeService()
        {
           
        }
        public  HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public async Task<IList<Home>> Cadastrar(string Descricao)
        {
            var cadastrando = await _homeRepository.Cadastrar(Descricao);

            return cadastrando;
        }

        public Task<IList<HomeDTO>> ConsultarDadosPorIdUsuario(decimal IdUsuario)
        {
            throw new NotImplementedException();
        }

        public string CadastrarUma(string descricao)
        {
            var cadastrando = _homeRepository.CadastrarUma(descricao);
            

            return cadastrando;
          
        }
    }
}