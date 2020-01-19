using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDlls
{   


    /// <summary>
    /// 动态集成事件处理接口
    /// </summary>
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
