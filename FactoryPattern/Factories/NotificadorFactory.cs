using FactoryPattern.Interfaces;
using FactoryPattern.Notificadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factories
{
    public class NotificadorFactory : INotificadorFactory
    {
        public INotificador CrearNotificador(TipoNotificacion tipo)
        {
            return tipo switch
            {
                TipoNotificacion.Email => new EmailNotificador(),
                TipoNotificacion.SMS => new SmsNotificador(),
                TipoNotificacion.Teams => new TeamsNotificador(),
                _ => throw new ArgumentException("Tipo de notificación no soportado.")
            };
        }
    }
    public enum TipoNotificacion
    {
        Email = 1,
        SMS = 2,
        Teams = 3
    }
}
