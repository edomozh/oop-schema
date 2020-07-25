using System.Linq;
using System.Windows.Forms;

namespace OOP
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            this.Schema.MouseClick += AddDetail;
        }

        private void AddDetail(object sender, MouseEventArgs e)
        {
            var d = new Detail(e.Location);
            var rb = from Control con in Panel.Controls
                     where (con is RadioButton && ((RadioButton)con).Checked)
                     select con;
            if (rb.Count() > 0) d.Text = rb.First().Text;
            Schema.AddDetail(d);
        }
    }
}
