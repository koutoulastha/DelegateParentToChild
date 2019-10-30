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
     public partial class ParentForm : Form
     {
          // Our delegate (which "points" at any method which takes an object and EventArgs)7
        // Look familiar? This is the signature of most control events on a form
        public delegate void SendMessage(string message);
 
        // Here is the event we trigger to send messages out to listeners
        public event SendMessage OnSendMessage;


          public ParentForm()
          {
               InitializeComponent();
          }

          private void createChildButton_Click(object sender, EventArgs e)
          {
               ChildForm childForm = new ChildForm();
               OnSendMessage += childForm.MessageReceived;
               childForm.Show();
          }

          // When we click the message button, tell others to respond to our button being clicked
          private void sendEventButton_Click(object sender, EventArgs e)
          {
               OnSendMessage?.Invoke("Some text");
          }
     }
}
