using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiamakWebSite.Classes
{
    public static class Services
    {
        public enum LanguageId
        {
            Fa = 1,
            En = 2
        }
        public static int GetCurrentLangValue(this string lang)
        {
            switch (lang)
            {
                case "fa-IR": return 1;
                case "en-US": return 2;
                default: return 0;
            }
        }
    }
}