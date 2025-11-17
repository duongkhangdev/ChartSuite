namespace ChartPro
{
    partial class MainForm
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer? components = null;

        /// <summary>Clean up any resources being used.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Minimal designer-owned InitializeComponent to keep the Designer happy.
        /// Actual controls are created in BuildUI().
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Name = "MainForm";
            Text = "ChartPro - Trading Chart with ScottPlot 5";
            KeyPreview = true;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}