using DecomporWebService.Models;

namespace DecomporWebService.Services.DivisoresService
{
    public interface IDivisoresService
    {
        DivisoresResposta ObterTodos(int numero);
        int[] ObterNaturais(int numero);
        int[] ObterPrimos(int numero);
    }
}
