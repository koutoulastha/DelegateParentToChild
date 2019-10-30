using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateParentToChild
{
     public partial class ChildForm : Form
     {
          public ChildForm()
          {
               InitializeComponent();
          }

          public void MessageReceived(string text)
          {
               eventTextBox.Text = text;
          }

     }
}
