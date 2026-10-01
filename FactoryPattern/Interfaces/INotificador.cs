using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Interfaces
{
    public interface INotificador
    {
        void Enviar(string mensaje);
    }
}
