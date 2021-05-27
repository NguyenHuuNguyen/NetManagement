
namespace PBL3_NetManagement
{
    partial class FormOrder
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
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.IDGood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.buttonOrder_Order = new System.Windows.Forms.Button();
            this.buttonCancel_Order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDGood,
            this.GoodName,
            this.Price,
            this.Unit});
            this.dataGridViewOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewOrder.Location = new System.Drawing.Point(26, 32);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOrder.Size = new System.Drawing.Size(586, 443);
            this.dataGridViewOrder.TabIndex = 0;
            this.dataGridViewOrder.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.datagridviewOrder_EditingControlShowing);
            // 
            // IDGood
            // 
            this.IDGood.HeaderText = "ID Good";
            this.IDGood.MinimumWidth = 6;
            this.IDGood.Name = "IDGood";
            this.IDGood.ReadOnly = true;
            this.IDGood.Visible = false;
            // 
            // GoodName
            // 
            this.GoodName.HeaderText = "Good Name";
            this.GoodName.MinimumWidth = 6;
            this.GoodName.Name = "GoodName";
            this.GoodName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MTO Chaney", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.Location = new System.Drawing.Point(99, 528);
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.ReadOnly = true;
            this.textBoxOrder.Size = new System.Drawing.Size(157, 22);
            this.textBoxOrder.TabIndex = 2;
            // 
            // buttonOrder_Order
            // 
            this.buttonOrder_Order.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOrder_Order.Font = new System.Drawing.Font("MTO Chaney", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder_Order.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOrder_Order.Location = new System.Drawing.Point(331, 515);
            this.buttonOrder_Order.Name = "buttonOrder_Order";
            this.buttonOrder_Order.Size = new System.Drawing.Size(126, 43);
            this.buttonOrder_Order.TabIndex = 3;
            this.buttonOrder_Order.Text = "Order";
            this.buttonOrder_Order.UseVisualStyleBackColor = false;
            this.buttonOrder_Order.Click += new System.EventHandler(this.buttonOrder_Order_Click);
            // 
            // buttonCancel_Order
            // 
            this.buttonCancel_Order.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancel_Order.Font = new System.Drawing.Font("MTO Chaney", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel_Order.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel_Order.Location = new System.Drawing.Point(486, 515);
            this.buttonCancel_Order.Name = "buttonCancel_Order";
            this.buttonCancel_Order.Size = new System.Drawing.Size(126, 43);
            this.buttonCancel_Order.TabIndex = 4;
            this.buttonCancel_Order.Text = "Cancel";
            this.buttonCancel_Order.UseVisualStyleBackColor = false;
            this.buttonCancel_Order.Click += new System.EventHandler(this.buttonCancel_Order_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 599);
            this.Controls.Add(this.buttonCancel_Order);
            this.Controls.Add(this.buttonOrder_Order);
            this.Controls.Add(this.textBoxOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOrder);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.Button buttonOrder_Order;
        private System.Windows.Forms.Button buttonCancel_Order;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
    }
}