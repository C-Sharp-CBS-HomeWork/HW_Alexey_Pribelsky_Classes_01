using System;

namespace task3
{
    class Title
    {

        protected string content;

        public Title(string MainBookName)
        {
            this.content = MainBookName;
        }
        private string Content
        {
            get
            {
                if (content != "")
                {
                    return content;
                }
                else
                {
                    content = "Заголовок отсутствует";
                    return content;
                }
            }
            set
            {
                content = value;
            }
        }



        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ResetColor();
        }
    }
}

