
namespace GothamSubway.WinForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.itmTransferWithMonth = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.itmTransferWithDuration = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.itmRevenue = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.itmSatisfaction = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.itmElectricity = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.mdiMain = new XtraTabbedMdiManagerExtend(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mdiMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 15;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(5);
            this.tileBar.MaxId = 8;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 118);
            this.tileBar.MinimumSize = new System.Drawing.Size(117, 118);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(34, 12, 34, 12);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.itmTransferWithMonth;
            this.tileBar.SelectionBorderWidth = 3;
            this.tileBar.SelectionColor = System.Drawing.Color.DarkRed;
            this.tileBar.ShowGroupText = false;
            this.tileBar.ShowItemShadow = true;
            this.tileBar.Size = new System.Drawing.Size(915, 118);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tileBar.WideTileWidth = 150;
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.itmTransferWithMonth);
            this.tileBarGroupTables.Items.Add(this.itmTransferWithDuration);
            this.tileBarGroupTables.Items.Add(this.itmRevenue);
            this.tileBarGroupTables.Items.Add(this.itmSatisfaction);
            this.tileBarGroupTables.Items.Add(this.itmElectricity);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            // 
            // itmTransferWithMonth
            // 
            this.itmTransferWithMonth.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "itmTransferWithMonth";
            this.itmTransferWithMonth.Elements.Add(tileItemElement1);
            this.itmTransferWithMonth.Id = 1;
            this.itmTransferWithMonth.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.itmTransferWithMonth.Name = "itmTransferWithMonth";
            // 
            // itmTransferWithDuration
            // 
            this.itmTransferWithDuration.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "itmTransferWithDuration";
            this.itmTransferWithDuration.Elements.Add(tileItemElement2);
            this.itmTransferWithDuration.Id = 2;
            this.itmTransferWithDuration.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.itmTransferWithDuration.Name = "itmTransferWithDuration";
            // 
            // xtraTabbedMdiManager1
            // 
            this.mdiMain.MdiParent = this;
            // 
            // itmRevenue
            // 
            this.itmRevenue.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "itmRevenue";
            this.itmRevenue.Elements.Add(tileItemElement3);
            this.itmRevenue.Id = 3;
            this.itmRevenue.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.itmRevenue.Name = "itmRevenue";
            // 
            // itmSatisfaction
            // 
            this.itmSatisfaction.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "itmSatisfaction";
            this.itmSatisfaction.Elements.Add(tileItemElement4);
            this.itmSatisfaction.Id = 4;
            this.itmSatisfaction.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.itmSatisfaction.Name = "itmSatisfaction";
            // 
            // itmElectricity
            // 
            this.itmElectricity.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Text = "itmElectricity";
            this.itmElectricity.Elements.Add(tileItemElement5);
            this.itmElectricity.Id = 5;
            this.itmElectricity.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.itmElectricity.Name = "itmElectricity";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 604);
            this.Controls.Add(this.tileBar);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.mdiMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem itmTransferWithMonth;
        private DevExpress.XtraBars.Navigation.TileBarItem itmTransferWithDuration;
        private DevExpress.XtraBars.Navigation.TileBarItem itmRevenue;
        private DevExpress.XtraBars.Navigation.TileBarItem itmSatisfaction;
        private DevExpress.XtraBars.Navigation.TileBarItem itmElectricity;
        private XtraTabbedMdiManagerExtend mdiMain;
    }
}