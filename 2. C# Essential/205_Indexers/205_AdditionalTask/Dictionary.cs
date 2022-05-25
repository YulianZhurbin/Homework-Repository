using System;

namespace _205_AdditionalTask
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] ukrainian = new string[5];

        public Dictionary()
        {
            key[0] = "книга";  value[0] = "book";  ukrainian[0] = "книга";
            key[1] = "ручка";  value[1] = "pen";   ukrainian[1] = "ручка";
            key[2] = "солнце"; value[2] = "sun";   ukrainian[2] = "сонце";
            key[3] = "яблоко"; value[3] = "apple"; ukrainian[3] = "яблуко";
            key[4] = "стол";   value[4] = "table"; ukrainian[4] = "стола";
        }

        public string this[string index, string fromDictionaryName, string intoDictionaryName]
        {
            get
            {
                if (fromDictionaryName == "ua" && intoDictionaryName == "eng")
                {
                    for (int i = 0; i < ukrainian.Length; i++)
                        if (ukrainian[i] == index)
                            return ukrainian[i] + " - " + value[i];

                    return string.Format("{0} - нет перевода для этого слова.", index);
                }
                
                else if(fromDictionaryName == "ua" && intoDictionaryName == "rus")
                {
                    for (int i = 0; i < ukrainian.Length; i++)
                        if (ukrainian[i] == index)
                            return ukrainian[i] + " - " + key[i];

                    return string.Format("{0} - нет перевода для этого слова.", index);
                }

                else if (fromDictionaryName == "rus" && intoDictionaryName == "eng")
                {
                    for (int i = 0; i < key.Length; i++)
                        if (key[i] == index)
                            return key[i] + " - " + value[i];

                    return string.Format("{0} - нет перевода для этого слова.", index);
                }

                else if (fromDictionaryName == "rus" && intoDictionaryName == "ua")
                {
                    for (int i = 0; i < key.Length; i++)
                        if (key[i] == index)
                            return key[i] + " - " + ukrainian[i];

                    return string.Format("{0} - нет перевода для этого слова.", index);
                }

                else if (fromDictionaryName == "eng" && intoDictionaryName == "ua")
                {
                    for (int i = 0; i < value.Length; i++)
                        if (value[i] == index)
                            return value[i] + " - " + ukrainian[i];

                    return string.Format("{0} - нет перевода для этого слова.", index);
                }

                else if (fromDictionaryName == "eng" && intoDictionaryName == "rus")
                {
                    for (int i = 0; i < value.Length; i++)
                        if (value[i] == index)
                            return value[i] + " - " + key[i];

                    return string.Format("{0} - нет перевода для этого слова.", index);
                }

                else
                {
                    return "Неправильный ввод словарей. Имеются только русский, украинский и английский словари.";
                }
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
