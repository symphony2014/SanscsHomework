//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sanscs.Homework.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class difficultyweight
    {
        public int Tags_ID { get; set; }
        public int Difficulties_ID { get; set; }
        public int Weight { get; set; }
        public int Knowledge_Points_ID { get; set; }
    
        public virtual difficulty difficulty { get; set; }
        public virtual knowledge_points knowledge_points { get; set; }
        public virtual tag tag { get; set; }
    }
}
