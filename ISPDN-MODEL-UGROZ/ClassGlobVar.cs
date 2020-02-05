using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaseFormISPDn
{
    public class ClassGlobalVar
    {
            public static string INN; // переменная в которой будет хранится почти всегда ИНН текушей организации
            public static int OrgID; // переменная в которой будет хранится почти всегда ID текушей организации
            public static int ISPDnID; // глобальная переменная Айдишника текущей ИС
            public static int OtdelID; // глобальная переменная Айдишника текущего отдела
            public static string KomisKlassIS; // глобальная переменная хранения членов комиссии по классификации ИСПДн
            public static string Punkt222; // пункты письма по статье 22 ч 2... по которым не требуется уведомление
    }
}
