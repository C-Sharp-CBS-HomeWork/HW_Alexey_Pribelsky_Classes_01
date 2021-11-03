namespace task3
{
    class Book
    {
        protected string MainBookName, MainAuthorName, contentBody;
        Title title = null;
        Author author = null;
        Content content = null;

        void InitializeBook()
        {
            this.title = new Title(MainBookName);
            this.author = new Author(MainAuthorName);
            this.content = new Content(contentBody);

        }
        public Book(string bookName, string authorName, string content)
        {

            this.MainBookName = bookName;
            this.MainAuthorName = authorName;
            this.contentBody = content;
            InitializeBook();
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();

        }


    }
}
