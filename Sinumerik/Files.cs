using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Kbg.NppPluginNET.PluginInfrastructure;

namespace NppDemo.Sinumerik
{
    internal class Files
    {
        private String getLanguage()
        {
            String result = "";
            StringBuilder sbIniFilePath = new StringBuilder(Win32.MAX_PATH);
            Win32.SendMessage(PluginBase.nppData._nppHandle,
                                                  (uint)NppMsg.NPPM_GETPLUGINSCONFIGDIR,
                                                  Win32.MAX_PATH, sbIniFilePath);
            String iniFilePath = sbIniFilePath.ToString();
            if (iniFilePath.EndsWith(@"plugins\Config"))
            {
                iniFilePath = iniFilePath.Replace(@"\plugins\Config", @"\nativeLang.xml");
                String readline = null;
                Int16 counter = 0;
                //    <Native-Langue name="English" filename="english.xml" version="6.8.2">
                using (System.IO.StreamReader fileReader = System.IO.File.OpenText(iniFilePath))
                {
                    while (counter < 30) // check counterMax
                    {
                        readline = fileReader.ReadLine();
                        counter++;
                        if (readline.ToLowerInvariant().Contains("<native-langue"))
                        {
                            string[] split = Regex.Split(readline,
                                 "^(.*)(<Native-Langue)(\\s+)(name=\")(((?!\").)*)(\")(.*)$");
                            if ((split != null) && (split.Length > 4))
                                readline = split[5];
                            else
                                readline = null;
                            counter = 31; // Set counter to => max
                        }
                        else
                            readline = null;
                    }
                    fileReader.Close();
                }
                if (readline != null)
                {
                    switch (readline.ToLowerInvariant())
                    {
                        case "deutsch":
                            result = "DE";
                            break;
                        case "english":
                            result = "EN";
                            break;
                        default:
                            result = "EN";
                            break;
                    }
                }
            }
            return result;
        }


    }
}
