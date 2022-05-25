using System;

namespace _204_AdditionalTask
{
    abstract class Document
    {
        string content;

        public string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Часть отсутствует.";
            }
            set
            {
                content = value;
            }
        }
        public abstract void Show();
    }
}
