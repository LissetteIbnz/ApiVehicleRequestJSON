using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiVehicleForm.Models
{
    public class ProcessVehicleResponse
    {
        public int VehicleId { get; set; }
        public string VehicleValidationResultCode { get; set; }
        public enum StateValidation
        {
            NotSpecified = 0,
            Valid = 1,
            Invalid = 2
        }
    }
}