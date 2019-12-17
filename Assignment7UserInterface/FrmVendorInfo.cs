using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment7BusinessClassLibrary;

namespace Assignment7UserInterface
{
    public partial class FrmVendorInfo : Form
    {
        public FrmVendorInfo()
        {
            InitializeComponent();
        }

        VendorBL vendBL = new VendorBL();
        List<Vendors> lstOfVendors = new List<Vendors>();
        Vendors ven = new Vendors();

        private void BtnExitApplication_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void ButtonGetVendors_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboState.SelectedIndex != -1)
                {

                    List<Vendors> vendorsWithState = (from vendors in lstOfVendors
                                                      where cboState.Text == vendors.State
                                                      select vendors).ToList();

                    foreach (Vendors vend in vendorsWithState)
                    {
                        vend.ContactFullName = vend.ContactFName + " , " + vend.ContactLName;
                    }


                    vendorsBindingSource.DataSource = vendorsWithState;
                }

                else
                {
                    MessageBox.Show("Please Select a State", "No State Selected", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
            }

            catch(Exception except)
            {
                MessageBox.Show(except.Message, except.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                cboState.Focus();
            }

                  
        }

        private void FrmVendorInfo_Load(object sender, EventArgs e)
        {
            try
            {


                lstOfVendors = vendBL.GetVendors();


                if (lstOfVendors.Count != 0)
                {


                    var sortedState = (from ven in lstOfVendors
                                       where ven != null
                                       orderby ven.State ascending
                                       select ven.State).Distinct();

                    var statesName = sortedState.ToList();

                    cboState.DataSource = statesName;






                    cboState.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No Vendors Found", "No Vendors Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception except)
            {
                MessageBox.Show(except.Message, except.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void CboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Control ctrl in Controls)
                {
                    if (ctrl.Name.StartsWith("lbl"))
                    {
                        ctrl.Text = string.Empty;
                    }
                }


                foreach (Control ctrl in pnlVendorInfo.Controls)
                {
                    if (ctrl.Name.StartsWith("lbl"))
                    {
                        ctrl.Text = string.Empty;
                    }
                   
                }
                
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, except.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }


        }

      
    }
}
