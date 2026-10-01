using FactoryPattern.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Interfaces
{
    public interface INotificadorFactory
    {
        INotificador CrearNotificador(TipoNotificacion tipo);
    }
}
