using System;
using System.Windows.Forms;

namespace DemoMemento
{
    public partial class FormDemo : Form
    {
        private Caretaker caretaker = new Caretaker();
        private Originator originator = new Originator();
        private int saveArticles = 0;
        private int currentArticle = 0;
        public FormDemo()
        {
            InitializeComponent();
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;

        }
        // xử lý khi nhấn save
        private void btnSave_Click(object sender, EventArgs e)
        {
            var text = txtTextArea.Text;
            originator.setArticle(text);
            caretaker.add(originator.saveToMemento());
            saveArticles += 1;
            currentArticle += 1;
            btnUndo.Enabled = true;
        }
        // xử lý khi nhấn undo
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if(currentArticle >= 1)
            {
                currentArticle -= 1;
                var previousText = originator.restoreFromMemento(caretaker.get(currentArticle));
                txtTextArea.Text = previousText;
                btnRedo.Enabled = true;
            }
            else
            {
                btnUndo.Enabled = false;
            }
        }

        //Xử lý khi nhấn redo
        private void btnRedo_Click(object sender, EventArgs e)
        {
            if ((saveArticles - 1) > currentArticle)
            {
                currentArticle += 1;
                var nextText = originator.restoreFromMemento(caretaker.get(currentArticle));
                txtTextArea.Text = nextText;
                btnUndo.Enabled = true;
            }
            else
            {
                btnRedo.Enabled = false;
            }
        }
    }
}
