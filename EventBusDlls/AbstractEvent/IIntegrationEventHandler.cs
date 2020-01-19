using EventBusDlls.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDlls
{  
    /// <summary>
    /// 事件处理程序
    /// </summary>
    public interface IIntegrationEventHandler
    {

    }

    public interface IIntegrationEventHandler<in TIntegrationEvent>: IIntegrationEventHandler
        where TIntegrationEvent : IntegrationEvent
    {
        Task Handle(TIntegrationEvent @event);
    }
}
