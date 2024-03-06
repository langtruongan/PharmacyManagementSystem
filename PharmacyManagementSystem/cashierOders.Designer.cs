namespace PharmacyManagementSystem
{
    partial class cashierOders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashierOders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orders_receiptBtn = new System.Windows.Forms.Button();
            this.orders_removeBtn = new System.Windows.Forms.Button();
            this.orders_payBtn = new System.Windows.Forms.Button();
            this.orders_change = new System.Windows.Forms.Label();
            this.orders_totalPrice = new System.Windows.Forms.Label();
            this.orders_amount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.orders_clearBtn = new System.Windows.Forms.Button();
            this.orders_addBtn = new System.Windows.Forms.Button();
            this.orders_quantity = new System.Windows.Forms.NumericUpDown();
            this.orders_regPrice = new System.Windows.Forms.Label();
            this.orders_prodName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orders_prodID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.orders_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 431);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Avaiable Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.orders_receiptBtn);
            this.panel2.Controls.Add(this.orders_removeBtn);
            this.panel2.Controls.Add(this.orders_payBtn);
            this.panel2.Controls.Add(this.orders_change);
            this.panel2.Controls.Add(this.orders_totalPrice);
            this.panel2.Controls.Add(this.orders_amount);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(810, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 692);
            this.panel2.TabIndex = 1;
            // 
            // orders_receiptBtn
            // 
            this.orders_receiptBtn.BackColor = System.Drawing.Color.Teal;
            this.orders_receiptBtn.FlatAppearance.BorderSize = 0;
            this.orders_receiptBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.orders_receiptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.orders_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_receiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.orders_receiptBtn.Location = new System.Drawing.Point(253, 560);
            this.orders_receiptBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orders_receiptBtn.Name = "orders_receiptBtn";
            this.orders_receiptBtn.Size = new System.Drawing.Size(147, 41);
            this.orders_receiptBtn.TabIndex = 31;
            this.orders_receiptBtn.Text = "RECEIPT";
            this.orders_receiptBtn.UseVisualStyleBackColor = false;
            this.orders_receiptBtn.Click += new System.EventHandler(this.orders_receiptBtn_Click);
            // 
            // orders_removeBtn
            // 
            this.orders_removeBtn.BackColor = System.Drawing.Color.Teal;
            this.orders_removeBtn.FlatAppearance.BorderSize = 0;
            this.orders_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.orders_removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.orders_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_removeBtn.ForeColor = System.Drawing.Color.White;
            this.orders_removeBtn.Location = new System.Drawing.Point(157, 632);
            this.orders_removeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orders_removeBtn.Name = "orders_removeBtn";
            this.orders_removeBtn.Size = new System.Drawing.Size(147, 41);
            this.orders_removeBtn.TabIndex = 30;
            this.orders_removeBtn.Text = "REMOVE";
            this.orders_removeBtn.UseVisualStyleBackColor = false;
            this.orders_removeBtn.Click += new System.EventHandler(this.orders_removeBtn_Click);
            // 
            // orders_payBtn
            // 
            this.orders_payBtn.BackColor = System.Drawing.Color.Teal;
            this.orders_payBtn.FlatAppearance.BorderSize = 0;
            this.orders_payBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.orders_payBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.orders_payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_payBtn.ForeColor = System.Drawing.Color.White;
            this.orders_payBtn.Location = new System.Drawing.Point(54, 560);
            this.orders_payBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orders_payBtn.Name = "orders_payBtn";
            this.orders_payBtn.Size = new System.Drawing.Size(147, 41);
            this.orders_payBtn.TabIndex = 23;
            this.orders_payBtn.Text = "PAY";
            this.orders_payBtn.UseVisualStyleBackColor = false;
            this.orders_payBtn.Click += new System.EventHandler(this.orders_payBtn_Click);
            // 
            // orders_change
            // 
            this.orders_change.AutoSize = true;
            this.orders_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_change.Location = new System.Drawing.Point(230, 512);
            this.orders_change.Name = "orders_change";
            this.orders_change.Size = new System.Drawing.Size(61, 25);
            this.orders_change.TabIndex = 28;
            this.orders_change.Text = "$0.00";
            // 
            // orders_totalPrice
            // 
            this.orders_totalPrice.AutoSize = true;
            this.orders_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_totalPrice.Location = new System.Drawing.Point(230, 431);
            this.orders_totalPrice.Name = "orders_totalPrice";
            this.orders_totalPrice.Size = new System.Drawing.Size(61, 25);
            this.orders_totalPrice.TabIndex = 27;
            this.orders_totalPrice.Text = "$0.00";
            // 
            // orders_amount
            // 
            this.orders_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_amount.Location = new System.Drawing.Point(235, 472);
            this.orders_amount.Name = "orders_amount";
            this.orders_amount.Size = new System.Drawing.Size(122, 30);
            this.orders_amount.TabIndex = 26;
            this.orders_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.orders_amount_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(109, 515);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Change:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(109, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total Price: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Orders";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(421, 375);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.orders_clearBtn);
            this.panel3.Controls.Add(this.orders_addBtn);
            this.panel3.Controls.Add(this.orders_quantity);
            this.panel3.Controls.Add(this.orders_regPrice);
            this.panel3.Controls.Add(this.orders_prodName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.orders_prodID);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.orders_category);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(14, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 244);
            this.panel3.TabIndex = 2;
            // 
            // orders_clearBtn
            // 
            this.orders_clearBtn.BackColor = System.Drawing.Color.Teal;
            this.orders_clearBtn.FlatAppearance.BorderSize = 0;
            this.orders_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.orders_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.orders_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_clearBtn.ForeColor = System.Drawing.Color.White;
            this.orders_clearBtn.Location = new System.Drawing.Point(462, 184);
            this.orders_clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orders_clearBtn.Name = "orders_clearBtn";
            this.orders_clearBtn.Size = new System.Drawing.Size(147, 41);
            this.orders_clearBtn.TabIndex = 22;
            this.orders_clearBtn.Text = "CLEAR";
            this.orders_clearBtn.UseVisualStyleBackColor = false;
            this.orders_clearBtn.Click += new System.EventHandler(this.orders_clearBtn_Click);
            // 
            // orders_addBtn
            // 
            this.orders_addBtn.BackColor = System.Drawing.Color.Teal;
            this.orders_addBtn.FlatAppearance.BorderSize = 0;
            this.orders_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.orders_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.orders_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_addBtn.ForeColor = System.Drawing.Color.White;
            this.orders_addBtn.Location = new System.Drawing.Point(162, 184);
            this.orders_addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orders_addBtn.Name = "orders_addBtn";
            this.orders_addBtn.Size = new System.Drawing.Size(147, 41);
            this.orders_addBtn.TabIndex = 17;
            this.orders_addBtn.Text = "ADD";
            this.orders_addBtn.UseVisualStyleBackColor = false;
            this.orders_addBtn.Click += new System.EventHandler(this.orders_addBtn_Click);
            // 
            // orders_quantity
            // 
            this.orders_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_quantity.Location = new System.Drawing.Point(516, 101);
            this.orders_quantity.Name = "orders_quantity";
            this.orders_quantity.Size = new System.Drawing.Size(251, 30);
            this.orders_quantity.TabIndex = 21;
            // 
            // orders_regPrice
            // 
            this.orders_regPrice.AutoSize = true;
            this.orders_regPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_regPrice.Location = new System.Drawing.Point(179, 120);
            this.orders_regPrice.Name = "orders_regPrice";
            this.orders_regPrice.Size = new System.Drawing.Size(27, 25);
            this.orders_regPrice.TabIndex = 20;
            this.orders_regPrice.Text = "...";
            // 
            // orders_prodName
            // 
            this.orders_prodName.AutoSize = true;
            this.orders_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_prodName.Location = new System.Drawing.Point(179, 75);
            this.orders_prodName.Name = "orders_prodName";
            this.orders_prodName.Size = new System.Drawing.Size(27, 25);
            this.orders_prodName.TabIndex = 19;
            this.orders_prodName.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Regular Price ($):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Product Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantity:";
            // 
            // orders_prodID
            // 
            this.orders_prodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_prodID.FormattingEnabled = true;
            this.orders_prodID.Location = new System.Drawing.Point(516, 16);
            this.orders_prodID.Name = "orders_prodID";
            this.orders_prodID.Size = new System.Drawing.Size(251, 33);
            this.orders_prodID.TabIndex = 15;
            this.orders_prodID.SelectedIndexChanged += new System.EventHandler(this.orders_prodID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Product ID:";
            // 
            // orders_category
            // 
            this.orders_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_category.FormattingEnabled = true;
            this.orders_category.Location = new System.Drawing.Point(113, 16);
            this.orders_category.Name = "orders_category";
            this.orders_category.Size = new System.Drawing.Size(251, 33);
            this.orders_category.TabIndex = 13;
            this.orders_category.SelectedIndexChanged += new System.EventHandler(this.orders_category_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Category:";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cashierOders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "cashierOders";
            this.Size = new System.Drawing.Size(1280, 722);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox orders_prodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox orders_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown orders_quantity;
        private System.Windows.Forms.Label orders_regPrice;
        private System.Windows.Forms.Label orders_prodName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button orders_clearBtn;
        private System.Windows.Forms.Button orders_addBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button orders_receiptBtn;
        private System.Windows.Forms.Button orders_removeBtn;
        private System.Windows.Forms.Button orders_payBtn;
        private System.Windows.Forms.Label orders_change;
        private System.Windows.Forms.Label orders_totalPrice;
        private System.Windows.Forms.TextBox orders_amount;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
