using Api.Faculdade.H1._2024.Dominio.Dto;
using Api.Faculdade.H1._2024.Dominio.Interfaces.IRepositorio;

namespace Api.Faculdade.H1._2024.Infra.Repositorio
{
    public class RepositorioNotaAluno : IRepositorioNotaAluno
    {
        private readonly List<DadosNotaAluno> _notasAlunos = new List<DadosNotaAluno>();
        public void Adicionar(DadosNotaAluno notaAluno)
        {
            _notasAlunos.Add(notaAluno);
        }

        public List<DadosNotaAluno> BuscarTodos()
        {
            return _notasAlunos;
        }

        public DadosNotaAluno BuscarPorAlunoEDisciplina(string raAluno, int idDisciplina)
        {
            return _notasAlunos.FirstOrDefault(n => n.RaAluno == raAluno && n.IdDisciplina == idDisciplina);
        }

        public List<DadosNotaAluno> BuscarAprovados()
        {
            return _notasAlunos.Where(n => n.Nota >= 7 && n.Frequencia >= 75).ToList();
        }

        public List<DadosNotaAluno> BuscarReprovados()
        {
            return _notasAlunos.Where(n => n.Nota < 7 || n.Frequencia < 75).ToList();
        }

    }
}
