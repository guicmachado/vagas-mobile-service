using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using System.Threading.Tasks;
using System.Collections.Generic;
using VagasMobileService.Models;
using VagasMobileService.Repositories;

namespace VagasMobileService.Controllers
{
    [RoutePrefix("api/vagas")]
    [MobileAppController]
    public class VagaController : ApiController
    {
        private readonly IVagaRepository _vagaRepository;

        public VagaController()
        {
            _vagaRepository = new VagaRepository();
        }

        [Route("")]
        public async Task<List<Vaga>> GetVagaAsync()
        {
            return await _vagaRepository.GetVagaAsync();
        }

        [Route("{cargoCodigo}")]
        public async Task<IList<Vaga>> GetVagaByCargoCodigoAsync(int cargoCodigo)
        {
            return await _vagaRepository.GetVagaByCargoCodigoAsync(cargoCodigo);
        }
    }
}
