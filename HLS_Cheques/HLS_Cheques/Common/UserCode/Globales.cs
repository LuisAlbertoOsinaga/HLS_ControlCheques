using System;

namespace LightSwitchApplication.UserCode
{
    public static class Globales
    {
        public const string CategoriaEmpresa = "EMPRESA";
        public const string CategoriaSmtpMail = "SMTP";
        public const string CategoriaSolicitudCheque = "CATEGORIA_SOLICITUD_CHEQUE";

        public const string ClaveNombre = "NOMBRE";
        public const string ClaveSmtpMail = "FROM";
        public const string ClaveSolicitudCheque = "CLAVE_SOLICITUD_CHEQUE";

        public const string MensajeNoHayRegistros = "No hay registros";

        public const string SituacionCheque_Preparado = "B";
        public const string SituacionCheque_Solicitado = "S";
        public const string SituacionCheque_Emitido = "E";
        public const string SituacionCheque_Cobrado = "C";
        public const string SituacionCheque_Anulado = "N";

        public const string SMTPServer = "mail.hlasiesta.com";
        public const string SMTPFrom = "admin@hlasiesta.com";
        public const string SMTPUserId = "admin@hlasiesta.com";
        public const string SMTPPassword = "arquimedes";
        // public static string SMTPEnableSsl = "S";
        public static string SMTPEnableSsl = "N";
        // public static string SMTPDeliveryMethod = "Network";
        public static string SMTPDeliveryMethod = "NoNetwork";
        // public const int SMTPPort = 587;

        public const string SolicitudChequeAsuntoMail = "HLS SOLICITUD DE CHEQUES";
        public const string SolicitudChequeRolMail = "DESTINATARIO_SOLICITUDES_CHEQUES";

    }
}
