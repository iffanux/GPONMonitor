﻿namespace GPONMonitor.Models
{
    public class OnuShortDescription
    {
        public uint OltPortId { get; private set; }
        public uint OnuId { get; private set; }
        public string OnuDescription { get; private set; }

        public OnuShortDescription(uint oltPortId, uint onuId, string onuDescription)
        {
            OltPortId = oltPortId;
            OnuId = onuId;
            OnuDescription = onuDescription;
        }
    }
}