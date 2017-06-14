using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VagasMobileService.Models;

namespace VagasMobileService.Repositories
{
    public interface ICargoRepository
    {
        Task<List<Cargo>> GetCargoAsync();
    }
}
