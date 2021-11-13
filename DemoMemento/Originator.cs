using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMemento
{
    public class Originator
    {
        private string article;

        public void setArticle(string article)
        {
            this.article = article;
        }

        // store to Memento
        public Memento saveToMemento()
        {
            return new Memento(article);
        }

        // restore from Memento 
        public string restoreFromMemento(Memento memento)
        {
            article = memento.getArticle();
            return article;
        }
    }
}
