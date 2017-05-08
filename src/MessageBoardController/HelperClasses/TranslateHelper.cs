using DevExpress.XtraPrinting.HtmlExport.Native;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController.HelperClasses
{
    public static class TranslateHelper
    {
        private static Dictionary<string, string> _languageModeMap;

        #region Translate
        public static string Translate
                        (string sourceText,
                         string sourceLanguage,
                         string targetLanguage)
        {
            // Initialize
            DateTime tmStart = DateTime.Now;
            string translation = string.Empty;

            try
            {
                // Download translation
                string url = string.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                                            TranslateHelper.LanguageEnumToIdentifier(sourceLanguage),
                                            TranslateHelper.LanguageEnumToIdentifier(targetLanguage),
                                            DXHttpUtility.UrlEncode(sourceText));
                string outputFile = Path.GetTempFileName();
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    wc.DownloadFile(url, outputFile);
                }

                // Get translated text
                if (File.Exists(outputFile))
                {

                    // Get phrase collection
                    string text = File.ReadAllText(outputFile);
                    int index = text.IndexOf(string.Format(",,\"{0}\"", TranslateHelper.LanguageEnumToIdentifier(sourceLanguage)));
                    if (index == -1)
                    {
                        // Translation of single word
                        int startQuote = text.IndexOf('\"');
                        if (startQuote != -1)
                        {
                            int endQuote = text.IndexOf('\"', startQuote + 1);
                            if (endQuote != -1)
                            {
                                translation = text.Substring(startQuote + 1, endQuote - startQuote - 1);
                            }
                        }
                    }
                    else
                    {
                        // Translation of phrase
                        text = text.Substring(0, index);
                        text = text.Replace("],[", ",");
                        text = text.Replace("]", string.Empty);
                        text = text.Replace("[", string.Empty);
                        text = text.Replace("\",\"", "\"");

                        // Get translated phrases
                        string[] phrases = text.Split(new[] { '\"' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; (i < phrases.Count()); i += 2)
                        {
                            string translatedPhrase = phrases[i];
                            if (translatedPhrase.StartsWith(",,"))
                            {
                                i--;
                                continue;
                            }
                            translation += translatedPhrase + "  ";
                        }
                    }

                    // Fix up translation
                    translation = translation.Trim();
                    translation = translation.Replace(" ?", "?");
                    translation = translation.Replace(" !", "!");
                    translation = translation.Replace(" ,", ",");
                    translation = translation.Replace(" .", ".");
                    translation = translation.Replace(" ;", ";");

                    // And translation speech URL
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return translation;
        }
        #endregion

        #region LanguageEnumToIdentifier
        private static string LanguageEnumToIdentifier
                (string language)
        {
            string mode = string.Empty;
            TranslateHelper.EnsureInitialized();
            TranslateHelper._languageModeMap.TryGetValue(language, out mode);
            return mode;
        }
        #endregion

        #region EnsureInitialized
        private static void EnsureInitialized()
        {
            if (TranslateHelper._languageModeMap == null)
            {
                TranslateHelper._languageModeMap = new Dictionary<string, string>();
                TranslateHelper._languageModeMap.Add("Afrikaans", "af");
                TranslateHelper._languageModeMap.Add("Albanian", "sq");
                TranslateHelper._languageModeMap.Add("Arabic", "ar");
                TranslateHelper._languageModeMap.Add("Armenian", "hy");
                TranslateHelper._languageModeMap.Add("Azerbaijani", "az");
                TranslateHelper._languageModeMap.Add("Basque", "eu");
                TranslateHelper._languageModeMap.Add("Belarusian", "be");
                TranslateHelper._languageModeMap.Add("Bengali", "bn");
                TranslateHelper._languageModeMap.Add("Bulgarian", "bg");
                TranslateHelper._languageModeMap.Add("Catalan", "ca");
                TranslateHelper._languageModeMap.Add("Chinese", "zh-CN");
                TranslateHelper._languageModeMap.Add("Croatian", "hr");
                TranslateHelper._languageModeMap.Add("Czech", "cs");
                TranslateHelper._languageModeMap.Add("Danish", "da");
                TranslateHelper._languageModeMap.Add("Dutch", "nl");
                TranslateHelper._languageModeMap.Add("English", "en");
                TranslateHelper._languageModeMap.Add("Esperanto", "eo");
                TranslateHelper._languageModeMap.Add("Estonian", "et");
                TranslateHelper._languageModeMap.Add("Filipino", "tl");
                TranslateHelper._languageModeMap.Add("Finnish", "fi");
                TranslateHelper._languageModeMap.Add("French", "fr");
                TranslateHelper._languageModeMap.Add("Galician", "gl");
                TranslateHelper._languageModeMap.Add("German", "de");
                TranslateHelper._languageModeMap.Add("Georgian", "ka");
                TranslateHelper._languageModeMap.Add("Greek", "el");
                TranslateHelper._languageModeMap.Add("Haitian Creole", "ht");
                TranslateHelper._languageModeMap.Add("Hebrew", "iw");
                TranslateHelper._languageModeMap.Add("Hindi", "hi");
                TranslateHelper._languageModeMap.Add("Hungarian", "hu");
                TranslateHelper._languageModeMap.Add("Icelandic", "is");
                TranslateHelper._languageModeMap.Add("Indonesian", "id");
                TranslateHelper._languageModeMap.Add("Irish", "ga");
                TranslateHelper._languageModeMap.Add("Italian", "it");
                TranslateHelper._languageModeMap.Add("Japanese", "ja");
                TranslateHelper._languageModeMap.Add("Korean", "ko");
                TranslateHelper._languageModeMap.Add("Lao", "lo");
                TranslateHelper._languageModeMap.Add("Latin", "la");
                TranslateHelper._languageModeMap.Add("Latvian", "lv");
                TranslateHelper._languageModeMap.Add("Lithuanian", "lt");
                TranslateHelper._languageModeMap.Add("Macedonian", "mk");
                TranslateHelper._languageModeMap.Add("Malay", "ms");
                TranslateHelper._languageModeMap.Add("Maltese", "mt");
                TranslateHelper._languageModeMap.Add("Norwegian", "no");
                TranslateHelper._languageModeMap.Add("Persian", "fa");
                TranslateHelper._languageModeMap.Add("Polish", "pl");
                TranslateHelper._languageModeMap.Add("Portuguese", "pt");
                TranslateHelper._languageModeMap.Add("Romanian", "ro");
                TranslateHelper._languageModeMap.Add("Russian", "ru");
                TranslateHelper._languageModeMap.Add("Serbian", "sr");
                TranslateHelper._languageModeMap.Add("Slovak", "sk");
                TranslateHelper._languageModeMap.Add("Slovenian", "sl");
                TranslateHelper._languageModeMap.Add("Spanish", "es");
                TranslateHelper._languageModeMap.Add("Swahili", "sw");
                TranslateHelper._languageModeMap.Add("Swedish", "sv");
                TranslateHelper._languageModeMap.Add("Tamil", "ta");
                TranslateHelper._languageModeMap.Add("Telugu", "te");
                TranslateHelper._languageModeMap.Add("Thai", "th");
                TranslateHelper._languageModeMap.Add("Turkish", "tr");
                TranslateHelper._languageModeMap.Add("Ukrainian", "uk");
                TranslateHelper._languageModeMap.Add("Urdu", "ur");
                TranslateHelper._languageModeMap.Add("Vietnamese", "vi");
                TranslateHelper._languageModeMap.Add("Welsh", "cy");
                TranslateHelper._languageModeMap.Add("Yiddish", "yi");
            }
        }
        #endregion

    }
}
