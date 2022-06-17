using Volo.Abp;

namespace Xpto.Livraria
{
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name)
            : base(LivrariaDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
