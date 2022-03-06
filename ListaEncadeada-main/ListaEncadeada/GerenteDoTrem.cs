using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
     public class GerenteDoTrem
    {
        public Vagao Locomotiva { get; set; }

        #region Create
        public void InserirVagao(Vagao novoVagao)
        {
            if (Locomotiva == null)
            {
                Locomotiva = novoVagao;
            }
            else
            {
                var ultimoVagao = GetUltimoVagao();
                ultimoVagao.Atras = novoVagao;
            }
        }

        private Vagao GetUltimoVagao()
        {
            var tempVagao = Locomotiva;
            while (tempVagao.Atras != null)
            {
                tempVagao = tempVagao.Atras;
            }
            return tempVagao;
        }
        #endregion

        #region Read
        public List<Vagao> GetVagoes()
        {
            var trem = new List<Vagao>();
            var tempVagao = Locomotiva;
            while (tempVagao != null)
            {
                trem.Add(tempVagao);
                tempVagao = tempVagao.Atras;
            }
            return trem;
        }
        #endregion
        #region Update
        public void AtualizarVagao(Vagao vagao)
        {
            var tempVagao = Locomotiva;
            while (tempVagao != null)
            {
                if (vagao.Id == tempVagao.Id)
                {
                    tempVagao.Carga = vagao.Carga;
                    tempVagao.PesoEmToneladas = vagao.PesoEmToneladas;
                    return;
                }
                tempVagao = tempVagao.Atras;
            }
        }
        #endregion

        #region Delete
        public void DeletarVagao(int vagaoId)
        {
            var tempVagao = Locomotiva;
            if (Locomotiva.Id == vagaoId)
            {
                Locomotiva = Locomotiva.Atras;
            }
            else
            {
                while (tempVagao != null)
                {
                    if (vagaoId == tempVagao.Atras.Id)
                    {
                        tempVagao.Atras = tempVagao.Atras.Atras;
                        return;
                    }
                    tempVagao = tempVagao.Atras;
                }
            }

        }
        #endregion
    }
}
