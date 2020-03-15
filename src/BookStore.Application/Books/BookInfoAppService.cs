using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using BookStore.Books.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Books
{
    public class BookInfoAppService : BookStoreAppServiceBase, IBookInfoAppService
    {

        //Dependency Injection
        private readonly IRepository<BookInfo> _bookInfoRepository;

        public BookInfoAppService(IRepository<BookInfo> bookInfoRepository)
        {
            _bookInfoRepository = bookInfoRepository;
        }

        public async Task<ListResultDto<BookInfoListDto>> GetAll(GetAllBookInfoInput input)
        {
            var bookInfos = await _bookInfoRepository
                .GetAll()
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<BookInfoListDto>(
                ObjectMapper.Map<List<BookInfoListDto>>(bookInfos)
                );
        }
    }
}
