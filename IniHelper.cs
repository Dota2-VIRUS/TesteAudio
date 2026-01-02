using System.IO;

namespace GravadorAudioSaidaWin
{
    public static class IniHelper
    {
        // Caminho do arquivo ini
        public static string ArquivoIni = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "config.ini");

        public static void Salvar(string chave, string valor)
        {
            string[] linhas = File.Exists(ArquivoIni) ? File.ReadAllLines(ArquivoIni) : new string[0];
            bool achou = false;
            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].StartsWith(chave + "="))
                {
                    linhas[i] = chave + "=" + valor;
                    achou = true;
                    break;
                }
            }

            if (!achou)
            {
                using (StreamWriter sw = File.AppendText(ArquivoIni))
                {
                    sw.WriteLine(chave + "=" + valor);
                    return;
                }
            }

            File.WriteAllLines(ArquivoIni, linhas);
        }

        public static string Ler(string chave, string valorPadrao = "")
        {
            if (!File.Exists(ArquivoIni))
                return valorPadrao;

            foreach (var linha in File.ReadAllLines(ArquivoIni))
            {
                if (linha.StartsWith(chave + "="))
                {
                    return linha.Substring(chave.Length + 1);
                }
            }
            return valorPadrao;
        }
        
    }
}
