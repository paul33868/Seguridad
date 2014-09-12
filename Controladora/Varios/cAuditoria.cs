using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class cAuditoria
    {
        // Declaro las variables a utilizar en la clase
        private static cAuditoria instancia;
        private Modelo_Entidades.GCI_AuditoriaContainer oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cAuditoria ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cAuditoria();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cAuditoria()
        {
            oModelo_Entidades = Modelo_Entidades.GCI_AuditoriaContainer.ObtenerInstancia();
        }

        // Audito el login de un usuario y agrego la auditoria
        public void AuditarLogUsuario(Modelo_Entidades.Auditoria_Log oAuditoria)
        {
            oModelo_Entidades.AddToAuditorias_Log(oAuditoria);
            oModelo_Entidades.SaveChanges();
        }

        // Obtengo las acciones de todas las auditorias
        public List<string> ObtenerAcciones()
        {
            var Consulta = from oAuditoria in oModelo_Entidades.Auditorias_Log.ToList()
                           group oAuditoria by oAuditoria.accion into Acciones
                           select Acciones.Key;
            return (List<string>)Consulta.ToList();
        }

        // Formateo de la tabla auditorias
        public void FormatearAuditorias()
        {
            foreach (Modelo_Entidades.Auditoria_Log oAuditoria in oModelo_Entidades.Auditorias_Log)
            {
                oModelo_Entidades.DeleteObject(oAuditoria);
            }

            oModelo_Entidades.SaveChanges();
        }

        // Elimino un registro de la tabla "Auditorias"
        public void BajaAuditoria(Modelo_Entidades.Auditoria_Log oAuditoria)
        {
            oModelo_Entidades.Auditorias_Log.DeleteObject(oAuditoria);
            oModelo_Entidades.SaveChanges();
        }

        // Obtener las auditorias
        public List<Modelo_Entidades.Auditoria_Log> ObtenerAuditorias()
        {
            return oModelo_Entidades.Auditorias_Log.ToList();
        }

        // Metodo de filtrado general para todos las auditorias
        public List<Modelo_Entidades.Auditoria_Log> FiltrarAuditorias(string nya, string accion, string fecha_desde, string fecha_hasta)
        {
            var Consulta = from oAuditoria in oModelo_Entidades.Auditorias_Log.ToList()
                           select oAuditoria;

            if (nya != "0")
            {
                Consulta = Consulta.Where(oAuditoria => oAuditoria.usuario.Contains(nya));
            }

            if (accion != "0")
            {
                Consulta = Consulta.Where(oAuditoria => oAuditoria.accion == accion);
            }

            if (fecha_desde != "0")
            {
                Consulta = Consulta.Where(oAuditoria =>  oAuditoria.fecha > Convert.ToDateTime(fecha_desde) && oAuditoria.fecha < Convert.ToDateTime(fecha_hasta));
            }

            return (List<Modelo_Entidades.Auditoria_Log>)Consulta.ToList();
        }

    }
}
