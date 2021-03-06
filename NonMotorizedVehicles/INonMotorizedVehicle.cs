﻿using Enumerations;

namespace NonMotorizedVehicles
{
   interface  INonMotorizedVehicle
   {
        bool HasPedals { get; set; }
        int NoOfWheels { get; set; }
        TerrainType TerrainType { get; set; }

        bool Moving(bool isMoving);
        bool Riding(bool isMoving);
   }
}
