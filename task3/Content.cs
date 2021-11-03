using System;

namespace task3
{
    class Content
    {

        protected string content;

        public Content(string contentBody)
        {
            this.content = contentBody;
        }

        private string Content2
        {
            get
            {
                if (content != "")
                {
                    return content;
                }
                else
                {
                    content = "Контент отсутствует";
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content2);
            Console.ResetColor();
        }
    }
}
