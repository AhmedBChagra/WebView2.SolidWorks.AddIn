using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WebView2.SolidWorks.AddIn
{
    [ProgId(TaskpaneIntegration.SWTASKPANE_PROGID)]
    public partial class TaskpaneHostUI : UserControl
    {
        public TaskpaneHostUI()
        {
            InitializeComponent();
        }
    }
}
