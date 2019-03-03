using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetproject.Models
{
    public class StudentTerm
    {
        public int StudentTermID { get; internal set; }
        public int DegreePlanId { get; internal set; }
        public int Term { get; internal set; }
        public string TermAbbrev { get; internal set; }
        public string TermName { get; internal set; }
    }
}
