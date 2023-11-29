using System;
namespace ObserverPattern
{
    class program
    {
        static void Main(string[] args)
        {
            ConcreteWebBlog webblog = new ConcreteWebBlog();
            Subscriber subcriber1 = new Subscriber("Gamal");
            Subscriber subcriber2 = new Subscriber("Mohamed");
            webblog.Subscribe(subcriber1);
            webblog.Subscribe(subcriber2);
            Article article1 = new Article("Observer Pattern", "Explore New Patterns");
            Article article2 = new Article("Singleton Pattern", "only one object");
            webblog.PublishArticle(article1);
            webblog.PublishArticle(article2);



        }
    }
}