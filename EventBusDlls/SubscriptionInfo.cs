﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EventBusDlls
{
    public partial class InMemoryEventBusSubscriptionsManager: IEventBusSubscriptionsManager
    {  

        /// <summary>
        /// 订阅信息 
        /// </summary>
        public class SubscriptionInfo
        {
            public bool IsDynamic { get; }
            public Type HandlerType { get; }

            private SubscriptionInfo(bool isDynamic, Type handlerType)
            {
                IsDynamic = isDynamic;
                HandlerType = handlerType;
            }

            public static SubscriptionInfo Dynamic(Type handlerType)
            {
                return new SubscriptionInfo(true, handlerType);
            }
            public static SubscriptionInfo Typed(Type handlerType)
            {
                return new SubscriptionInfo(false, handlerType);
            }
        }
    }
}
