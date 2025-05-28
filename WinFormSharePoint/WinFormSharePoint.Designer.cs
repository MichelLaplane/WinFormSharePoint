namespace WinFormSharePoint
  {
  partial class WinFormSharePoint
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
      this.btnCSOM = new System.Windows.Forms.Button();
      this.btnMicrosoftGraph = new System.Windows.Forms.Button();
      this.btnQuit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnCSOM
      // 
      this.btnCSOM.Location = new System.Drawing.Point(13, 13);
      this.btnCSOM.Name = "btnCSOM";
      this.btnCSOM.Size = new System.Drawing.Size(126, 23);
      this.btnCSOM.TabIndex = 0;
      this.btnCSOM.Text = "CSOM";
      this.btnCSOM.UseVisualStyleBackColor = true;
      this.btnCSOM.Click += new System.EventHandler(this.btnCSOM_Click);
      // 
      // btnMicrosoftGraph
      // 
      this.btnMicrosoftGraph.Location = new System.Drawing.Point(145, 13);
      this.btnMicrosoftGraph.Name = "btnMicrosoftGraph";
      this.btnMicrosoftGraph.Size = new System.Drawing.Size(126, 23);
      this.btnMicrosoftGraph.TabIndex = 1;
      this.btnMicrosoftGraph.Text = "Microsoft Graph";
      this.btnMicrosoftGraph.UseVisualStyleBackColor = true;
      this.btnMicrosoftGraph.Click += new System.EventHandler(this.btnMicrosoftGraph_Click);
      // 
      // btnQuit
      // 
      this.btnQuit.Location = new System.Drawing.Point(145, 42);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(126, 23);
      this.btnQuit.TabIndex = 2;
      this.btnQuit.Text = "Quit";
      this.btnQuit.UseVisualStyleBackColor = true;
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // WinFormSharePoint
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(285, 77);
      this.Controls.Add(this.btnQuit);
      this.Controls.Add(this.btnMicrosoftGraph);
      this.Controls.Add(this.btnCSOM);
      this.Name = "WinFormSharePoint";
      this.Text = "WinFormSharePoint";
      this.ResumeLayout(false);

      }

    #endregion
    private System.Windows.Forms.Button btnCSOM;
    private System.Windows.Forms.Button btnMicrosoftGraph;
    private System.Windows.Forms.Button btnQuit;
    }
  }

