using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class ConcreteWebBlog : IWebBlog

    {

        private List<IObserver> observer1 = new List<IObserver>();
        public void Subscribe(IObserver obsever)
        {
            observer1.Add(obsever);
        }

        public void UnSubscribe(IObserver obsever)
        {
            observer1.Remove(obsever);

        }
        public void Notify(Article article)
        {

            foreach(var subscribe in observer1)
            {
                subscribe.Update(article);
            }

        }

        public void PublishArticle(Article article)
        {
            Console.WriteLine($"New Article Published is : {article.Title}");
            Notify(article);
            Console.WriteLine("=====================");
        }
    }
}
