using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidade;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfdbContext _context = new EfdbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

    }
}
