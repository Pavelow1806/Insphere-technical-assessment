﻿using Google.Protobuf.Collections;
using Insphere.Global.Models;
using Insphere.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insphere.Frontend.Models
{
    /// <summary>
    /// Re-implementation of Insphere.Protos.PathDriftCoordinatesResponse, due to a serialization issue with RepeatedFields when using traditional HTTP request.
    /// </summary>
    public class PathDriftResponse : ResponseBase
    {
        public RepeatedField<PathDriftCoordinate> Coordinates { get; set; } = new RepeatedField<PathDriftCoordinate>();
        public double AverageX { get; set; }
        public double AverageY { get; set; }
        public double AverageZ { get; set; }
    }
}
