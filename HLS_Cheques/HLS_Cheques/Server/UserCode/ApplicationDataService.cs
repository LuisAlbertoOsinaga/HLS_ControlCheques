using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;

using LightSwitchApplication.UserCode;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void Secuencias_Inserting(Secuencia entity)
        {
            // Si secuencia existe la borra
            Secuencia secGet = (from s in DataWorkspace.ApplicationData.Secuencias
                                where s.Catagoria == entity.Catagoria && s.Clave == entity.Clave
                                select s).FirstOrDefault();
            if (secGet != null)
                secGet.Delete();

            if (entity.NroInicial <= 0)
                entity.NroInicial = 1;

            if (entity.NroFinal <= 0 || entity.NroFinal <= entity.NroInicial)
                entity.NroFinal = int.MaxValue - 2;

            if (entity.NroActual < entity.NroInicial - 1)
                entity.NroActual = entity.NroInicial.Value - 1;
            if (entity.NroActual >= entity.NroFinal)
                entity.NroActual = entity.NroInicial.Value - 1;
        }

        partial void Secuencias_Updating(Secuencia entity)
        {
            // Busca secuencia
            Secuencia secGet = (from s in DataWorkspace.ApplicationData.Secuencias
                                where s.Catagoria == entity.Catagoria && s.Clave == entity.Clave
                                select s).FirstOrDefault();
            if (secGet != null)
                return;

            if (secGet.NroActual < secGet.NroFinal)
                entity.NroActual = secGet.NroActual++;
            else
                entity.NroActual = entity.NroInicial.Value - 1;
        }

        partial void OperacionEMails_Inserting(OperacionEMail entity)
        {
            ServiceMail.SendMail(entity.Enviante, entity.Destinatario, entity.Asunto, entity.Cuerpo);
        }
    }
}
