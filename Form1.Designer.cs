namespace CarStoreGUIApp
{
    partial class frmCarStore
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
            groupBox1 = new GroupBox();
            txtPrice = new TextBox();
            txtYear = new TextBox();
            txtModel = new TextBox();
            txtMake = new TextBox();
            lblPrice = new Label();
            lblYear = new Label();
            lblModel = new Label();
            lblMake = new Label();
            btnCreate = new Button();
            groupBox2 = new GroupBox();
            btnSortValue = new Button();
            btnSortYear = new Button();
            lblSort = new Label();
            btnSortAtoZ = new Button();
            listInventory = new ListBox();
            groupBox3 = new GroupBox();
            listShoppingCart = new ListBox();
            btnAddToCart = new Button();
            btnCheckout = new Button();
            label5 = new Label();
            lblTotal = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(txtMake);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(lblYear);
            groupBox1.Controls.Add(lblModel);
            groupBox1.Controls.Add(lblMake);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 268);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a Car";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(80, 172);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(216, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(77, 128);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(219, 27);
            txtYear.TabIndex = 7;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(77, 85);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(219, 27);
            txtModel.TabIndex = 6;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(77, 39);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(219, 27);
            txtMake.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(14, 175);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(13, 131);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(37, 20);
            lblYear.TabIndex = 3;
            lblYear.Text = "Year";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(10, 85);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(9, 37);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(45, 20);
            lblMake.TabIndex = 1;
            lblMake.Text = "Make";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(80, 228);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += BtnCreate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSortValue);
            groupBox2.Controls.Add(btnSortYear);
            groupBox2.Controls.Add(lblSort);
            groupBox2.Controls.Add(btnSortAtoZ);
            groupBox2.Controls.Add(listInventory);
            groupBox2.Location = new Point(354, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 533);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Store Inventory";
            // 
            // btnSortValue
            // 
            btnSortValue.Location = new Point(200, 33);
            btnSortValue.Name = "btnSortValue";
            btnSortValue.Size = new Size(59, 29);
            btnSortValue.TabIndex = 4;
            btnSortValue.Text = "$";
            btnSortValue.UseVisualStyleBackColor = true;
            // 
            // btnSortYear
            // 
            btnSortYear.Location = new Point(136, 33);
            btnSortYear.Name = "btnSortYear";
            btnSortYear.Size = new Size(58, 29);
            btnSortYear.TabIndex = 3;
            btnSortYear.Text = "Year";
            btnSortYear.UseVisualStyleBackColor = true;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Location = new Point(16, 37);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(39, 20);
            lblSort.TabIndex = 2;
            lblSort.Text = "Sort:";
            // 
            // btnSortAtoZ
            // 
            btnSortAtoZ.Location = new Point(69, 33);
            btnSortAtoZ.Name = "btnSortAtoZ";
            btnSortAtoZ.Size = new Size(61, 29);
            btnSortAtoZ.TabIndex = 1;
            btnSortAtoZ.Text = "A -> Z";
            btnSortAtoZ.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSortAtoZ.UseVisualStyleBackColor = true;
            btnSortAtoZ.Click += BtnSortAToZ_Click;
            // 
            // listInventory
            // 
            listInventory.FormattingEnabled = true;
            listInventory.Location = new Point(16, 72);
            listInventory.Name = "listInventory";
            listInventory.Size = new Size(268, 444);
            listInventory.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listShoppingCart);
            groupBox3.Location = new Point(836, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(299, 533);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Shopping Cart";
            // 
            // listShoppingCart
            // 
            listShoppingCart.FormattingEnabled = true;
            listShoppingCart.Location = new Point(20, 40);
            listShoppingCart.Name = "listShoppingCart";
            listShoppingCart.Size = new Size(262, 464);
            listShoppingCart.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(697, 240);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(76, 60);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Add to Cart ->";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += BtnAddToCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(933, 537);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += BtnCheckout_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(864, 599);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 5;
            label5.Text = "Car Store";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1020, 599);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(607, 561);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(354, 563);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(247, 27);
            txtSearch.TabIndex = 8;
            // 
            // frmCarStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 639);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(lblTotal);
            Controls.Add(label5);
            Controls.Add(btnCheckout);
            Controls.Add(btnAddToCart);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmCarStore";
            Text = "Car Store";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listInventory;
        private GroupBox groupBox3;
        private ListBox listShoppingCart;
        private Button btnCreate;
        private Button btnCheckout;
        private Button btnAddToCart;
        private TextBox txtMake;
        private Label lblPrice;
        private Label lblYear;
        private Label lblModel;
        private Label lblMake;
        private TextBox txtPrice;
        private TextBox txtYear;
        private TextBox txtModel;
        private Label label5;
        private Label lblTotal;
        private Button btnSortValue;
        private Button btnSortYear;
        private Label lblSort;
        private Button btnSortAtoZ;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}
