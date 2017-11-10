using System.Collections.Generic;

public interface IProdutoRepositorio
{
    IEnumerable<Produto> GetAll();
    Produto Get(int id);
    Produto Add(Produto item);
    void Remove(int id);
    bool Update(Produto item);
}