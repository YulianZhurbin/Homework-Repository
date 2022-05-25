using System;

namespace _205_Task4
{
    class Article
    {
        string articleName, storeName;

        public string ArticleName
        {
            get
            {
                return articleName;
            }

            set
            {
                articleName = value;
            }
        }
        
        public string StoreName
        {
            get
            {
                return storeName;
            }

            set
            {
                storeName = value;
            }
        }

        public int ArticleCost { get; set; }

        public string GetArticleInformation()
        {
            return string.Format($"{articleName}\n{storeName}\n{ArticleCost}");
        }
    }
}
