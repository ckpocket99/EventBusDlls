using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBusDlls.Events
{  
    /// <summary>
    /// 事件
    /// </summary>
    public class IntegrationEvent
    {
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
        }

        [JsonConstructor]
        public IntegrationEvent(Guid id, DateTime createDate)
        {
            Id = id;
            CreateDate = createDate;
        }




        /// <summary>
        /// 事件唯一标识ID
        /// </summary>
        [JsonProperty]
        public Guid Id { get; private set; }

        /// <summary>
        /// 事件生成时间
        /// </summary>
        [JsonProperty]
        public DateTime CreateDate { get; private set; }
    }
}
