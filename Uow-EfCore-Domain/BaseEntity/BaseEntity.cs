using System;
using System.Collections.Generic;
using System.Text;

namespace Uow_EfCore_Domain
{
    public abstract class BaseEntity : Notificacoes
    {
        public int Id { get; private set; }
        public bool Ativo { get; private set; }        
    }
}
