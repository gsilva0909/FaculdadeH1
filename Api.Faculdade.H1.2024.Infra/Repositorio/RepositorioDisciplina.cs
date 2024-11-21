using Api.Faculdade.H1._2024.Dominio.Dto;
using Api.Faculdade.H1._2024.Dominio.Interfaces.IRepositorio;

namespace Api.Faculdade.H1._2024.Infra.Repositorio
{
    public class RepositorioDisciplina : IRepositorioDisciplina
    {
        private readonly List<DadosDisciplina> _disciplinas = new List<DadosDisciplina>();

        public void Adicionar(DadosDisciplina disciplina)
        {
            _disciplinas.Add(disciplina);
        }
        public List<DadosDisciplina> BuscarTodas()
        {
            return _disciplinas;
        }
        public DadosDisciplina BuscarPorId(int id)
        {
            return _disciplinas.FirstOrDefault(d => d.IdDisciplina == id);
        }
        public DadosDisciplina BuscarPorNome(string nome)
        {
            return _disciplinas.FirstOrDefault(d => d.Nome == nome);
        }
        public void Atualizar(DadosDisciplina disciplina)
        {
            var disciplinaExistente = BuscarPorId(disciplina.IdDisciplina);
            if (disciplinaExistente != null)
            {
                disciplinaExistente.Nome = disciplina.Nome;
                disciplinaExistente.Curso = disciplina.Curso;
            }
        }
        public void Remover(int id)
        {
            var disciplina = BuscarPorId(id);
            if (disciplina != null)
            {
                _disciplinas.Remove(disciplina);
            }
        }
    }
}
