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


namespace GatewayLibrary
{
    public partial class GatewayControl: UserControl
    {
        private bool isCtrlVEntered = false;
        private Gateway parafaitPaymentGateway;
        private bool isAdd ;
        public string refNo { get; set; }

        public GatewayControl()
        {
            InitializeComponent();
            this.refNo = refNo;
            this.lvCardsID.View = System.Windows.Forms.View.Details;
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Tickets";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader1.Width = 146;
            this.lvCardsID.Columns.Add(columnHeader1);
            lbRef.Text = "unkown";
            isAdd = true;
            connectParafaitServer();
        }

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
        }

        private void addToCardList(string cardID)
        {
            if (lvCardsID.FindItemWithText(cardID) == null)
            {
                lvCardsID.Items.Add(cardID);
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

        private void connectParafaitServer()
        {
            lbServerStatus.Text = "re-con";
            parafaitPaymentGateway = new Gateway();
            if (!parafaitPaymentGateway.InitializeDllMode())
            {
                lbServerStatus.Text = "disconnect";
                throw new Exception("Error initializing Parafait External Gateway: " + parafaitPaymentGateway.LastMessageDetails());
                //MessageBox.Show("Error initializing Parafait External Gateway", "Init Gateway");
                //MessageBox.Show(parafaitPaymentGateway.LastMessageDetails(), "Init Gateway");        
            }
            else
            {
                lbServerStatus.Text = "connecting";
            }
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
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            clearAllCardList();
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
                addToCardList(tbCurrentCardID.Text);
                isCtrlVEntered = false;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            lbServerStatus.Text = "re-con";
            parafaitPaymentGateway = new Gateway();
            if (!parafaitPaymentGateway.InitializeDllMode())
            {
                lbServerStatus.Text = "disconnect";
                throw new Exception("Error initializing Parafait External Gateway: " + parafaitPaymentGateway.LastMessageDetails());
                //MessageBox.Show("Error initializing Parafait External Gateway", "Init Gateway");
                //MessageBox.Show(parafaitPaymentGateway.LastMessageDetails(), "Init Gateway");        
            }
            else
            {
                lbServerStatus.Text = "connecting";
            }
            base.OnLoad(e);
        }

        private void GatewayControl_Load(object sender, EventArgs e)
        {
            //connectParafaitServer();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            this.noHeaderTabControl1.SelectTab("tabPageRemove");
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.noHeaderTabControl1.SelectTab("tabPageAdd");
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
