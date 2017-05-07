using DevExpress.XtraPrinting.HtmlExport.Native;
using MessageBoardController.Interfaces;
using MessageBoardController.MessageBoardService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController
{
    public class BaseFormController
    {
        private IMessageBoardService _service;
        private IBaseForm _form;
        private static Dictionary<string, string> _languageModeMap;
        private Dictionary<string, string> _getControls = new Dictionary<string, string>();
        private Dictionary<string, string> _translatedControls = new Dictionary<string, string>();

        public BaseFormController(IBaseForm form)
        {
            _service = new MessageBoardServiceClient();
            _form = form;
            AppGlobalVariables.AppGlobalVariables.Instance.CurrentLanguage = "English";
            AppGlobalVariables.AppGlobalVariables.Instance.NextLanguage = "French";
        }

        #region Translate
        public string Translate
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
                                            BaseFormController.LanguageEnumToIdentifier(sourceLanguage),
                                            BaseFormController.LanguageEnumToIdentifier(targetLanguage),
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
                    int index = text.IndexOf(string.Format(",,\"{0}\"", BaseFormController.LanguageEnumToIdentifier(sourceLanguage)));
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
            BaseFormController.EnsureInitialized();
            BaseFormController._languageModeMap.TryGetValue(language, out mode);
            return mode;
        }
        #endregion

        #region EnsureInitialized
        private static void EnsureInitialized()
        {
            if (BaseFormController._languageModeMap == null)
            {
                BaseFormController._languageModeMap = new Dictionary<string, string>();
                BaseFormController._languageModeMap.Add("Afrikaans", "af");
                BaseFormController._languageModeMap.Add("Albanian", "sq");
                BaseFormController._languageModeMap.Add("Arabic", "ar");
                BaseFormController._languageModeMap.Add("Armenian", "hy");
                BaseFormController._languageModeMap.Add("Azerbaijani", "az");
                BaseFormController._languageModeMap.Add("Basque", "eu");
                BaseFormController._languageModeMap.Add("Belarusian", "be");
                BaseFormController._languageModeMap.Add("Bengali", "bn");
                BaseFormController._languageModeMap.Add("Bulgarian", "bg");
                BaseFormController._languageModeMap.Add("Catalan", "ca");
                BaseFormController._languageModeMap.Add("Chinese", "zh-CN");
                BaseFormController._languageModeMap.Add("Croatian", "hr");
                BaseFormController._languageModeMap.Add("Czech", "cs");
                BaseFormController._languageModeMap.Add("Danish", "da");
                BaseFormController._languageModeMap.Add("Dutch", "nl");
                BaseFormController._languageModeMap.Add("English", "en");
                BaseFormController._languageModeMap.Add("Esperanto", "eo");
                BaseFormController._languageModeMap.Add("Estonian", "et");
                BaseFormController._languageModeMap.Add("Filipino", "tl");
                BaseFormController._languageModeMap.Add("Finnish", "fi");
                BaseFormController._languageModeMap.Add("French", "fr");
                BaseFormController._languageModeMap.Add("Galician", "gl");
                BaseFormController._languageModeMap.Add("German", "de");
                BaseFormController._languageModeMap.Add("Georgian", "ka");
                BaseFormController._languageModeMap.Add("Greek", "el");
                BaseFormController._languageModeMap.Add("Haitian Creole", "ht");
                BaseFormController._languageModeMap.Add("Hebrew", "iw");
                BaseFormController._languageModeMap.Add("Hindi", "hi");
                BaseFormController._languageModeMap.Add("Hungarian", "hu");
                BaseFormController._languageModeMap.Add("Icelandic", "is");
                BaseFormController._languageModeMap.Add("Indonesian", "id");
                BaseFormController._languageModeMap.Add("Irish", "ga");
                BaseFormController._languageModeMap.Add("Italian", "it");
                BaseFormController._languageModeMap.Add("Japanese", "ja");
                BaseFormController._languageModeMap.Add("Korean", "ko");
                BaseFormController._languageModeMap.Add("Lao", "lo");
                BaseFormController._languageModeMap.Add("Latin", "la");
                BaseFormController._languageModeMap.Add("Latvian", "lv");
                BaseFormController._languageModeMap.Add("Lithuanian", "lt");
                BaseFormController._languageModeMap.Add("Macedonian", "mk");
                BaseFormController._languageModeMap.Add("Malay", "ms");
                BaseFormController._languageModeMap.Add("Maltese", "mt");
                BaseFormController._languageModeMap.Add("Norwegian", "no");
                BaseFormController._languageModeMap.Add("Persian", "fa");
                BaseFormController._languageModeMap.Add("Polish", "pl");
                BaseFormController._languageModeMap.Add("Portuguese", "pt");
                BaseFormController._languageModeMap.Add("Romanian", "ro");
                BaseFormController._languageModeMap.Add("Russian", "ru");
                BaseFormController._languageModeMap.Add("Serbian", "sr");
                BaseFormController._languageModeMap.Add("Slovak", "sk");
                BaseFormController._languageModeMap.Add("Slovenian", "sl");
                BaseFormController._languageModeMap.Add("Spanish", "es");
                BaseFormController._languageModeMap.Add("Swahili", "sw");
                BaseFormController._languageModeMap.Add("Swedish", "sv");
                BaseFormController._languageModeMap.Add("Tamil", "ta");
                BaseFormController._languageModeMap.Add("Telugu", "te");
                BaseFormController._languageModeMap.Add("Thai", "th");
                BaseFormController._languageModeMap.Add("Turkish", "tr");
                BaseFormController._languageModeMap.Add("Ukrainian", "uk");
                BaseFormController._languageModeMap.Add("Urdu", "ur");
                BaseFormController._languageModeMap.Add("Vietnamese", "vi");
                BaseFormController._languageModeMap.Add("Welsh", "cy");
                BaseFormController._languageModeMap.Add("Yiddish", "yi");
            }
        }
        #endregion

        #region GetControls
        public void GetControls()
        {
            _getControls = _form.AddAllControls();
            TranslateControls();
        }
        #endregion

        #region TranslateControls()
        public void TranslateControls()
        {
            foreach (KeyValuePair<string, string> control in _getControls)
            {
                string translate = Translate(control.Value, "English", "French");
                _translatedControls.Add(control.Key, translate);
            }
            InsertTranslations();
        }
        #endregion

        public void InsertTranslations()
        {
            if(_translatedControls != null && _translatedControls.Count > 0)
            {
                _service.InsertTranslations(_translatedControls, AppGlobalVariables.AppGlobalVariables.Instance.NextLanguage);
            }
        }
    }
}
