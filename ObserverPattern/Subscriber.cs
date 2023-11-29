using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Subscriber : IObserver
    {
        private string name;
        public Subscriber(string name)
        {
            this.name = name;
        }
        public void Update(Article article)
        {
            Console.WriteLine($"User: {name} received new notification : New article - {article.Title}");

        }
    }
}
