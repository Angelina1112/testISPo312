namespace SimpleDataApp
{
    partial class FillOrCancel
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
            label1 = new Label();
            txtOrderID = new TextBox();
            btnFindByOrderID = new Button();
            label2 = new Label();
            dtpFillDate = new DateTimePicker();
            dgvCustomerOrders = new DataGridView();
            btnCancelOrder = new Button();
            btnFillOrder = new Button();
            btnFinishUpdates = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 1;
            label1.Text = "Идентификатор заказа:";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(188, 6);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(154, 27);
            txtOrderID.TabIndex = 2;
            // 
            // btnFindByOrderID
            // 
            btnFindByOrderID.Location = new Point(348, 5);
            btnFindByOrderID.Name = "btnFindByOrderID";
            btnFindByOrderID.Size = new Size(114, 29);
            btnFindByOrderID.TabIndex = 3;
            btnFindByOrderID.Text = "Найти заказ";
            btnFindByOrderID.UseVisualStyleBackColor = true;
            btnFindByOrderID.Click += btnFindByOrderID_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(357, 20);
            label2.TabIndex = 4;
            label2.Text = "При заполнении заказа укажите дату заполнения";
            // 
            // dtpFillDate
            // 
            dtpFillDate.Format = DateTimePickerFormat.Short;
            dtpFillDate.Location = new Point(375, 85);
            dtpFillDate.Name = "dtpFillDate";
            dtpFillDate.Size = new Size(104, 27);
            dtpFillDate.TabIndex = 5;
            // 
            // dgvCustomerOrders
            // 
            dgvCustomerOrders.BackgroundColor = SystemColors.Control;
            dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrders.Location = new Point(12, 118);
            dgvCustomerOrders.Name = "dgvCustomerOrders";
            dgvCustomerOrders.ReadOnly = true;
            dgvCustomerOrders.RowHeadersVisible = false;
            dgvCustomerOrders.RowHeadersWidth = 51;
            dgvCustomerOrders.Size = new Size(467, 141);
            dgvCustomerOrders.TabIndex = 6;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(32, 275);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(130, 29);
            btnCancelOrder.TabIndex = 7;
            btnCancelOrder.Text = "Отменить заказ";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnFillOrder
            // 
            btnFillOrder.Location = new Point(168, 275);
            btnFillOrder.Name = "btnFillOrder";
            btnFillOrder.Size = new Size(136, 29);
            btnFillOrder.TabIndex = 8;
            btnFillOrder.Text = "Заполнить заказ";
            btnFillOrder.UseVisualStyleBackColor = true;
            btnFillOrder.Click += btnFillOrder_Click;
            // 
            // btnFinishUpdates
            // 
            btnFinishUpdates.Location = new Point(376, 275);
            btnFinishUpdates.Name = "btnFinishUpdates";
            btnFinishUpdates.Size = new Size(94, 29);
            btnFinishUpdates.TabIndex = 9;
            btnFinishUpdates.Text = "Готово";
            btnFinishUpdates.UseVisualStyleBackColor = true;
            btnFinishUpdates.Click += btnFinishUpdates_Click;
            // 
            // FillOrCancel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 309);
            Controls.Add(btnFinishUpdates);
            Controls.Add(btnFillOrder);
            Controls.Add(btnCancelOrder);
            Controls.Add(dgvCustomerOrders);
            Controls.Add(dtpFillDate);
            Controls.Add(label2);
            Controls.Add(btnFindByOrderID);
            Controls.Add(txtOrderID);
            Controls.Add(label1);
            Name = "FillOrCancel";
            Text = "Заполнение или отмена заказов";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrderID;
        private Button btnFindByOrderID;
        private Label label2;
        private DateTimePicker dtpFillDate;
        private DataGridView dgvCustomerOrders;
        private Button btnCancelOrder;
        private Button btnFillOrder;
        private Button btnFinishUpdates;
    }
}