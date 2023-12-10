using DecomporWebService.Models;

namespace DecomporWebService.Services.DivisoresImplementations
{
    public interface IDecomporDivisoresService
    {
        DivisoresResposta ObterTodos(int numero);
        DivisoresResposta ObterNaturais(int numero);
        DivisoresResposta ObterPrimos(int numero);
    }
}
