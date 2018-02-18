using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiVehicleForm.Models
{
    public class VehicleRequestRepository : IVehicleRequestRepository
    {
        public bool CheckField(VehicleRequest vehicle)
        {
            if (vehicle.VehicleId > 0)
            {
                if (vehicle.Type != String.Empty)
                {
                    if (vehicle.ManufacturerNameShort != String.Empty)
                    {
                        if (vehicle.Price > 0)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public ProcessVehicleResponse ProcessVehicle(VehicleRequest vehicle)
        {
            if (vehicle == null)
            {
                return new ProcessVehicleResponse() { VehicleId = vehicle.VehicleId, VehicleValidationResultCode = ProcessVehicleResponse.StateValidation.NotSpecified.ToString() };
            }
            else
            {
                return new ProcessVehicleResponse()
                {
                    VehicleId = vehicle.VehicleId,
                    VehicleValidationResultCode = CheckField(vehicle) ? ProcessVehicleResponse.StateValidation.Valid.ToString() : ProcessVehicleResponse.StateValidation.Invalid.ToString()
                };
            }
        }
    }
}