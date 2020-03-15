using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BookStore.Books.Dto;
using System.Threading.Tasks;

namespace BookStore.Books
{
    public interface IBookInfoAppService : IApplicationService
    {
        Task<ListResultDto<BookInfoListDto>> GetAll(GetAllBookInfoInput input);
    }
}
