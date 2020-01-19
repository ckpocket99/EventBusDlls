using EventBusDlls.Events;
using System;
using System.Collections.Generic;
using System.Text;
using static EventBusDlls.InMemoryEventBusSubscriptionsManager;

namespace EventBusDlls
{   
    /// <summary>
    ///  事件订阅管理器
    /// @version 1.0.0
    /// @author chenkai
    /// @param
    /// </summary>
    public interface IEventBusSubscriptionsManager
    {   

        /// <summary>
        /// 是否为空
        /// </summary>
        bool IsEmpty { get; }

        event EventHandler<string> OnEventRemove;

        /// <summary>
        /// 新增事件订阅(动态)
        /// </summary>
        /// <typeparam name="TH"></typeparam>
        /// <param name="eventName"></param>
        void AddDynamicSubscription<TH>(string eventName) where TH : IDynamicIntegrationEventHandler;

        void AddSubscription<T, TH>()
          where T : IntegrationEvent
          where TH : IIntegrationEventHandler<T>;


        /// <summary>
        /// 删除事件订阅
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TH"></typeparam>
        void RemoveSubscription<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>;


        void RemoveDynamicSubscription<TH>(string eventName)
           where TH : IDynamicIntegrationEventHandler;

        /// <summary>
        /// 事件是否已订阅
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool HasSubscriptionsForEvent<T>() where T : IntegrationEvent;

        bool HasSubscriptionsForEvent(string eventName);

        /// <summary>
        /// 获取事件类型名字
        /// </summary>
        /// <param name="eventName"></param>
        /// <returns></returns>
        Type GetEventTypeByName(string eventName);


        /// <summary>
        /// 清空
        /// </summary>
        void Clear();

        IEnumerable<SubscriptionInfo> GetHandlersForEvent<T>() where T : IntegrationEvent;


        IEnumerable<SubscriptionInfo> GetHandlersForEvent(string eventName);

        /// <summary>
        /// 获得事件字典KEY的值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        string GetEventKey<T>();

    }
}
