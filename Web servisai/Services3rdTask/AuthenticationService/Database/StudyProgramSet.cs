//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthenticationService.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudyProgramSet
    {
        public StudyProgramSet()
        {
            this.ProgramSubjectsSets = new HashSet<ProgramSubjectsSet>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
    
        public virtual ICollection<ProgramSubjectsSet> ProgramSubjectsSets { get; set; }
    }
}
