using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace C969.Localization
{
    public static class Messages
    {
        public static string InvalidLogin()
        {
            string lang = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;

            return lang switch
            {
                "es" => "El nombre de usuario y la contraseña no coinciden.",
                "jp" => "ユーザー名とパスワードが一致しません",
                _ => "The username and password do not match."
            };
        }
    }
}
