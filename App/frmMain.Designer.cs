namespace DVLD
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ctxtmsAccountSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ctxtmsApps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.renewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.replacementForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsiApps = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.internationalDrivingLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimanageDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmidetainedLicnese = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmireleaseDetainedLicnese = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAppTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettingAcc = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnApps = new System.Windows.Forms.Button();
            this.ctxtmsAccountSettings.SuspendLayout();
            this.ctxtmsApps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxtmsAccountSettings
            // 
            this.ctxtmsAccountSettings.BackColor = System.Drawing.Color.White;
            this.ctxtmsAccountSettings.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxtmsAccountSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtmsAccountSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsCurrentUserInfo,
            this.tmsChangePassword,
            this.tmsSignOut});
            this.ctxtmsAccountSettings.Name = "ctxtmsAccountSettings";
            this.ctxtmsAccountSettings.Size = new System.Drawing.Size(237, 118);
            // 
            // tmsCurrentUserInfo
            // 
            this.tmsCurrentUserInfo.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.tmsCurrentUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tmsCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsCurrentUserInfo.Name = "tmsCurrentUserInfo";
            this.tmsCurrentUserInfo.Size = new System.Drawing.Size(236, 38);
            this.tmsCurrentUserInfo.Text = "Current User Info";
            this.tmsCurrentUserInfo.Click += new System.EventHandler(this.tmsCurrentUserInfo_Click);
            // 
            // tmsChangePassword
            // 
            this.tmsChangePassword.Image = global::DVLD.Properties.Resources.Password_32;
            this.tmsChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tmsChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsChangePassword.Name = "tmsChangePassword";
            this.tmsChangePassword.Size = new System.Drawing.Size(236, 38);
            this.tmsChangePassword.Text = "Change Password";
            this.tmsChangePassword.Click += new System.EventHandler(this.tmsChangePassword_Click);
            // 
            // tmsSignOut
            // 
            this.tmsSignOut.Image = global::DVLD.Properties.Resources.sign_out_32__2;
            this.tmsSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tmsSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsSignOut.Name = "tmsSignOut";
            this.tmsSignOut.Size = new System.Drawing.Size(236, 38);
            this.tmsSignOut.Text = "Sign Out";
            this.tmsSignOut.Click += new System.EventHandler(this.tmsSignOut_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "account_settings 64.png");
            this.imageList1.Images.SetKeyName(1, "Applications.png");
            this.imageList1.Images.SetKeyName(2, "Drivers 64.png");
            this.imageList1.Images.SetKeyName(3, "Exit 64.png");
            this.imageList1.Images.SetKeyName(4, "People 400.png");
            this.imageList1.Images.SetKeyName(5, "Users 2 400.png");
            // 
            // ctxtmsApps
            // 
            this.ctxtmsApps.BackColor = System.Drawing.Color.White;
            this.ctxtmsApps.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxtmsApps.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtmsApps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLicenses,
            this.toolStripSeparator1,
            this.tmsiApps,
            this.toolStripSeparator2,
            this.toolStripMenuItem3,
            this.toolStripSeparator3,
            this.tsmiAppTypes,
            this.toolStripSeparator4,
            this.tsmiTestTypes});
            this.ctxtmsApps.Name = "ctxtmsAccountSettings";
            this.ctxtmsApps.Size = new System.Drawing.Size(360, 378);
            // 
            // tsmiLicenses
            // 
            this.tsmiLicenses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicencesToolStripMenuItem,
            this.toolStripSeparator5,
            this.renewToolStripMenuItem,
            this.toolStripSeparator6,
            this.replacementForToolStripMenuItem,
            this.toolStripSeparator7,
            this.releaseDetainedToolStripMenuItem,
            this.toolStripSeparator8,
            this.retakeTestToolStripMenuItem});
            this.tsmiLicenses.Image = global::DVLD.Properties.Resources.Driver_License_48;
            this.tsmiLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiLicenses.Name = "tsmiLicenses";
            this.tsmiLicenses.Size = new System.Drawing.Size(359, 70);
            this.tsmiLicenses.Text = "Driving Licenses Services";
            // 
            // newDrivingLicencesToolStripMenuItem
            // 
            this.newDrivingLicencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.toolStripSeparator9,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicencesToolStripMenuItem.Image = global::DVLD.Properties.Resources.New_Driving_License_32;
            this.newDrivingLicencesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newDrivingLicencesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newDrivingLicencesToolStripMenuItem.Name = "newDrivingLicencesToolStripMenuItem";
            this.newDrivingLicencesToolStripMenuItem.Size = new System.Drawing.Size(467, 38);
            this.newDrivingLicencesToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Local_32;
            this.localLicenseToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(285, 6);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.International_32;
            this.internationalLicenseToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.internationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(464, 6);
            // 
            // renewToolStripMenuItem
            // 
            this.renewToolStripMenuItem.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.renewToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.renewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewToolStripMenuItem.Name = "renewToolStripMenuItem";
            this.renewToolStripMenuItem.Size = new System.Drawing.Size(467, 38);
            this.renewToolStripMenuItem.Text = "Renew Driving License";
            this.renewToolStripMenuItem.Click += new System.EventHandler(this.renewToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(464, 6);
            // 
            // replacementForToolStripMenuItem
            // 
            this.replacementForToolStripMenuItem.Image = global::DVLD.Properties.Resources.Damaged_Driving_License_32;
            this.replacementForToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.replacementForToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replacementForToolStripMenuItem.Name = "replacementForToolStripMenuItem";
            this.replacementForToolStripMenuItem.Size = new System.Drawing.Size(467, 38);
            this.replacementForToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            this.replacementForToolStripMenuItem.Click += new System.EventHandler(this.replacementForToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(464, 6);
            // 
            // releaseDetainedToolStripMenuItem
            // 
            this.releaseDetainedToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detained_Driving_License_32;
            this.releaseDetainedToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.releaseDetainedToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainedToolStripMenuItem.Name = "releaseDetainedToolStripMenuItem";
            this.releaseDetainedToolStripMenuItem.Size = new System.Drawing.Size(467, 38);
            this.releaseDetainedToolStripMenuItem.Text = "Release Detained Driving License";
            this.releaseDetainedToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(464, 6);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Retake_Test_32;
            this.retakeTestToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.retakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(467, 38);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // tmsiApps
            // 
            this.tmsiApps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingToolStripMenuItem,
            this.toolStripSeparator10,
            this.internationalDrivingLicenseApplicationToolStripMenuItem});
            this.tmsiApps.Image = global::DVLD.Properties.Resources.Manage_Applications_64;
            this.tmsiApps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tmsiApps.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsiApps.Name = "tmsiApps";
            this.tmsiApps.Size = new System.Drawing.Size(359, 70);
            this.tmsiApps.Text = "Manage Applications";
            // 
            // localDrivingToolStripMenuItem
            // 
            this.localDrivingToolStripMenuItem.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.localDrivingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localDrivingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localDrivingToolStripMenuItem.Name = "localDrivingToolStripMenuItem";
            this.localDrivingToolStripMenuItem.Size = new System.Drawing.Size(399, 38);
            this.localDrivingToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingToolStripMenuItem.Click += new System.EventHandler(this.localDrivingToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(396, 6);
            // 
            // internationalDrivingLicenseApplicationToolStripMenuItem
            // 
            this.internationalDrivingLicenseApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.International_32;
            this.internationalDrivingLicenseApplicationToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.internationalDrivingLicenseApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalDrivingLicenseApplicationToolStripMenuItem.Name = "internationalDrivingLicenseApplicationToolStripMenuItem";
            this.internationalDrivingLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(399, 38);
            this.internationalDrivingLicenseApplicationToolStripMenuItem.Text = "International License Applications";
            this.internationalDrivingLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingLicenseApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(356, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmimanageDetainedLicenses,
            this.tsmidetainedLicnese,
            this.tsmireleaseDetainedLicnese});
            this.toolStripMenuItem3.Image = global::DVLD.Properties.Resources.Detain_64;
            this.toolStripMenuItem3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(359, 70);
            this.toolStripMenuItem3.Text = "Detain Licenses";
            // 
            // tsmimanageDetainedLicenses
            // 
            this.tsmimanageDetainedLicenses.Image = global::DVLD.Properties.Resources.Detain_32;
            this.tsmimanageDetainedLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmimanageDetainedLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmimanageDetainedLicenses.Name = "tsmimanageDetainedLicenses";
            this.tsmimanageDetainedLicenses.Size = new System.Drawing.Size(337, 38);
            this.tsmimanageDetainedLicenses.Text = "Manage Detained Licenses";
            this.tsmimanageDetainedLicenses.Click += new System.EventHandler(this.tsmimanageDetainedLicenses_Click);
            // 
            // tsmidetainedLicnese
            // 
            this.tsmidetainedLicnese.Image = global::DVLD.Properties.Resources.Detain_32;
            this.tsmidetainedLicnese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmidetainedLicnese.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmidetainedLicnese.Name = "tsmidetainedLicnese";
            this.tsmidetainedLicnese.Size = new System.Drawing.Size(337, 38);
            this.tsmidetainedLicnese.Text = "Detain License";
            this.tsmidetainedLicnese.Click += new System.EventHandler(this.tsmidetainedLicnese_Click);
            // 
            // tsmireleaseDetainedLicnese
            // 
            this.tsmireleaseDetainedLicnese.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.tsmireleaseDetainedLicnese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmireleaseDetainedLicnese.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmireleaseDetainedLicnese.Name = "tsmireleaseDetainedLicnese";
            this.tsmireleaseDetainedLicnese.Size = new System.Drawing.Size(337, 38);
            this.tsmireleaseDetainedLicnese.Text = "Release Detained License";
            this.tsmireleaseDetainedLicnese.Click += new System.EventHandler(this.tsmireleaseDetainedLicnese_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(356, 6);
            // 
            // tsmiAppTypes
            // 
            this.tsmiAppTypes.Image = global::DVLD.Properties.Resources.Application_Types_64;
            this.tsmiAppTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiAppTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAppTypes.Name = "tsmiAppTypes";
            this.tsmiAppTypes.Size = new System.Drawing.Size(359, 70);
            this.tsmiAppTypes.Text = "Manage Application Types";
            this.tsmiAppTypes.Click += new System.EventHandler(this.tsmiAppTypes_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(356, 6);
            // 
            // tsmiTestTypes
            // 
            this.tsmiTestTypes.Image = global::DVLD.Properties.Resources.Test_Type_64;
            this.tsmiTestTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiTestTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTestTypes.Name = "tsmiTestTypes";
            this.tsmiTestTypes.Size = new System.Drawing.Size(359, 70);
            this.tsmiTestTypes.Text = "Manage Test Types";
            this.tsmiTestTypes.Click += new System.EventHandler(this.tsmiTestTypes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Logo_Final1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1657, 673);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettingAcc
            // 
            this.btnSettingAcc.ContextMenuStrip = this.ctxtmsAccountSettings;
            this.btnSettingAcc.FlatAppearance.BorderSize = 0;
            this.btnSettingAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingAcc.ImageIndex = 0;
            this.btnSettingAcc.ImageList = this.imageList1;
            this.btnSettingAcc.Location = new System.Drawing.Point(840, 6);
            this.btnSettingAcc.Name = "btnSettingAcc";
            this.btnSettingAcc.Size = new System.Drawing.Size(292, 81);
            this.btnSettingAcc.TabIndex = 9;
            this.btnSettingAcc.Text = "          Account Settings";
            this.btnSettingAcc.UseVisualStyleBackColor = true;
            this.btnSettingAcc.Click += new System.EventHandler(this.btnSettingAcc_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.ImageIndex = 5;
            this.btnUsers.ImageList = this.imageList1;
            this.btnUsers.Location = new System.Drawing.Point(639, 6);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(204, 81);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.Text = "       Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.ImageIndex = 2;
            this.btnDrivers.ImageList = this.imageList1;
            this.btnDrivers.Location = new System.Drawing.Point(448, 6);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(204, 81);
            this.btnDrivers.TabIndex = 7;
            this.btnDrivers.Text = "       Drivers";
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.ImageIndex = 4;
            this.btnPeople.ImageList = this.imageList1;
            this.btnPeople.Location = new System.Drawing.Point(249, 6);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(204, 81);
            this.btnPeople.TabIndex = 6;
            this.btnPeople.Text = "       People";
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnApps
            // 
            this.btnApps.FlatAppearance.BorderSize = 0;
            this.btnApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApps.Image = global::DVLD.Properties.Resources.Applications_64;
            this.btnApps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApps.Location = new System.Drawing.Point(4, 6);
            this.btnApps.Name = "btnApps";
            this.btnApps.Size = new System.Drawing.Size(245, 81);
            this.btnApps.TabIndex = 5;
            this.btnApps.Text = "          Applications";
            this.btnApps.UseVisualStyleBackColor = true;
            this.btnApps.Click += new System.EventHandler(this.btnApps_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1657, 673);
            this.Controls.Add(this.btnSettingAcc);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnDrivers);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.btnApps);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ctxtmsAccountSettings.ResumeLayout(false);
            this.ctxtmsApps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettingAcc;
        private System.Windows.Forms.ContextMenuStrip ctxtmsAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem tmsCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tmsChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tmsSignOut;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnApps;
        private System.Windows.Forms.ContextMenuStrip ctxtmsApps;
        private System.Windows.Forms.ToolStripMenuItem tsmiLicenses;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem renewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem replacementForToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmsiApps;
        private System.Windows.Forms.ToolStripMenuItem localDrivingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiAppTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmimanageDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem tsmidetainedLicnese;
        private System.Windows.Forms.ToolStripMenuItem tsmireleaseDetainedLicnese;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}