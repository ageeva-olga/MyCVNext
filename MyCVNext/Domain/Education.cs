using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Domain
{
    public class Education
    {
        public int Begin { get; set; }

        public int End { get; set; }

        public string SchoolName { get; set; }

        public Guid Id { get; set; }
    }
}
