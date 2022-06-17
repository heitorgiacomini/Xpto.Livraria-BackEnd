using System;
using Volo.Abp.Application.Dtos;

namespace Xpto.Livraria
{
    public class AuthorLookupDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
