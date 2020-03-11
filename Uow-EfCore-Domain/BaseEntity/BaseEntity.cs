using System;
using System.Collections.Generic;
using System.Text;

namespace Uow_EfCore_Domain
{
    public abstract class BaseEntity
    {
        public int Id { get;  set; }
        public bool Ativo { get; set; }        
    }
}
