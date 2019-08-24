namespace finalProjectAAAGuide
{
    partial class roadsideAssistanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roadsideAssistanceForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enterpriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nationalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safetyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleExchangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(429, 58);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Welcome to the AAA Roadside Assistance Employee Resources Page";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(782, 19);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterpriseToolStripMenuItem,
            this.nationalToolStripMenuItem,
            this.safetyToolStripMenuItem,
            this.vehicleExchangeToolStripMenuItem,
            this.statsToolStripMenuItem,
            this.generalQuestionsToolStripMenuItem,
            this.memberDataBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enterpriseToolStripMenuItem
            // 
            this.enterpriseToolStripMenuItem.Name = "enterpriseToolStripMenuItem";
            this.enterpriseToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.enterpriseToolStripMenuItem.Text = "Enterprise";
            this.enterpriseToolStripMenuItem.Click += new System.EventHandler(this.enterpriseToolStripMenuItem_Click);
            // 
            // nationalToolStripMenuItem
            // 
            this.nationalToolStripMenuItem.Name = "nationalToolStripMenuItem";
            this.nationalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.nationalToolStripMenuItem.Text = "National";
            this.nationalToolStripMenuItem.Click += new System.EventHandler(this.nationalToolStripMenuItem_Click);
            // 
            // safetyToolStripMenuItem
            // 
            this.safetyToolStripMenuItem.Name = "safetyToolStripMenuItem";
            this.safetyToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.safetyToolStripMenuItem.Text = "Safety";
            this.safetyToolStripMenuItem.Click += new System.EventHandler(this.safetyToolStripMenuItem_Click);
            // 
            // vehicleExchangeToolStripMenuItem
            // 
            this.vehicleExchangeToolStripMenuItem.Name = "vehicleExchangeToolStripMenuItem";
            this.vehicleExchangeToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.vehicleExchangeToolStripMenuItem.Text = "Vehicle_Exchange";
            this.vehicleExchangeToolStripMenuItem.Click += new System.EventHandler(this.vehicleExchangeToolStripMenuItem_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.statsToolStripMenuItem.Text = "Stats";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.statsToolStripMenuItem_Click);
            // 
            // generalQuestionsToolStripMenuItem
            // 
            this.generalQuestionsToolStripMenuItem.Name = "generalQuestionsToolStripMenuItem";
            this.generalQuestionsToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.generalQuestionsToolStripMenuItem.Text = "General_Questions";
            this.generalQuestionsToolStripMenuItem.Click += new System.EventHandler(this.generalQuestionsToolStripMenuItem_Click);
            // 
            // memberDataBaseToolStripMenuItem
            // 
            this.memberDataBaseToolStripMenuItem.Name = "memberDataBaseToolStripMenuItem";
            this.memberDataBaseToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.memberDataBaseToolStripMenuItem.Text = "Member DataBase";
            this.memberDataBaseToolStripMenuItem.Click += new System.EventHandler(this.memberDataBaseToolStripMenuItem_Click);
            // 
            // roadsideAssistanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "roadsideAssistanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AAA Roadside Assistance Call Guide";
            this.Load += new System.EventHandler(this.roadsideAssistanceForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enterpriseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nationalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safetyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleExchangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberDataBaseToolStripMenuItem;
    }
}

