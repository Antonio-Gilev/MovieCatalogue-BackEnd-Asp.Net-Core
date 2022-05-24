using System;
using System.Collections.Generic;
using System.Text;

namespace MC.Domain.DTO
{
    public class PersonDTO
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Image { get; set; }

        public ICollection<int> roles { get; set; }
        public ICollection<Guid> peopleOnMovie { get; set; }
    }
}
