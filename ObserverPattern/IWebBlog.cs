using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal interface IWebBlog
    {
        void Subscribe(IObserver obsever);
        void UnSubscribe(IObserver obsever);
        void Notify(Article article);
        void PublishArticle(Article article);

    }
}
