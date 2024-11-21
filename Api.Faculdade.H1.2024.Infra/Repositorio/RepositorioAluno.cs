using Api.Faculdade.H1._2024.Dominio.Dto;
using Api.Faculdade.H1._2024.Dominio.Interfaces.IRepositorio;

namespace Api.Faculdade.H1._2024.Infra.Repositorio
{
    public class RepositorioAluno : IRepositorioAluno
    {
        private readonly List<DadosAluno> _alunos = new List<DadosAluno>();

        public void Adicionar(DadosAluno aluno)
        {
            _alunos.Add(aluno);
        }
        public List<DadosAluno> BuscarTodos()
        {
            return _alunos;
        }
        public DadosAluno BuscarPorId(int id)
        {
            return _alunos.FirstOrDefault(a => a.Id == id);
        }

        public DadosAluno BuscarPorRA(string ra)
        {
            return _alunos.FirstOrDefault(a => a.RA == ra);
        }
        public void Atualizar(DadosAluno aluno)
        {
            var alunoExistente = BuscarPorId(aluno.Id);
            if (alunoExistente != null)
            {
                alunoExistente.Nome = aluno.Nome;
                alunoExistente.RA = aluno.RA;
            }
        }
        public void Remover(int id)
        {
            var aluno = BuscarPorId(id);
            if (aluno != null)
            {
                _alunos.Remove(aluno);
            }
        }
    }
}