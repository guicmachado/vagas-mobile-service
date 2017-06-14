using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VagasMobileService.Models;

namespace VagasMobileService.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private readonly IVagaRepository _vagaRepository;

        public CargoRepository(IVagaRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }

        public async Task<List<Cargo>> GetCargoAsync()
        {
            var vagas = await _vagaRepository.GetVagaAsync();
            return await Task.FromResult(vagas.GroupBy(c => c.Cargo.Codigo).Select(g => g.First().Cargo).ToList());
        }
    }
}