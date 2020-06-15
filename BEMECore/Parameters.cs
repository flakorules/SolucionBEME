using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace BEME.Core
{
    public static class Parameters
    {
        public static class ConnectionStrings
        {
            public static string BEMEStrConn
            {
                get
                {
                    return ConfigurationManager.ConnectionStrings["BEMEStrConn"].ConnectionString;
                }
            }
        }

        public static class NegativeNumbers
        {
            /// <summary>
            /// Number -1
            /// </summary>
            public static int ONE = -1;
        }

        public static class PositiveNumbers
        {
            /// <summary>
            /// Number 0
            /// </summary>
            public static int ZERO = 0;
            /// <summary>
            /// Number 1
            /// </summary>
            public static int ONE = 1;
        }

        public enum TipoEmpresa
        {
            PersonaNatural = 1,
            PersonaJuridica = 2,
            ClienteAntiguo = 3
        }

        public enum TipoPersonaJuridica
        {
            NA = 0,
            EIRL = 1,
            SociedadLimitada = 2,
            SociedadAccionesUnSocio = 3,
            SociedadAccionesMasUnSocio = 4,
            SociedadAnonima = 5,
            Corporaciones = 6,
            FundacionesSindicatosJuntasVecinosONGOtras = 7
        }

        public static class Paths 
        {
            public static string FrmPersonaNatural = @"~/DatosPersonaNatural.aspx";
            public static string FrmPersonaJuridica = @"~/DatosPersonaJuridica.aspx";
            public static string FrmClienteAntiguo = @"~/DatosClienteAntiguo.aspx";
            public static string FrmConsultaClienteAntiguo = @"~/ConsultaClienteAntiguo.aspx";
        }

        public enum FormAction
        {
            Insert = 1,
            Update = 2,
            Select = 3,
            Delete = 4
        }

        public static class Texts 
        {
            /// <summary>
            /// Texto "onkeypress"
            /// </summary>
            public static string OnKeyPress = "onkeypress";
        }

        public static class FormatStrings 
        {
            /// <summary>
            /// ClickEnter(this,'{0}');
            /// </summary>
            public static string OnKeyPressButtonClick = "ClickEnter(this,'{0}');";
        }
    }
}
