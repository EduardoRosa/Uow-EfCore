using System;
using System.Collections.Generic;
using System.Text;

namespace Uow_EfCore_Domain
{
    public abstract class Notificacoes
    {

        public List<string> Mensagens { get; private set; }

        public void AdicionaMensagem(string mensagem)
        {
            Mensagens.Add(mensagem);
        }

        public List<string> RetornaMensagens()
        {
            return Mensagens;
        }
    }
}
