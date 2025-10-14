using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {        
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();
        }
        private void tmsSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmsCurrentUserInfo_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserInfo(clsUsers.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void tmsChangePassword_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(clsUsers.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            Form frm = new frmDriversList();
            frm.ShowDialog();
        }

        private void tsmiAppTypes_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageApplicationTypes();
            frm.ShowDialog();
          
        }

        private void tsmiTestTypes_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void btnSettingAcc_Click(object sender, EventArgs e)
        {
            ctxtmsAccountSettings.Show(btnSettingAcc, new Point(0, btnSettingAcc.Height));
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            frmManagePeople frm = new frmManagePeople();
            frm.ShowDialog();
        }

        private void btnApps_Click(object sender, EventArgs e)
        {
            ctxtmsApps.Show(btnApps, new Point(0, btnApps.Height));
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditLDLApps(-1);
            frm.ShowDialog();
        }

        private void localDrivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageLocalDrivingLicensesApplications();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmIssueInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void internationalDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListInternationalLicenseApplications();
            frm.ShowDialog();
        }

        private void renewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmRenewLocalDrivingLicenses();
            frm.ShowDialog();
        }

        private void replacementForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm=new frmReplacementForLocalLicenses();
            frm.ShowDialog();
        }

        private void tsmimanageDetainedLicenses_Click(object sender, EventArgs e)
        {
            Form frm =new frmManageDetainedLicenses();
            frm.ShowDialog();
        }

        private void tsmidetainedLicnese_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainLicenses();
            frm.ShowDialog();
        }

        private void tsmireleaseDetainedLicnese_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleaseDetainedLicenses(-1);
            frm.ShowDialog();
        }

        private void releaseDetainedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleaseDetainedLicenses(-1);
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageLocalDrivingLicensesApplications();
            frm.ShowDialog();
        }
    }
}
