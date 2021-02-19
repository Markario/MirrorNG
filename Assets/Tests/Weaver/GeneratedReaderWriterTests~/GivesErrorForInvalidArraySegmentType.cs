﻿using System;
using Mirage;
using UnityEngine;

namespace GeneratedReaderWriter.GivesErrorForInvalidArraySegmentType
{
    public class GivesErrorForInvalidArraySegmentType : NetworkBehaviour
    {
        [ClientRpc]
        public void RpcDoSomething(ArraySegment<MonoBehaviour> data)
        {
            // empty
        }
    }
}
