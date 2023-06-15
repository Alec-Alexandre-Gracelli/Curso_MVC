using Curso_MVC.Context;
using Curso_MVC.Models;

namespace Curso_MVC.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
