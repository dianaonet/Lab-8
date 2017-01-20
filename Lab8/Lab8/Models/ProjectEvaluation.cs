using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab8.Models
{
    [Bind(Exclude = "Country")]

    public class ProjectEvaluation
    {

        [MaxWords(6)]
        public string name { get; set; }

        [Required]
        [StringLength(1000)]
        [MinWords(2)]
        public string city { get; set; }

        public string country { get; set; }

        [Range(1, 10)]
        [Required]
        public double rating { get; set; }

        public int id { get; set; }
    }
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (rating < 2 && name.ToLower().StartsWith("john"))
            yield return new ValidationResult("Ne pare rau");
    }

    public IEnumerable<ValidationResult> Validare(ValidationContext validationContext)
    {
        if (rating > 9 && name.ToLower().StartsWith("diana"))
            yield return new ValidationResult("Good job !!!");
    }
}