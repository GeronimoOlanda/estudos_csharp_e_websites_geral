using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Entities.Util;
using GeroOlanda.Domain.Repository;
using GeroOlanda.Domain.Services;
using System.Security.Cryptography;

namespace GeroOlanda.Domain.Services.Impl
{
    public class AreaTrabalhoService : IAreaTrabalhoService
    {
        private readonly IAreaTrabalhoRepository _areaTrabalhoRepository;
        public AreaTrabalhoService(){}
        public AreaTrabalhoService(IAreaTrabalhoRepository areaTrabalhoRepository)
        {
            _areaTrabalhoRepository = areaTrabalhoRepository;
            
        }

        public AreaTrabalhoDTO AreaTrabalhoDetalhes(AreaTrabalhoDTO AreaTrabalho)
        {
            var response = _areaTrabalhoRepository.AreaTrabalhoDetalhes(AreaTrabalho);

            return response;
        }
    }
}