using System.Linq.Expressions;
using agenda_contatos.Models;

namespace agenda_contatos.DataAccess.Repository
{
    public interface IContatoRepository
    {
        Task<List<Contato>> ListarTodosContatos();
        Task<Contato> ListarContatoPorId(Expression<Func<Contato,bool>> filter);
        Task AdicionarContato(Contato contato);
        Task AtualizarContato(Contato contato);
        Task ExcluirContato(Contato contato);
    }
}
 