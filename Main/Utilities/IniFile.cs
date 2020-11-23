using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Main.Utilities
{
    /// <summary>
    /// Classe utilizzata per creare, editare e cancellare file INI
    /// </summary>
    public class IniFile   
    {
        private string Path;
        private string EXE = Assembly.GetExecutingAssembly().GetName().Name; //prendo il nome dell'eseguibile

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        /// <summary>
        /// Costruttore della classe IniFile utilizzata per leggere e creare file INI
        /// </summary>
        /// <param name="IniPath">Percorso del file INI</param>
        public IniFile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
        }

        /// <summary>
        /// Legge Chaive ed eventuale Sezione del file INI impostato 
        /// </summary>
        /// <param name="Key">Chiave</param>
        /// <param name="Section">Sezione</param>
        /// <returns></returns>
        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        /// <summary>
        /// Scrive valore data Chiave ed eventuale Sezione
        /// </summary>
        /// <param name="Key">Chiave</param>
        /// <param name="Value">Valore</param>
        /// <param name="Section">Sezione</param>
        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        /// <summary>
        /// Cancella la singola Chiave del file impostato
        /// </summary>
        /// <param name="Key">Chiave</param>
        /// <param name="Section">Sezione</param>
        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        /// <summary>
        /// Cancella la sezione del file impostato
        /// </summary>
        /// <param name="Section">Sezione</param>
        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        /// <summary>
        /// Controlla se la Chiave esiste per un eventuale Sezione
        /// </summary>
        /// <param name="Key">Chiave</param>
        /// <param name="Section">Sezione</param>
        /// <returns>Vero o Falso</returns>
        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
