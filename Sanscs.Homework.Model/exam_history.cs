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
    
    public partial class exam_history
    {
        public int ID { get; set; }
        public int Students_ID { get; set; }
        public int Questions_ID { get; set; }
        public int Comments_ID { get; set; }
        public System.DateTime TakenOn { get; set; }
        public bool Is_Correct { get; set; }
        public int Time_Used_In_Sec { get; set; }
    
        public virtual dictionary dictionary { get; set; }
        public virtual question question { get; set; }
        public virtual student student { get; set; }
    }
}
