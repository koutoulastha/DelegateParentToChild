namespace DelegateParentToChild
{
     partial class ParentForm
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
               this.createChildButton = new System.Windows.Forms.Button();
               this.sendEventButton = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // createChildButton
               // 
               this.createChildButton.Location = new System.Drawing.Point(232, 118);
               this.createChildButton.Name = "createChildButton";
               this.createChildButton.Size = new System.Drawing.Size(75, 23);
               this.createChildButton.TabIndex = 0;
               this.createChildButton.Text = "Create child";
               this.createChildButton.UseVisualStyleBackColor = true;
               this.createChildButton.Click += new System.EventHandler(this.createChildButton_Click);
               // 
               // sendEventButton
               // 
               this.sendEventButton.Location = new System.Drawing.Point(379, 118);
               this.sendEventButton.Name = "sendEventButton";
               this.sendEventButton.Size = new System.Drawing.Size(75, 23);
               this.sendEventButton.TabIndex = 1;
               this.sendEventButton.Text = "Send Event";
               this.sendEventButton.UseVisualStyleBackColor = true;
               this.sendEventButton.Click += new System.EventHandler(this.sendEventButton_Click);
               // 
               // ParentForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.sendEventButton);
               this.Controls.Add(this.createChildButton);
               this.Name = "ParentForm";
               this.Text = "Form1";
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button createChildButton;
          private System.Windows.Forms.Button sendEventButton;
     }
}

