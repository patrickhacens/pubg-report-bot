﻿namespace PUBG.Models.Telemetry
{
    public class ItemPickupFromCustomPackage : Event
    {
        public Character Character { get; set; }

        public Item Item { get; set; }
    }
}
