using System.Collections.Generic;

namespace flix.interfaces
{
    //T indica uma classe generica 
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaporId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
         
    }
}