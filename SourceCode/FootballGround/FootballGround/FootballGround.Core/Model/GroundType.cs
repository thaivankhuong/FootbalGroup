//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballGround.Core.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroundType
    {
        public int Id { get; set; }
        public Nullable<int> IdFootballGround { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> IdUserCreate { get; set; }
        public Nullable<int> IdUserUpdate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
