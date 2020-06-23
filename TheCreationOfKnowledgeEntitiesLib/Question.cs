using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheCreationOfKnowledgeEntitiesLib
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public IQueryable<Answer> Answers { get; set; }
        public Test TestId { get; set; }
    }
}
