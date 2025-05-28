using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSharePoint
  {
  public partial class WinFormSharePoint : Form
    {
    FormCSOM frmFormCSOM;
    FormMicrosoftGraph frmFormMicrosoftGraph;

    public WinFormSharePoint()
      {
      InitializeComponent();
      }

    private void btnQuit_Click(object sender, EventArgs e)
      {
      Application.Exit();
      }

    private void btnCSOM_Click(object sender, EventArgs e)
      {
      frmFormCSOM = new FormCSOM();
      frmFormCSOM.ShowDialog();
      }

    private void btnMicrosoftGraph_Click(object sender, EventArgs e)
      {
      frmFormMicrosoftGraph = new FormMicrosoftGraph();
      frmFormMicrosoftGraph.ShowDialog();
      }
    }
  }
