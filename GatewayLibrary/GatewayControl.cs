using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParafaitPaymentGateway;
using System.Diagnostics;
using System.Threading;


namespace GatewayLibrary
{
    public partial class GatewayControl: UserControl
    {
        private Thread parafaitTheard;

        private bool isCtrlVEntered = false;
        private Gateway parafaitPaymentGateway;
        private bool isAdd ;
        public string refNo { get; set; }

        public delegate void updateServerStatus(string status, Gateway p);
        public updateServerStatus delegateUpdateServerStatus;

        public GatewayControl(string refNo)
        {
            InitializeComponent();
            this.refNo = refNo;
            this.lvCardsID.View = System.Windows.Forms.View.Details;
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Tickets";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader1.Width = 146;
            this.lvCardsID.Columns.Add(columnHeader1);
            lbRef.Text = refNo;
            isAdd = true;
            delegateUpdateServerStatus = new updateServerStatus(updateServerStatusMethod);

       }

        public Thread startParafaitThread()
        {
            var t = new Thread(() => ParafaitProvider.Connect(this));
            t.Start();
            return t;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
        }

        void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Would you like to close the parent form?", "Close parent form?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                parafaitTheard.Abort();
            }
        }

        public void updateServerStatusMethod(string status, Gateway p)
        {
            lbServerStatus.Text = status;
            parafaitPaymentGateway = p;
            if ("Could not connect".Equals(status))
            {
                MessageBox.Show("Could not connect to server", "Connection error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void receiveNewCardId(string cardID){
            if (isAdd)
                addToCardList(cardID);
            else
                removeFromCardList(cardID);
        }

        private void addToCardList(string cardID)
        {
            if (lvCardsID.FindItemWithText(cardID) == null)
            {
                lvCardsID.Items.Add(cardID);
                lbNumberCard.Text = lvCardsID.Items.Count.ToString();
            }
        }

        private void removeFromCardList(string cardID)
        {
            ListViewItem item = lvCardsID.FindItemWithText(cardID);
            if (item != null)
            {
                lvCardsID.Items.Remove(item);
                lbNumberCard.Text = lvCardsID.Items.Count.ToString();
            }
        }

        private void clearAllCardList()
        {
            lvCardsID.Items.Clear();
            lbNumberCard.Text = lvCardsID.Items.Count.ToString();
        }

        void issueCard(String cardID)
        {
            try
            {
                double id = parafaitPaymentGateway.RechargeCardWithProductDllMode(cardID,
                                    "ENTRYPRODUCT", "EXTERNALPOS", "TRXREFERENCE");
                if (id < 0)
                {
                    String message = parafaitPaymentGateway.LastMessageDetails();
                    MessageBox.Show("Error in issuing entry " + message);
                }
                else
                    MessageBox.Show("Card issued. Trx id is  " + id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in card issue: " + ex.Message);
            }
        }

        private void Control1_HandleDestroyed(Object sender, EventArgs e)
        {

            MessageBox.Show("You are in the Control.HandleDestroyed event.");

        }


        private void btSave_Click(object sender, EventArgs e)
        {
            List<string> listID = lvCardsID.Items.Cast<ListViewItem>()
                                 .Select(item => item.Text)
                                 .ToList();
            foreach (string cardID in listID)
            {
                issueCard(cardID);
            }

            clearAllCardList();
            tbCurrentCardID.Focus();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            clearAllCardList();
            tbCurrentCardID.Focus();
        }

        private void tbCurrentCardID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                isCtrlVEntered = true;
                (sender as TextBox).Clear();
            }
        }

        private void tbCurrentCardID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !isCtrlVEntered;
        }

        private void tbCurrentCardID_TextChanged(object sender, EventArgs e)
        {
            if (isCtrlVEntered && !String.IsNullOrEmpty(tbCurrentCardID.Text))
            {
                receiveNewCardId(tbCurrentCardID.Text);
                isCtrlVEntered = false;
            }
        }


        private void GatewayControl_Load(object sender, EventArgs e)
        {
            parafaitTheard = startParafaitThread();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            this.noHeaderTabControl1.SelectTab("tabPageRemove");
            tbCurrentCardID.Focus();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.noHeaderTabControl1.SelectTab("tabPageAdd");
            tbCurrentCardID.Focus();
        }

        private void noHeaderTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.noHeaderTabControl1.SelectedTab.Name == "tabPageAdd")
            {
                isAdd = true;
                Debug.WriteLine("Change tab: isAdd: " + isAdd);
            }
            else if (this.noHeaderTabControl1.SelectedTab.Name == "tabPageRemove")
            {
                isAdd = false;
                Debug.WriteLine("Change tab: isAdd: " + isAdd);
            }
            else
            {
                throw new Exception("Unknow actions?? You can add or remove cards");
            }
        }
    }
}
