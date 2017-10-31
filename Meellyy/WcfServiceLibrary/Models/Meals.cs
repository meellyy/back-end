using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary.Models
{
    public class Meals
    {
        [ScaffoldColumn(false)]
        [BsonId]
        public ObjectId MealId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Date { get; set; }

        public string Title { get; set; }

        [ScaffoldColumn(false)]
        public string Url { get; set; }

        public string Summary { get; set; }

        [UIHint("WYSIWYG")]
        public string Details { get; set; }

        [ScaffoldColumn(false)]
        public string Author { get; set; }

    }
}
