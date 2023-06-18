using System.Windows.Forms;

namespace ODP2
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.WorkOrderManagementTab = new System.Windows.Forms.ToolStripDropDownButton();
            this.activeWorkOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closedWorkOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.createWorkOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.SparePartsTab = new System.Windows.Forms.ToolStripDropDownButton();
            this.inventorySpareParts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.maintenanceMaterialInquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentsStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.breakDowns = new System.Windows.Forms.ToolStripMenuItem();
            this.pmGeneration = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolBarLabel = new System.Windows.Forms.ToolStripLabel();
            this.homeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.StoresTab = new System.Windows.Forms.ToolStripDropDownButton();
            this.issuePartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.financeTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.fuelStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.AssetsManagementTab = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.pMAttachmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.equipmentRunningHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.reportsTab = new System.Windows.Forms.ToolStripDropDownButton();
            this.kPIsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPEXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMainPanel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.userIDNumber = new System.Windows.Forms.Label();
            this.userTitleLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.homeToolBar.SuspendLayout();
            this.homeMainPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkOrderManagementTab
            // 
            this.WorkOrderManagementTab.AutoSize = false;
            this.WorkOrderManagementTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeWorkOrders,
            this.toolStripSeparator1,
            this.closedWorkOrders,
            this.toolStripSeparator2,
            this.createWorkOrder});
            this.WorkOrderManagementTab.Image = global::ODP2.Properties.Resources.work_order_9_1_50x50;
            this.WorkOrderManagementTab.Name = "WorkOrderManagementTab";
            this.WorkOrderManagementTab.Size = new System.Drawing.Size(150, 50);
            this.WorkOrderManagementTab.Text = "Work Order Management";
            this.WorkOrderManagementTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // activeWorkOrders
            // 
            this.activeWorkOrders.Name = "activeWorkOrders";
            this.activeWorkOrders.Size = new System.Drawing.Size(199, 22);
            this.activeWorkOrders.Text = "Active Work Orders";
            this.activeWorkOrders.Click += new System.EventHandler(this.activeWorkOrders_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // closedWorkOrders
            // 
            this.closedWorkOrders.Name = "closedWorkOrders";
            this.closedWorkOrders.Size = new System.Drawing.Size(199, 22);
            this.closedWorkOrders.Text = "Closed Work Orders";
            this.closedWorkOrders.Click += new System.EventHandler(this.closedWorkOrders_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // createWorkOrder
            // 
            this.createWorkOrder.Name = "createWorkOrder";
            this.createWorkOrder.Size = new System.Drawing.Size(199, 22);
            this.createWorkOrder.Text = "Create New Work Order";
            this.createWorkOrder.Click += new System.EventHandler(this.createWorkOrder_Click);
            // 
            // SparePartsTab
            // 
            this.SparePartsTab.AutoSize = false;
            this.SparePartsTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventorySpareParts,
            this.toolStripSeparator6,
            this.maintenanceMaterialInquiry});
            this.SparePartsTab.Image = global::ODP2.Properties.Resources._1153743_200;
            this.SparePartsTab.Name = "SparePartsTab";
            this.SparePartsTab.Size = new System.Drawing.Size(150, 50);
            this.SparePartsTab.Text = "Spare Parts";
            this.SparePartsTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // inventorySpareParts
            // 
            this.inventorySpareParts.Name = "inventorySpareParts";
            this.inventorySpareParts.Size = new System.Drawing.Size(229, 22);
            this.inventorySpareParts.Text = "Inventory Spare Parts";
            this.inventorySpareParts.Click += new System.EventHandler(this.inventorySpareParts_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(226, 6);
            // 
            // maintenanceMaterialInquiry
            // 
            this.maintenanceMaterialInquiry.Name = "maintenanceMaterialInquiry";
            this.maintenanceMaterialInquiry.Size = new System.Drawing.Size(229, 22);
            this.maintenanceMaterialInquiry.Text = "Maintenance Material Inquiry";
            this.maintenanceMaterialInquiry.Click += new System.EventHandler(this.maintenanceMaterialInquiry_Click);
            // 
            // equipmentsStatus
            // 
            this.equipmentsStatus.Name = "equipmentsStatus";
            this.equipmentsStatus.Size = new System.Drawing.Size(215, 22);
            this.equipmentsStatus.Text = "Equipment Status";
            // 
            // breakDowns
            // 
            this.breakDowns.Name = "breakDowns";
            this.breakDowns.Size = new System.Drawing.Size(215, 22);
            this.breakDowns.Text = "Break Downs";
            this.breakDowns.Click += new System.EventHandler(this.breakDowns_Click);
            // 
            // pmGeneration
            // 
            this.pmGeneration.Name = "pmGeneration";
            this.pmGeneration.Size = new System.Drawing.Size(215, 22);
            this.pmGeneration.Text = "PM Generation";
            this.pmGeneration.Click += new System.EventHandler(this.pmGeneration_Click);
            // 
            // homeToolBar
            // 
            this.homeToolBar.AutoSize = false;
            this.homeToolBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homeToolBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.homeToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolBarLabel,
            this.homeButton,
            this.toolStripSeparator12,
            this.WorkOrderManagementTab,
            this.toolStripSeparator7,
            this.SparePartsTab,
            this.toolStripSeparator9,
            this.StoresTab,
            this.toolStripSeparator8,
            this.AssetsManagementTab,
            this.toolStripSeparator13,
            this.reportsTab});
            this.homeToolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.homeToolBar.Location = new System.Drawing.Point(3, 3);
            this.homeToolBar.Name = "homeToolBar";
            this.homeToolBar.Size = new System.Drawing.Size(155, 415);
            this.homeToolBar.TabIndex = 1;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(153, 0);
            // 
            // toolBarLabel
            // 
            this.toolBarLabel.Name = "toolBarLabel";
            this.toolBarLabel.Size = new System.Drawing.Size(153, 0);
            // 
            // homeButton
            // 
            this.homeButton.AutoSize = false;
            this.homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(78, 40);
            this.homeButton.Text = "Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(153, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(153, 6);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(153, 6);
            // 
            // StoresTab
            // 
            this.StoresTab.AutoSize = false;
            this.StoresTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issuePartsToolStripMenuItem,
            this.toolStripSeparator10,
            this.financeTransferToolStripMenuItem,
            this.toolStripSeparator11,
            this.fuelStationToolStripMenuItem});
            this.StoresTab.Image = ((System.Drawing.Image)(resources.GetObject("StoresTab.Image")));
            this.StoresTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StoresTab.Name = "StoresTab";
            this.StoresTab.Size = new System.Drawing.Size(150, 50);
            this.StoresTab.Text = "Store Management";
            this.StoresTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StoresTab.ToolTipText = "Stores Management";
            // 
            // issuePartsToolStripMenuItem
            // 
            this.issuePartsToolStripMenuItem.Name = "issuePartsToolStripMenuItem";
            this.issuePartsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.issuePartsToolStripMenuItem.Text = "Issue Parts";
            this.issuePartsToolStripMenuItem.Click += new System.EventHandler(this.issuePartsToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(156, 6);
            // 
            // financeTransferToolStripMenuItem
            // 
            this.financeTransferToolStripMenuItem.Name = "financeTransferToolStripMenuItem";
            this.financeTransferToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.financeTransferToolStripMenuItem.Text = "Finance Transfer";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(156, 6);
            // 
            // fuelStationToolStripMenuItem
            // 
            this.fuelStationToolStripMenuItem.Name = "fuelStationToolStripMenuItem";
            this.fuelStationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.fuelStationToolStripMenuItem.Text = "Fuel Station";
            this.fuelStationToolStripMenuItem.Click += new System.EventHandler(this.fuelStationToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(153, 6);
            // 
            // AssetsManagementTab
            // 
            this.AssetsManagementTab.AutoSize = false;
            this.AssetsManagementTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipmentsStatus,
            this.toolStripSeparator4,
            this.breakDowns,
            this.toolStripSeparator5,
            this.pmGeneration,
            this.toolStripSeparator14,
            this.pMAttachmentsToolStripMenuItem,
            this.toolStripSeparator3,
            this.equipmentRunningHoursToolStripMenuItem});
            this.AssetsManagementTab.Image = global::ODP2.Properties.Resources._961_9617299_container_handler_reach_stacker_icon_png;
            this.AssetsManagementTab.Name = "AssetsManagementTab";
            this.AssetsManagementTab.Size = new System.Drawing.Size(150, 50);
            this.AssetsManagementTab.Text = "Asset Management";
            this.AssetsManagementTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(212, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(212, 6);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(212, 6);
            // 
            // pMAttachmentsToolStripMenuItem
            // 
            this.pMAttachmentsToolStripMenuItem.Name = "pMAttachmentsToolStripMenuItem";
            this.pMAttachmentsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.pMAttachmentsToolStripMenuItem.Text = "PM Attachments";
            this.pMAttachmentsToolStripMenuItem.Click += new System.EventHandler(this.pMAttachmentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(212, 6);
            // 
            // equipmentRunningHoursToolStripMenuItem
            // 
            this.equipmentRunningHoursToolStripMenuItem.Name = "equipmentRunningHoursToolStripMenuItem";
            this.equipmentRunningHoursToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.equipmentRunningHoursToolStripMenuItem.Text = "Equipment Running Hours";
            this.equipmentRunningHoursToolStripMenuItem.Click += new System.EventHandler(this.equipmentRunningHoursToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(153, 6);
            // 
            // reportsTab
            // 
            this.reportsTab.AutoSize = false;
            this.reportsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportsTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kPIsReportToolStripMenuItem,
            this.toolStripSeparator15,
            this.oPEXToolStripMenuItem});
            this.reportsTab.Image = ((System.Drawing.Image)(resources.GetObject("reportsTab.Image")));
            this.reportsTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Size = new System.Drawing.Size(150, 50);
            this.reportsTab.Text = "Reports and Budget";
            this.reportsTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // kPIsReportToolStripMenuItem
            // 
            this.kPIsReportToolStripMenuItem.Name = "kPIsReportToolStripMenuItem";
            this.kPIsReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kPIsReportToolStripMenuItem.Text = "KPIs Report";
            this.kPIsReportToolStripMenuItem.Click += new System.EventHandler(this.kPIsReportToolStripMenuItem_Click);
            // 
            // oPEXToolStripMenuItem
            // 
            this.oPEXToolStripMenuItem.Name = "oPEXToolStripMenuItem";
            this.oPEXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oPEXToolStripMenuItem.Text = "OPEX";
            // 
            // homeMainPanel
            // 
            this.homeMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeMainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeMainPanel.BackgroundImage")));
            this.homeMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeMainPanel.Controls.Add(this.userPanel);
            this.homeMainPanel.Location = new System.Drawing.Point(158, 12);
            this.homeMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.homeMainPanel.Name = "homeMainPanel";
            this.homeMainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.homeMainPanel.Size = new System.Drawing.Size(542, 397);
            this.homeMainPanel.TabIndex = 3;
            // 
            // userPanel
            // 
            this.userPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userPanel.BackColor = System.Drawing.Color.Transparent;
            this.userPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanel.Controls.Add(this.label10);
            this.userPanel.Controls.Add(this.userIDNumber);
            this.userPanel.Controls.Add(this.userTitleLabel);
            this.userPanel.Controls.Add(this.userNameLabel);
            this.userPanel.Controls.Add(this.changePasswordButton);
            this.userPanel.Controls.Add(this.logOutButton);
            this.userPanel.Controls.Add(this.userPicture);
            this.userPanel.Location = new System.Drawing.Point(345, 262);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(197, 135);
            this.userPanel.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(49, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "User Panel";
            // 
            // userIDNumber
            // 
            this.userIDNumber.AutoSize = true;
            this.userIDNumber.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.userIDNumber.Location = new System.Drawing.Point(79, 82);
            this.userIDNumber.Name = "userIDNumber";
            this.userIDNumber.Size = new System.Drawing.Size(43, 12);
            this.userIDNumber.TabIndex = 4;
            this.userIDNumber.Text = "(User ID)";
            // 
            // userTitleLabel
            // 
            this.userTitleLabel.AutoSize = true;
            this.userTitleLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.userTitleLabel.Location = new System.Drawing.Point(78, 58);
            this.userTitleLabel.Name = "userTitleLabel";
            this.userTitleLabel.Size = new System.Drawing.Size(44, 12);
            this.userTitleLabel.TabIndex = 4;
            this.userTitleLabel.Text = "User Title";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(77, 34);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(60, 13);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "User Name";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changePasswordButton.Location = new System.Drawing.Point(81, 107);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(111, 23);
            this.changePasswordButton.TabIndex = 0;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logOutButton.Location = new System.Drawing.Point(3, 107);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(69, 23);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            // 
            // userPicture
            // 
            this.userPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPicture.Location = new System.Drawing.Point(9, 34);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(63, 60);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 1;
            this.userPicture.TabStop = false;
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(177, 6);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(712, 421);
            this.Controls.Add(this.homeMainPanel);
            this.Controls.Add(this.homeToolBar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "ODP Engineering";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.homeToolBar.ResumeLayout(false);
            this.homeToolBar.PerformLayout();
            this.homeMainPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStrip homeToolBar;
        private ToolStripLabel toolBarLabel;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem inventorySpareParts;
        private ToolStripDropDownButton AssetsManagementTab;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripDropDownButton WorkOrderManagementTab;
        private ToolStripMenuItem activeWorkOrders;
        private ToolStripMenuItem closedWorkOrders;
        private ToolStripMenuItem createWorkOrder;
        private ToolStripDropDownButton SparePartsTab;
        private ToolStripMenuItem equipmentsStatus;
        private ToolStripMenuItem breakDowns;
        private ToolStripMenuItem pmGeneration;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem maintenanceMaterialInquiry;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripDropDownButton StoresTab;
        private ToolStripMenuItem issuePartsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem financeTransferToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem equipmentRunningHoursToolStripMenuItem;
        private ToolStripButton homeButton;
        private ToolStripSeparator toolStripSeparator12;
        private Panel homeMainPanel;
        private ToolStripMenuItem fuelStationToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem pMAttachmentsToolStripMenuItem;
        private Panel userPanel;
        private Label label10;
        private Label userIDNumber;
        private Label userTitleLabel;
        private Label userNameLabel;
        private Button changePasswordButton;
        private Button logOutButton;
        private PictureBox userPicture;
        private ToolStripDropDownButton reportsTab;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem kPIsReportToolStripMenuItem;
        private ToolStripMenuItem oPEXToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator15;
    }
}