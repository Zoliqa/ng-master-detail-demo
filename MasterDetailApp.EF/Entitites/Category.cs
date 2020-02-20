using MasterDetailApp.EF.Utility;
using System;
using System.Collections.Generic;

namespace MasterDetailApp.EF.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public List<Article> Articles { get; set; }
    }
}