using EventBusDlls.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBusDlls.AbstractEvent
{  
    /// <summary>
    /// 事件服务总线接口
    /// </summary>
    public interface IEventBus
    {  /// <summary>
       /// 事件发布
       /// </summary>
       /// <param name="event"></param>
        void Publish(IntegrationEvent @event);

        /// <summary>
        /// 订阅
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TH"></typeparam>
        void Subscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>;

        void SubscribeDynamic<TH>(string eventName)
            where TH : IDynamicIntegrationEventHandler;
          

        /// <summary>
        /// 取消订阅 （动态）
        /// </summary>
        /// <typeparam name="TH"></typeparam>
        /// <param name="eventName"></param>
        void UnsubscribeDynamic<TH>(string eventName)
            where TH : IDynamicIntegrationEventHandler;

        /// <summary>
        /// 取消订阅(默认)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TH"></typeparam>
        void Unsubscribe<T, TH>()
            where TH : IIntegrationEventHandler<T>
            where T : IntegrationEvent;
    }
}
