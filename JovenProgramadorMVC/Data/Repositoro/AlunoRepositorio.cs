using JovenProgramadorMVC.Data.Repositoro.Interfaces;
using JovenProgramadorMVC.Models;

namespace JovenProgramadorMVC.Data.Repositoro
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Aluno> BuscarAluno()
        {
            return _bancoContexto.Aluno.ToList();
        }
    }
}
