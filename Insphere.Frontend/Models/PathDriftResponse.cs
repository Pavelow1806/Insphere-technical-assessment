using Google.Protobuf.Collections;
using Insphere.Global.Models;
using Insphere.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insphere.Frontend.Models
{
    public class PathDriftResponse : ResponseBase
    {
        public RepeatedField<PathDriftCoordinate> Coordinates { get; set; } = new RepeatedField<PathDriftCoordinate>();
    }
}
