using System;

namespace make_password
{
    public class Password
    {
        public void PasswordGenerator(int level, int length, bool symbols)
        {
            string EasyLevel = "abcdefghijklmnopqrstuvwxyz";
            string HardLevel = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Symboles = "!@#$%^&*(){}':;";
            string HardPaswd = EasyLevel;
            string SymbolPaswd = EasyLevel;

            if (level == 2)
            {
                HardPaswd += HardLevel;
            }

            if (symbols)
            {
                if (level == 2)
                {
                    SymbolPaswd = EasyLevel + HardLevel + Symboles;
                }
                else if (level == 1)
                {
                    SymbolPaswd = EasyLevel + Symboles;
                }
            }

            Random random = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = SymbolPaswd[random.Next(SymbolPaswd.Length)];
            }

            Console.WriteLine(new string(password));
        }
    }
}
