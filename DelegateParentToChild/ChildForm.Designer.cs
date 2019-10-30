namespace DelegateParentToChild
{
     partial class ChildForm
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.eventTextBox = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // eventTextBox
               // 
               this.eventTextBox.Location = new System.Drawing.Point(286, 72);
               this.eventTextBox.Name = "eventTextBox";
               this.eventTextBox.Size = new System.Drawing.Size(100, 20);
               this.eventTextBox.TabIndex = 0;
               // 
               // ChildForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.eventTextBox);
               this.Name = "ChildForm";
               this.Text = "ChildForm";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox eventTextBox;
     }
}