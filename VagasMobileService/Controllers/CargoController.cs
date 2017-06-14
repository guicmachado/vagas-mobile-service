using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using VagasMobileService.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using VagasMobileService.Models;

namespace VagasMobileService.Controllers
{
    [RoutePrefix("api/cargos")]
    [MobileAppController]
    public class CargoController : ApiController
    {
        private readonly ICargoRepository _cargoRepository;

        public CargoController() {
            _cargoRepository = new CargoRepository(new VagaRepository());
        }

        [Route("")]
        public async Task<List<Cargo>> GetCargoAsync()
        {
            return await _cargoRepository.GetCargoAsync();
        }
    }
}
