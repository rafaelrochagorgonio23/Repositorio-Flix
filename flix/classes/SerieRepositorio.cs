using System;
using System.Collections.Generic;
using flix.interfaces;

namespace flix
{
    public class SerieRepositorio: IRepositorio<Serie>
    {

        private List<Serie> ListaSerie = new List<Serie>();

        //palavra reservada throw = lançar
        public void Atualiza(int id, Serie objeto)
        {
            ListaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            ListaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        //a pilha de dados sempre irá iniciar em zero
        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie retornaId(int id)
        {
            return ListaSerie[id];
        }

        public Serie RetornaporId(int id)
        {
            throw new NotImplementedException();
        }
    }
}