﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateBackend
{

    public class NameParser
    {
        public readonly Dictionary<string, string> languageDictionary = new Dictionary<string, string>()
        {
            { "Afrikaans", "af"},
            { "Albanian", "sq"},
            { "Amharic", "am"},
            { "Arabic", "ar"},
            { "Armenian", "hy"},
            { "Assamese", "as"},
            { "Aymara", "ay"},
            { "Azerbaijani", "az"},
            { "Bambara", "bm"},
            { "Basque", "eu"},
            { "Belarusian", "be"},
            { "Bengali", "bn"},
            { "Bhojpuri", "bho"},
            { "Bosnian", "bs"},
            { "Bulgarian", "bg"},
            { "Catalan", "ca"},
            { "Cebuano", "ceb"},
            { "Chinese (Simplified)", "zh"},
            { "Chinese (Traditional)", "zh-TW"},
            { "Corsican", "co"},
            { "Croatian", "hr"},
            { "Czech", "cs"},
            { "Danish", "da"},
            { "Dhivehi", "dv"},
            { "Dogri", "doi"},
            { "Dutch", "nl"},
            { "English", "en"},
            { "Esperanto", "eo"},
            { "Estonian", "et"},
            { "Ewe", "ee"},
            { "Filipino (Tagalog)", "fil"},
            { "Finnish", "fi"},
            { "French", "fr"},
            { "Frisian", "fy"},
            { "Galician", "gl"},
            { "Georgian", "ka"},
            { "German", "de"},
            { "Greek", "el"},
            { "Guarani", "gn"},
            { "Gujarati", "gu"},
            { "Haitian Creole", "ht"},
            { "Hausa", "ha"},
            { "Hawaiian", "haw"},
            { "Hebrew", "he"},
            { "Hindi", "hi"},
            { "Hmong", "hmn"},
            { "Hungarian", "hu"},
            { "Icelandic", "is"},
            { "Igbo", "ig"},
            { "Ilocano", "ilo"},
            { "Indonesian", "id"},
            { "Irish", "ga"},
            { "Italian", "it"},
            { "Japanese", "ja"},
            { "Javanese", "jw"},
            { "Kannada", "kn"},
            { "Kazakh", "kk"},
            { "Khmer", "km"},
            { "Kinyarwanda", "rw"},
            { "Konkani", "gom"},
            { "Korean", "ko"},
            { "Krio", "kri"},
            { "Kurdish", "ku"},
            { "Kurdish (Sorani)", "ckb"},
            { "Kyrgyz", "ky"},
            { "Lao", "lo"},
            { "Latin", "la"},
            { "Latvian", "lv"},
            { "Lingala", "ln"},
            { "Lithuanian", "lt"},
            { "Luganda", "lg"},
            { "Luxembourgish", "lb"},
            { "Macedonian", "mk"},
            { "Maithili", "mai"},
            { "Malagasy", "mg"},
            { "Malay", "ms"},
            { "Malayalam", "ml"},
            { "Maltese", "mt"},
            { "Maori", "mi"},
            { "Marathi", "mr"},
            { "Meiteilon", "mni-Mtei"},
            { "Mizo", "lus"},
            { "Mongolian", "mn"},
            { "Myanmar", "my"},
            { "Nepali", "ne"},
            { "Norwegian", "no"},
            { "Nyanja", "ny"},
            { "Odia", "or"},
            { "Oromo", "om"},
            { "Pashto", "ps"},
            { "Persian", "fa"},
            { "Polish", "pl"},
            { "Portuguese", "pt"},
            { "Punjabi", "pa"},
            { "Quechua", "qu"},
            { "Romanian", "ro"},
            { "Russian", "ru"},
            { "Samoan", "sm"},
            { "Sanskrit", "sa"},
            { "Scots Gaelic", "gd"},
            { "Sepedi", "nso"},
            { "Serbian", "sr"},
            { "Sesotho", "st"},
            { "Shona", "sn"},
            { "Sindhi", "sd"},
            { "Sinhala (Sinhalese)", "si"},
            { "Slovak", "sk"},
            { "Slovenian", "sl"},
            { "Somali", "so"},
            { "Spanish", "es"},
            { "Sundanese", "su"},
            { "Swahili", "sw"},
            { "Swedish", "sv"},
            { "Tagalog (Filipino)", "tl"},
            { "Tajik", "tg"},
            { "Tamil", "ta"},
            { "Tatar", "tt"},
            { "Telugu", "te"},
            { "Thai", "th"},
            { "Tigrinya", "ti"},
            { "Tsonga", "ts"},
            { "Turkish", "tr"},
            { "Turkmen", "tk"},
            { "Twi (Akan)", "ak"},
            { "Ukrainian", "uk"},
            { "Urdu", "ur"},
            { "Uyghur", "ug"},
            { "Uzbek", "uz"},
            { "Vietnamese", "vi"},
            { "Welsh", "cy"},
            { "Xhosa", "xh"},
            { "Yiddish", "yi"},
            { "Yoruba", "yo"},
            { "Zulu", "zu"},
        };
        public string GetCode(string name)
        {
            name = name.ToLower();
            name = name[0].ToString().ToUpper() + name.Substring(1);
            string languageName = name;
            foreach (KeyValuePair<string, string> pair in languageDictionary)
            {
                if (pair.Value == languageName)
                {
                    string languageCode = pair.Key;
                    return languageCode;
                }
            }
            // If no matching language code was found, return null or throw an exception
            return null;
        }
        public string GetName(string code)
        {
            code = code.ToLower();
            return languageDictionary[code];
        }
    }

}
