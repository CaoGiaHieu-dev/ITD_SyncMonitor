//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SyncMonitor.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LS_Lane
    {
        public int LaneID { get; set; }
        public string LaneCode { get; set; }
        public string Name { get; set; }
        public string StationCode { get; set; }
        public string IpAcdress { get; set; }
        public System.DateTime LastTimeOnline { get; set; }
        public bool IsUsed { get; set; }
    
        public virtual LS_Station LS_Station { get; set; }
    }
}
