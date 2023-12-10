using Decompor.Library;
using DecomporWebService.Models;

namespace DecomporWebService.Services.DivisoresService
{
    public class DivisoresService : IDivisoresService
    {
        public DivisoresResposta ObterTodos(int numero)
        {
            DivisoresResposta resposta = new DivisoresResposta();
            Divisores divisores = new Divisores(numero);

            resposta.Naturais = divisores.DivisoresNaturais.ToArray();
            resposta.Primos = divisores.DivisoresPrimos.ToArray();

            return resposta;
        }

        public int[] ObterNaturais(int numero)
        {
            Divisores divisores = new Divisores();
            return divisores.ObterDivisores(numero).ToArray();
        }

        public int[] ObterPrimos(int numero)
        {
            Divisores divisores = new Divisores();
            return divisores.ObterDivisoresPrimos(numero).ToArray();
        }
    }
}
