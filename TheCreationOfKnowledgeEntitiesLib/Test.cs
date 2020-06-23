using System;
using System.Collections.Generic;
using System.Text;

namespace TheCreationOfKnowledgeEntitiesLib
{
    public class Test
    {
        public int TestId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public User CreatedByUserId { get; set; }
    }
}
