namespace SimpleDataApp
{
    partial class Navigation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGoToAdd = new Button();
            btnGoToFillOrCancel = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGoToAdd
            // 
            btnGoToAdd.Location = new Point(111, 60);
            btnGoToAdd.Name = "btnGoToAdd";
            btnGoToAdd.Size = new Size(214, 31);
            btnGoToAdd.TabIndex = 0;
            btnGoToAdd.Text = "Добавить учётную запись";
            btnGoToAdd.UseVisualStyleBackColor = true;
            btnGoToAdd.Click += btnGoToAdd_Click;
            // 
            // btnGoToFillOrCancel
            // 
            btnGoToFillOrCancel.Location = new Point(94, 97);
            btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            btnGoToFillOrCancel.Size = new Size(255, 29);
            btnGoToFillOrCancel.TabIndex = 1;
            btnGoToFillOrCancel.Text = "Заполнить или отменить заказ";
            btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            btnGoToFillOrCancel.Click += btnGoToFillOrCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(315, 174);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(72, 23);
            label1.Name = "label1";
            label1.Size = new Size(180, 23);
            label1.TabIndex = 3;
            label1.Text = "Выберите действие.";
            // 
            // Navigation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 215);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnGoToFillOrCancel);
            Controls.Add(btnGoToAdd);
            Name = "Navigation";
            Text = "Приветствие";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGoToAdd;
        private Button btnGoToFillOrCancel;
        private Button btnExit;
        private Label label1;
    }
}
