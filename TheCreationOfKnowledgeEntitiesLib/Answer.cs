using System;
using System.Collections.Generic;
using System.Text;

namespace TheCreationOfKnowledgeEntitiesLib
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Text { get; set; }
        public Question QuestionId { get; set; }
    }
}
