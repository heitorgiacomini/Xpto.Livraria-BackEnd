using Volo.Abp.Application.Dtos;

namespace Xpto.Livraria
{
    public class GetAuthorListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }

    }
}
