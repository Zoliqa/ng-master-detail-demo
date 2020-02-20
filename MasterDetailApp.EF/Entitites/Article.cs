using MasterDetailApp.EF.Utility;
using System;

namespace MasterDetailApp.EF.Entities
{
    public class Article : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public Category Category { get; set; }
    }

    
}