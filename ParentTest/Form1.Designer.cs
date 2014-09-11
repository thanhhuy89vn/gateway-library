namespace ParentTest
{
    partial class Form1
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
            this.gatewayControl1 = new GatewayLibrary.GatewayControl("123456");
            this.SuspendLayout();
            // 
            // gatewayControl1
            // 
            this.gatewayControl1.Location = new System.Drawing.Point(0, 0);
            this.gatewayControl1.Name = "gatewayControl1";
            this.gatewayControl1.Size = new System.Drawing.Size(800, 600);
            this.gatewayControl1.TabIndex = 0;
            this.gatewayControl1.Load += new System.EventHandler(this.gatewayControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gatewayControl1);
            this.Name = "Form1";
            this.Text = "Testing app";
            this.ResumeLayout(false);

        }

        #endregion

        private GatewayLibrary.GatewayControl userControl11;
        private GatewayLibrary.GatewayControl gatewayControl1;
    }
}

