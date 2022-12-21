﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Security.Policy;

namespace Szilveszter_Levente_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required, StringLength(150, MinimumLength = 3)]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", ErrorMessage = "Numele autorului trebuies"), Required, StringLength(50, MinimumLength = 3)]
        //^ marcheaza inceputul sirului de caractere
        //[A-Z][a-z]+ prenumele -litera mare urmata de oricate litere mici
        //\s spatiu
        //[A-Z][a-z]+ numele -litera mare urmata de oricate litere mici
        //$ marcheaza sfarsitul sirului de caractere

        public int AuthorID { get; set; }
        public Author Author { get; set; }

        [Range(1, 300)]
        [Column(TypeName = "decimal(6, 2)")]        
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; } //navigation property
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}

