using System;
using System.Collections.Generic;
using System.Text;

namespace IntroWinForms
{
    internal class Tarefa
    {
        private string descricao = string.Empty;
        private bool concluida;

        public override string ToString()
        {
            return descricao;
        }

        public string GetDescricao()
        {
            return descricao;
        }

        public void SetDescricao(string desc)
        {
            descricao = desc;
        }

        public bool GetConcluida()
        {
            return concluida;
        }

        public void SetConcluida(bool conc)
        {
            concluida = conc;
        }
    }
}
