namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.compute = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount (%):";
            // 
            // item
            // 
            this.item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.Location = new System.Drawing.Point(12, 56);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(247, 26);
            this.item.TabIndex = 2;
            // 
            // discount
            // 
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(286, 56);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(229, 26);
            this.discount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(62, 88);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(197, 26);
            this.price.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(359, 88);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(156, 26);
            this.quantity.TabIndex = 7;
            // 
            // compute
            // 
            this.compute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compute.Location = new System.Drawing.Point(205, 146);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(97, 33);
            this.compute.TabIndex = 8;
            this.compute.Text = "Compute";
            this.compute.UseVisualStyleBackColor = true;
            this.compute.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Amount: ";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(233, 238);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(13, 20);
            this.amount.TabIndex = 10;
            this.amount.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Payment Received:";
            // 
            // payment
            // 
            this.payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(202, 299);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(100, 26);
            this.payment.TabIndex = 12;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(308, 296);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(78, 32);
            this.submit.TabIndex = 13;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Change:";
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(254, 347);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(13, 20);
            this.change.TabIndex = 15;
            this.change.Text = " ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logout,
            this.exitApplicationToolStripMenuItem1});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.logoutToolStripMenuItem.Text = "File";
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(180, 22);
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // exitApplicationToolStripMenuItem1
            // 
            this.exitApplicationToolStripMenuItem1.Name = "exitApplicationToolStripMenuItem1";
            this.exitApplicationToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitApplicationToolStripMenuItem1.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem1.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem1_Click);
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 380);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.compute);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.item);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPurchaseDiscountedItem";
            this.Text = "Purchase Discounted Item";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox payment;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
    }
}

