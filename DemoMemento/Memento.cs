using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMemento
{
    public class Memento
    {
        private String article;

        public Memento(string article)
        {
            this.article = article;
        }

        public string getArticle()
        {
            return article;
        }
    }
}
