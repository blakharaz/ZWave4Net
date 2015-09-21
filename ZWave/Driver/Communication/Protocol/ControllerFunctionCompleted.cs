﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWave.Driver.Communication.Protocol
{
    class ControllerFunctionCompleted : Message
    {
        public readonly byte[] Payload;

        public ControllerFunctionCompleted(Function function, byte[] payload)
            : base(FrameHeader.SOF, MessageType.Response, function)
        {
            Payload = payload;
        }

        public override string ToString()
        {
            if (Payload != null)
            {
                return string.Concat(base.ToString(), " ", string.Format($"Payload:{BitConverter.ToString(Payload)}"));
            }
            return base.ToString();
        }
    }
}
