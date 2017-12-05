using System.Collections.Generic;

namespace Clinic.Core
{
    public class Office
    {
        public Doctor Doctor { get; set; }

        public Practice Practice { get; set; }

        public List<Availability> Schedule { get; set; }
    }
}
