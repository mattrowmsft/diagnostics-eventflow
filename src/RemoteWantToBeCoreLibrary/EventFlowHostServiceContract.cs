﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Diagnostics.EventFlow.EventFlowHost
{
    [ServiceContract(Namespace = "eventflow/eventflowhost")]
    public interface IEventFlowHostServiceContract
    {   
        [OperationContract]
        Guid StartSession(string configuration);
        [OperationContract]
        void ReceiveBatch(Guid token, string events);
        [OperationContract]
        void EndSession(Guid token);
    }
}
