using Decompor.Library;
using DecomporWebService.Models;

namespace DecomporWebService.Services.DivisoresImplementations
{
    public class DivisoresServiceImplementation : IDecomporDivisoresService
    {
        public DivisoresResposta ObterTodos(int numero)
        {
            DivisoresResposta resposta = new DivisoresResposta();
            Divisores divisores = new Divisores(numero);

            resposta.Naturais = divisores.DivisoresNaturais.ToArray();
            resposta.Primos = divisores.DivisoresPrimos.ToArray();

            return resposta;
        }

        public DivisoresResposta ObterNaturais(int numero)
        {
            DivisoresResposta resposta = new DivisoresResposta();
            Divisores divisores = new Divisores();
            resposta.Naturais = divisores.ObterDivisores(numero).ToArray();
            return resposta;
        }

        public DivisoresResposta ObterPrimos(int numero)
        {
            DivisoresResposta resposta = new DivisoresResposta();
            Divisores divisores = new Divisores();
            resposta.Primos = divisores.ObterDivisoresPrimos(numero).ToArray();
            return resposta;
        }
    }
}
