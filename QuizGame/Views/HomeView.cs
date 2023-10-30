using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame.Views
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void AddNewQuestionsButton_Click(object sender, EventArgs e)
        {
            var addNewQuestionsView = new AddNewQuestionsView();
            addNewQuestionsView.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(addNewQuestionsView);
        }
    }
}
