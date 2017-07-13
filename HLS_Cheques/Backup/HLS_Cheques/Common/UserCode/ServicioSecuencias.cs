using System;
using System.Linq;

namespace LightSwitchApplication.UserCode
{
    public static class ServicioSecuencias
    {
        public static void InitSecuencia(string categoria, string clave, int nroInicial = 0, int nroFinal = 0, int nroActual = 0)
        {
            using (DataWorkspace dw = new DataWorkspace())
            {
                Secuencia sec = dw.ApplicationData.Secuencias.AddNew();
                sec.Catagoria = categoria;
                sec.Clave = clave;
                sec.NroInicial = nroInicial;
                sec.NroFinal = nroFinal;
                sec.NroActual = nroActual;

                dw.ApplicationData.SaveChanges();
            }
        }
         
        public static Secuencia GetSecuencia(string categoria, string clave)
        {
            Secuencia sec = null;

            using (DataWorkspace dw = new DataWorkspace())
            {
                foreach (Secuencia s in dw.ApplicationData.Secuencias)
                {
                    if (s.Catagoria == categoria && s.Clave == clave)
                    {
                        sec = s;
                        break;
                    }
                }
            }

            return sec;
        }

        public static Secuencia PeekSecuencia(string categoria, string clave)
        {
            Secuencia sec = GetSecuencia(categoria, clave);
            if (sec != null)
            {
                using (DataWorkspace dw = new DataWorkspace())
                {
                    Secuencia secUpd = dw.ApplicationData.Secuencias_Single(sec.Id);
                    secUpd.NroFinal++;
                    dw.ApplicationData.SaveChanges();
                    sec = dw.ApplicationData.Secuencias_Single(sec.Id);
                }
            }
            
            return sec;
        }
    }
}
