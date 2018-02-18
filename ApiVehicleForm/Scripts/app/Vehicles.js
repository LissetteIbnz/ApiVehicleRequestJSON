$(document).ready(function () {

    var createVehicle = function (item) {
        $.ajax({
            url: "/api/vehiclesrequest/",
            data: JSON.stringify(item),
            type: "POST",
            contentType: "application/json;cardset=utf-8",
            statusCode: {
                202: function (data) {
                    alert("The new vehicle was processed with Id " + data.VehicleId + " and return code " + data.VehicleValidationResultCode);
                }
            }
        });
    };

    $("#createVehicle").click(function () {
        var vehicle = {
            VehicleId: $("#VehicleId").val(),
            Type: $("#TypeVehicle").val(),
            ManufacturerNameShort: $("#ManufacturerNameShortVehicle").val(),
            Price: $("#PriceVehicle").val()
        };

        createVehicle(vehicle);
    });
});