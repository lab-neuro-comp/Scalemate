using ScalemateForms.Model;
using System.Linq;
using System.Windows.Forms;

namespace ScalemateForms.View
{
    public partial class FormDocs : Form
    {
        public FormDocs()
        {
            InitializeComponent();
            DataAccessLayer DAL = new DataAccessLayer();
            docsBrowser.DocumentText = DAL.Load(DAL.GetDocsPath())
                                          .Aggregate("", (box, it) => $"{box}\n{it}");
        }

        public Form Mother { get; private set; }
    }
}
