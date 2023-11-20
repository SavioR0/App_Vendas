using System;
using System.Text;

namespace Vendas.Library
{
    public static class Security
    {
        public static string Encrypt(string chave, string s)
        {
            var sNovaSenha = new StringBuilder
            {
                Capacity = s.Length
            };
            for (int i = 0; i < chave.Length; ++i)
            {
                sNovaSenha.Clear();
                for (int j = 0; j < s.Length; ++j)
                    sNovaSenha.Append(Convert.ToChar((Convert.ToInt32(chave[i])) ^ (Convert.ToInt32(s[j]))));
                s = sNovaSenha.ToString();
            }
            return sNovaSenha.ToString();
        }
        public static string Decrypt(string chave, string s)
        {
            var sNovaSenha = new StringBuilder()
            {
                Capacity = s.Length
            };
            for (int i = 0; i < chave.Length; ++i)
            {
                sNovaSenha.Clear();
                for (int j = 0; j < s.Length; ++j)
                    sNovaSenha.Append(Convert.ToChar((Convert.ToInt32(chave[i])) ^ (Convert.ToInt32(s[j]))));
                s = sNovaSenha.ToString();
            }

            return sNovaSenha.ToString();
        }
    }
}
