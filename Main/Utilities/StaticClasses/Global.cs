using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Utilities.StaticClasses
{
    /// <summary>
    /// Classe globale statica nel quale mettere variabili e metodi accessibili dall'intero progetto
    /// Ad esempio tutto quel che è Read Only. Poi verrà dichiarato uno "using Utilities.StaticClasses" e verrà
    /// chiama la variabile come Global.NomeVariabile
    /// In questo modo se la modifico da una pagina sarà visibile anche dall'altra.
    /// </summary>
    public static class Global
    {
    }
}
