using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    /// <summary>
    /// Enum Status Room
    /// </summary>
    public enum STATUSROOM
    {
        AVAILABLE,
        BUSY,
        REPAIR,
        RESTRUCTURATION
    }

    /// <summary>
    /// Enum of restaurant
    /// </summary>
    public enum SERVICERESTAURANT
    {
        ANTIPASTI,
        PRIMI,
        RISOTTI,
        PESCI,
        CARNI,
        DESSER
    }

    /// <summary>
    /// Enum of service of Hotel (what can you find in room or in hotel)
    /// </summary>
    public enum SERVICEHOTEL
    {
        BATHROOM,
        GENERAL_SERVICE,
        ROOM,
        FREE_SPACE,
        KITCHEN,
        ACCESSIBILITY,
        BAR_RESTAURANT,
        MEDIA_TV,
        INTERNET,
        PARKING,
        CLEANING_ROOM,
        WELLNESS,
        HOSPITALITY,
        SNACK_DRINK,
        ENTERTAINMENT,
        BUSINESS,
        SECURITY,
        LANGUAGES
    }


    /// <summary>
    /// Tipi di accesso disponibili, ogniuno con funzioni diverse
    /// </summary>
    public enum ACCESSEMPLOYEES
    {
        RECEPTION, //Accesso limitato (visualizza alcune informazioni)
        MANAGER, //Accesso completo (ma non tutto modificabile)
        ADMINISTRATION,//Accesso completo e modificabile
        MASTERUSER//Accesso completo, modificabile e cancellabile
    }
}
