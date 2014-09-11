namespace GatewayLibrary
{
    partial class GatewayControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCurrentCardID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRef = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNumberCard = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvCardsID = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.lbServerStatus = new System.Windows.Forms.Label();
            this.noHeaderTabControl1 = new GatewayLibrary.NoHeaderTabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.tabPageRemove = new System.Windows.Forms.TabPage();
            this.btBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.noHeaderTabControl1.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.noHeaderTabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0804F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.9196F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCurrentCardID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbRef);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 89);
            this.panel1.TabIndex = 0;
            // 
            // tbCurrentCardID
            // 
            this.tbCurrentCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentCardID.Location = new System.Drawing.Point(264, 11);
            this.tbCurrentCardID.Name = "tbCurrentCardID";
            this.tbCurrentCardID.Size = new System.Drawing.Size(186, 27);
            this.tbCurrentCardID.TabIndex = 5;
            this.tbCurrentCardID.TextChanged += new System.EventHandler(this.tbCurrentCardID_TextChanged);
            this.tbCurrentCardID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCurrentCardID_KeyDown);
            this.tbCurrentCardID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentCardID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Card.ID";
            // 
            // lbRef
            // 
            this.lbRef.AutoSize = true;
            this.lbRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRef.Location = new System.Drawing.Point(23, 41);
            this.lbRef.Name = "lbRef";
            this.lbRef.Size = new System.Drawing.Size(90, 22);
            this.lbRef.TabIndex = 3;
            this.lbRef.Text = "10000069";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ref.No";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbServerStatus);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbNumberCard);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(499, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 89);
            this.panel2.TabIndex = 1;
            // 
            // lbNumberCard
            // 
            this.lbNumberCard.AutoSize = true;
            this.lbNumberCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberCard.Location = new System.Drawing.Point(114, 52);
            this.lbNumberCard.Name = "lbNumberCard";
            this.lbNumberCard.Size = new System.Drawing.Size(20, 22);
            this.lbNumberCard.TabIndex = 7;
            this.lbNumberCard.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvCardsID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(496, 101);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 496);
            this.panel4.TabIndex = 3;
            // 
            // lvCardsID
            // 
            this.lvCardsID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCardsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCardsID.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCardsID.Location = new System.Drawing.Point(0, 0);
            this.lvCardsID.Name = "lvCardsID";
            this.lvCardsID.Size = new System.Drawing.Size(301, 496);
            this.lvCardsID.TabIndex = 1;
            this.lvCardsID.UseCompatibleStateImageBehavior = false;
            this.lvCardsID.View = System.Windows.Forms.View.Details;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Server Status:";
            // 
            // lbServerStatus
            // 
            this.lbServerStatus.AutoSize = true;
            this.lbServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServerStatus.Location = new System.Drawing.Point(127, 12);
            this.lbServerStatus.Name = "lbServerStatus";
            this.lbServerStatus.Size = new System.Drawing.Size(76, 17);
            this.lbServerStatus.TabIndex = 10;
            this.lbServerStatus.Text = "disconnect";
            // 
            // noHeaderTabControl1
            // 
            this.noHeaderTabControl1.Controls.Add(this.tabPageAdd);
            this.noHeaderTabControl1.Controls.Add(this.tabPageRemove);
            this.noHeaderTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noHeaderTabControl1.Location = new System.Drawing.Point(6, 104);
            this.noHeaderTabControl1.Name = "noHeaderTabControl1";
            this.noHeaderTabControl1.SelectedIndex = 0;
            this.noHeaderTabControl1.Size = new System.Drawing.Size(484, 490);
            this.noHeaderTabControl1.TabIndex = 4;
            this.noHeaderTabControl1.SelectedIndexChanged += new System.EventHandler(this.noHeaderTabControl1_SelectedIndexChanged);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAdd.Controls.Add(this.btDelete);
            this.tabPageAdd.Controls.Add(this.btSave);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.btCancel);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(476, 464);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Add";
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(23, 303);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(109, 40);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(23, 104);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(165, 94);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "SAVE";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "PLEASE TAP CARD";
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(244, 104);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(165, 94);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "CLEAR";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tabPageRemove
            // 
            this.tabPageRemove.Controls.Add(this.btBack);
            this.tabPageRemove.Controls.Add(this.label5);
            this.tabPageRemove.Location = new System.Drawing.Point(4, 22);
            this.tabPageRemove.Name = "tabPageRemove";
            this.tabPageRemove.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRemove.Size = new System.Drawing.Size(476, 464);
            this.tabPageRemove.TabIndex = 1;
            this.tabPageRemove.Text = "Remove";
            this.tabPageRemove.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(23, 278);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(121, 63);
            this.btBack.TabIndex = 7;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "TAP TO REMOVE";
            // 
            // GatewayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GatewayControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.GatewayControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.noHeaderTabControl1.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageRemove.ResumeLayout(false);
            this.tabPageRemove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCurrentCardID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNumberCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvCardsID;
        private NoHeaderTabControl noHeaderTabControl1;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageRemove;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbServerStatus;

    }
}
