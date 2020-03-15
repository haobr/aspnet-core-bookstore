using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;

namespace BookStore.Books.Dto
{
    [AutoMapFrom(typeof(BookInfo))]
    public class BookInfoListDto : EntityDto, IHasCreationTime
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
