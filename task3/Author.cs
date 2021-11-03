using System;

namespace task3
{
    class Author
    {
        protected string content;

        public Author(string MainAuthorName)
        {
            this.content = MainAuthorName;
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
                    content = "Имя автора отсутствует";
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ResetColor();
        }
    }
}

