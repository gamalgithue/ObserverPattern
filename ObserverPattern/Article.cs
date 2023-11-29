using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Article
    {
        public string Title;
        public string Name;
        public Article(string title,string name)
        {
            this.Title = title;
            this.Name=name;
        }
    }
}
