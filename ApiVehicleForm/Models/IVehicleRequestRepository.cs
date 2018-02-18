using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiVehicleForm.Models
{
    interface IVehicleRequestRepository
    {
        bool CheckField(VehicleRequest vehicle);
        ProcessVehicleResponse ProcessVehicle(VehicleRequest vehicle);
    }
}
