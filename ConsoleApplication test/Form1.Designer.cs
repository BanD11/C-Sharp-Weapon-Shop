namespace Intro
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
            this.buyButton = new System.Windows.Forms.Button();
            this.pistolsDataGridView = new System.Windows.Forms.DataGridView();
            this.loginButton = new System.Windows.Forms.Button();
            this.buingInfoLabel = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.smgsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.shotgunsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ownedDataGridView = new System.Windows.Forms.DataGridView();
            this.cancelBuyButton = new System.Windows.Forms.Button();
            this.confirmBuyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pistolsDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smgsDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shotgunsDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buyButton
            // 
            this.buyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyButton.Location = new System.Drawing.Point(648, 14);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(153, 36);
            this.buyButton.TabIndex = 1;
            this.buyButton.Text = "Buy selected item";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Visible = false;
            this.buyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pistolsDataGridView
            // 
            this.pistolsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.pistolsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.pistolsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pistolsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pistolsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.pistolsDataGridView.Margin = new System.Windows.Forms.Padding(100);
            this.pistolsDataGridView.MultiSelect = false;
            this.pistolsDataGridView.Name = "pistolsDataGridView";
            this.pistolsDataGridView.ReadOnly = true;
            this.pistolsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pistolsDataGridView.Size = new System.Drawing.Size(935, 504);
            this.pistolsDataGridView.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(834, 14);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(101, 36);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // buingInfoLabel
            // 
            this.buingInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buingInfoLabel.AutoSize = true;
            this.buingInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buingInfoLabel.Location = new System.Drawing.Point(369, 17);
            this.buingInfoLabel.Name = "buingInfoLabel";
            this.buingInfoLabel.Size = new System.Drawing.Size(211, 17);
            this.buingInfoLabel.TabIndex = 4;
            this.buingInfoLabel.Text = "This will cost you ???. Proceed?";
            this.buingInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buingInfoLabel.Visible = false;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserLabel.Location = new System.Drawing.Point(14, 14);
            this.currentUserLabel.Margin = new System.Windows.Forms.Padding(5);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(150, 20);
            this.currentUserLabel.TabIndex = 5;
            this.currentUserLabel.Text = "You\'re not logged in";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 507);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pistolsDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pistols";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.smgsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SMGs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // smgsDataGridView
            // 
            this.smgsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.smgsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.smgsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.smgsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smgsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.smgsDataGridView.Margin = new System.Windows.Forms.Padding(100);
            this.smgsDataGridView.MultiSelect = false;
            this.smgsDataGridView.Name = "smgsDataGridView";
            this.smgsDataGridView.ReadOnly = true;
            this.smgsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.smgsDataGridView.Size = new System.Drawing.Size(935, 463);
            this.smgsDataGridView.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.shotgunsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(941, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Shotguns";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // shotgunsDataGridView
            // 
            this.shotgunsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.shotgunsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.shotgunsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shotgunsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shotgunsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.shotgunsDataGridView.Margin = new System.Windows.Forms.Padding(100);
            this.shotgunsDataGridView.Name = "shotgunsDataGridView";
            this.shotgunsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.shotgunsDataGridView.Size = new System.Drawing.Size(935, 504);
            this.shotgunsDataGridView.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ownedDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(941, 510);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Owned";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ownedDataGridView
            // 
            this.ownedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ownedDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ownedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ownedDataGridView.Margin = new System.Windows.Forms.Padding(100);
            this.ownedDataGridView.Name = "ownedDataGridView";
            this.ownedDataGridView.ReadOnly = true;
            this.ownedDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ownedDataGridView.Size = new System.Drawing.Size(935, 504);
            this.ownedDataGridView.TabIndex = 3;
            // 
            // cancelBuyButton
            // 
            this.cancelBuyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBuyButton.Location = new System.Drawing.Point(384, 43);
            this.cancelBuyButton.Name = "cancelBuyButton";
            this.cancelBuyButton.Size = new System.Drawing.Size(57, 29);
            this.cancelBuyButton.TabIndex = 8;
            this.cancelBuyButton.Text = "No";
            this.cancelBuyButton.UseVisualStyleBackColor = true;
            this.cancelBuyButton.Visible = false;
            this.cancelBuyButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // confirmBuyButton
            // 
            this.confirmBuyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmBuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmBuyButton.Location = new System.Drawing.Point(507, 43);
            this.confirmBuyButton.Name = "confirmBuyButton";
            this.confirmBuyButton.Size = new System.Drawing.Size(57, 29);
            this.confirmBuyButton.TabIndex = 9;
            this.confirmBuyButton.Text = "Yes";
            this.confirmBuyButton.UseVisualStyleBackColor = true;
            this.confirmBuyButton.Visible = false;
            this.confirmBuyButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(949, 585);
            this.Controls.Add(this.confirmBuyButton);
            this.Controls.Add(this.cancelBuyButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.buingInfoLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.buyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Weapon Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pistolsDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smgsDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shotgunsDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ownedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.DataGridView pistolsDataGridView;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label buingInfoLabel;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView smgsDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView shotgunsDataGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView ownedDataGridView;
        private System.Windows.Forms.Button cancelBuyButton;
        private System.Windows.Forms.Button confirmBuyButton;
    }
}