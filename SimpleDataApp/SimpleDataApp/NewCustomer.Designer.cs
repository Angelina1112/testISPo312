namespace SimpleDataApp
{
    partial class NewCustomer
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
            groupBox1 = new GroupBox();
            txtCustomerID = new TextBox();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtpOrderDate = new DateTimePicker();
            numOrderAmount = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            btnCreateAccount = new Button();
            btnPlaceOrder = new Button();
            btnAddAnotherAccount = new Button();
            btnAddFinish = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление учётной записи";
            // 
            // txtCustomerID
            // 
            txtCustomerID.BackColor = SystemColors.Control;
            txtCustomerID.Location = new Point(187, 77);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(125, 27);
            txtCustomerID.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(131, 30);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(182, 27);
            txtCustomerName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 80);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 1;
            label2.Text = "Идентификатор клиета:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя заказчика:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpOrderDate);
            groupBox2.Controls.Add(numOrderAmount);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Создание заказа";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(143, 80);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(169, 27);
            dtpOrderDate.TabIndex = 4;
            // 
            // numOrderAmount
            // 
            numOrderAmount.Location = new Point(143, 35);
            numOrderAmount.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numOrderAmount.Name = "numOrderAmount";
            numOrderAmount.Size = new Size(169, 27);
            numOrderAmount.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 80);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 2;
            label4.Text = "Дата заказа:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 37);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 1;
            label3.Text = "Сумма заказа:";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(337, 108);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(197, 29);
            btnCreateAccount.TabIndex = 2;
            btnCreateAccount.Text = "Создать учётную запись";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(379, 239);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(155, 29);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Разместить заказ";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnAddAnotherAccount
            // 
            btnAddAnotherAccount.Location = new Point(264, 283);
            btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            btnAddAnotherAccount.Size = new Size(270, 29);
            btnAddAnotherAccount.TabIndex = 4;
            btnAddAnotherAccount.Text = "Добавить другую учётную запись";
            btnAddAnotherAccount.UseVisualStyleBackColor = true;
            btnAddAnotherAccount.Click += btnAddAnotherAccount_Click;
            // 
            // btnAddFinish
            // 
            btnAddFinish.Location = new Point(90, 283);
            btnAddFinish.Name = "btnAddFinish";
            btnAddFinish.Size = new Size(94, 29);
            btnAddFinish.TabIndex = 5;
            btnAddFinish.Text = "Готово";
            btnAddFinish.UseVisualStyleBackColor = true;
            btnAddFinish.Click += btnAddFinish_Click;
            // 
            // NewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 326);
            Controls.Add(btnAddFinish);
            Controls.Add(btnAddAnotherAccount);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnCreateAccount);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NewCustomer";
            Text = "Новая учётная запись и заказ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCreateAccount;
        private Button btnPlaceOrder;
        private Button btnAddAnotherAccount;
        private Button btnAddFinish;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox txtCustomerID;
        private TextBox txtCustomerName;
        private DateTimePicker dtpOrderDate;
        private NumericUpDown numOrderAmount;
    }
}