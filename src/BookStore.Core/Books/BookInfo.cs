using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.Books
{
    [Table("BookInfo")]
    public class BookInfo : Entity, IHasCreationTime
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1020;


        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public string Summary { get; set; }

        public DateTime CreationTime { get; set; }

        public BookInfo(string title, string description, string summary)
        {
            Title = title;
            Description = description;
            Summary = summary;
        }
    }
}
