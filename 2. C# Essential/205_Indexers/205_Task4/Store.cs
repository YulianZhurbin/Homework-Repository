using System;


namespace _205_Task4
{
    class Store
    {
        Article[] archive;

        public Article this [int index]
        {
            get
            {
                return archive[index];
            }
        }

        public string this [string index]
        {
            get
            {
                for(int i = 0; i < archive.Length; i++)
                {
                    if (archive[i].ArticleName == index)
                    {
                        return archive[i].GetArticleInformation();
                    }
                }

                return "Nothing's been found.";
            }
        }

        public Store()
        {
            Article iphone = new Article();
            iphone.ArticleName = "iphone";
            iphone.StoreName = "Eldorado";
            iphone.ArticleCost = 20_000;

            Article samsung = new Article();
            samsung.ArticleName = "samsung";
            samsung.StoreName = "Mvideo";
            samsung.ArticleCost = 16_000;

            Article huawei = new Article();
            huawei.ArticleName = "huawei";
            huawei.StoreName = "Eldorado";
            huawei.ArticleCost = 12_000;

            Article lenovo = new Article();
            lenovo.ArticleName = "lenovo";
            lenovo.StoreName = "Euroset";
            lenovo.ArticleCost = 10_000;

            archive = new Article[] {iphone, samsung, huawei, lenovo};
        }

        public void Sort()
        {
            for(int i = 0; i < archive.Length; i++)
            {
                for(int j = 0; j < archive.Length; j++)
                {
                    if(archive[i].ArticleCost < archive[j].ArticleCost)
                    {
                        Article g = archive[i];
                        archive[i] = archive[j];
                        archive[j] = g;
                    }
                }
            }
        }

        public void PrintInfo()
        {
            for(int i = 0; i < archive.Length; i++)
            {
                Console.WriteLine(archive[i].GetArticleInformation());
            }
        }
    }
}
