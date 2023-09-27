using DevExpress.XtraEditors;
using System;

namespace Vendas.View
{
    public class Validations
    {
        public static bool IsEmptyOrNull(TextEdit field) {
            if (string.IsNullOrWhiteSpace(field.Text)) return true;
            return false;
        }
        internal static string DbFormatCPF(string cpf) {
            return cpf.Replace(".", "").Replace("-", "");
        }
        internal static string DbFormatTel(string tel)
        {
            return tel.Replace("(", "").Replace(")", "").Replace(" ", "");
        }

        private bool IsvalidEmail(string email)
        {
            int atIndex, dotIndex = 0;
            atIndex = email.IndexOf('@');
            dotIndex = email.LastIndexOf('.');

            return atIndex > 0 && dotIndex > atIndex && dotIndex != 0 && dotIndex < email.Length - 1;
        }

        internal static bool ValidateEmail(out string response, string email)
        {
            response = "";
            int atIndex, dotIndex = 0;
            atIndex = email.IndexOf('@');
            dotIndex = email.LastIndexOf('.');
            if (!(atIndex > 0 && dotIndex > atIndex && dotIndex != 0 && dotIndex < email.Length - 1)) {response = "Email preenchido é inválido"; return true; }
            return false;
        }
        internal static bool ValidatePassword(out string response, string pass, string confPass)
        {
            if (pass.Length < 6 ) { response = "A senha está muito curta! Necessário ter pelo menos 6 caracteres"; return true; };
            if (pass != confPass) { response = "As senhas não são compatíveis. Certifique-se de que estejam iguais."; return true; };
            response = "";
            return false;
        }
        public static bool ValidateCPF(string vrCPF)
        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");
            if (valor.Length != 11) return true;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++) { if (valor[i] != valor[0]) igual = false; }

            if (igual || valor == "12345678909") return true;
            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++) numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++) { soma += (10 - i) * numeros[i]; }

            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0) return true;
            }
            else { if (numeros[9] != 11 - resultado) return true; }

            soma = 0;
            for (int i = 0; i < 10; i++) { soma += (11 - i) * numeros[i]; }

            resultado = soma % 11;
            if (resultado == 1 || resultado == 0) { if (numeros[10] != 0) return true; }
            else { if (numeros[10] != 11 - resultado) return true; }
            return false;
        }

        
    }
}
