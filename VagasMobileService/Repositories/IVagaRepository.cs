using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VagasMobileService.Models;

namespace VagasMobileService.Repositories
{
    public interface IVagaRepository
    {
        Task<List<Vaga>> GetVagaByCargoCodigoAsync(int cargoCodigo);

        Task<List<Vaga>> GetVagaAsync();
    }
}
