namespace NorthwindLab3
{
    partial class frmNorthwind
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label quantityPerUnitLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label unitsInStockLabel;
            System.Windows.Forms.Label unitsOnOrderLabel;
            System.Windows.Forms.Label reorderLevelLabel;
            System.Windows.Forms.Label discontinuedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNorthwind));
            this.northwndDataSet = new NorthwindLab3.northwndDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new NorthwindLab3.northwndDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new NorthwindLab3.northwndDataSetTableAdapters.TableAdapterManager();
            this.order_DetailsTableAdapter = new NorthwindLab3.northwndDataSetTableAdapters.Order_DetailsTableAdapter();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.quantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitsInStockTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnOrderTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.discontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippersTableAdapter = new NorthwindLab3.northwndDataSetTableAdapters.ShippersTableAdapter();
            this.categoriesTableAdapter = new NorthwindLab3.northwndDataSetTableAdapters.CategoriesTableAdapter();
            this.lblNorthwind = new System.Windows.Forms.Label();
            this.grpbxProducts = new System.Windows.Forms.GroupBox();
            this.grpbxOrderDetails = new System.Windows.Forms.GroupBox();
            this.order_DetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_DetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            quantityPerUnitLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            unitsInStockLabel = new System.Windows.Forms.Label();
            unitsOnOrderLabel = new System.Windows.Forms.Label();
            reorderLevelLabel = new System.Windows.Forms.Label();
            discontinuedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwndDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).BeginInit();
            this.grpbxProducts.SuspendLayout();
            this.grpbxOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(18, 27);
            productIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(94, 19);
            productIDLabel.TabIndex = 1;
            productIDLabel.Text = "Product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(18, 63);
            productNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(117, 19);
            productNameLabel.TabIndex = 3;
            productNameLabel.Text = "Product Name:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(18, 99);
            supplierIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(95, 19);
            supplierIDLabel.TabIndex = 5;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(18, 135);
            categoryIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(102, 19);
            categoryIDLabel.TabIndex = 7;
            categoryIDLabel.Text = "Category ID:";
            // 
            // quantityPerUnitLabel
            // 
            quantityPerUnitLabel.AutoSize = true;
            quantityPerUnitLabel.Location = new System.Drawing.Point(18, 171);
            quantityPerUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantityPerUnitLabel.Name = "quantityPerUnitLabel";
            quantityPerUnitLabel.Size = new System.Drawing.Size(139, 19);
            quantityPerUnitLabel.TabIndex = 9;
            quantityPerUnitLabel.Text = "Quantity Per Unit:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(18, 207);
            unitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(85, 19);
            unitPriceLabel.TabIndex = 11;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // unitsInStockLabel
            // 
            unitsInStockLabel.AutoSize = true;
            unitsInStockLabel.Location = new System.Drawing.Point(18, 243);
            unitsInStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unitsInStockLabel.Name = "unitsInStockLabel";
            unitsInStockLabel.Size = new System.Drawing.Size(115, 19);
            unitsInStockLabel.TabIndex = 13;
            unitsInStockLabel.Text = "Units In Stock:";
            // 
            // unitsOnOrderLabel
            // 
            unitsOnOrderLabel.AutoSize = true;
            unitsOnOrderLabel.Location = new System.Drawing.Point(18, 279);
            unitsOnOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unitsOnOrderLabel.Name = "unitsOnOrderLabel";
            unitsOnOrderLabel.Size = new System.Drawing.Size(123, 19);
            unitsOnOrderLabel.TabIndex = 15;
            unitsOnOrderLabel.Text = "Units On Order:";
            // 
            // reorderLevelLabel
            // 
            reorderLevelLabel.AutoSize = true;
            reorderLevelLabel.Location = new System.Drawing.Point(18, 315);
            reorderLevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            reorderLevelLabel.Name = "reorderLevelLabel";
            reorderLevelLabel.Size = new System.Drawing.Size(114, 19);
            reorderLevelLabel.TabIndex = 17;
            reorderLevelLabel.Text = "Reorder Level:";
            // 
            // discontinuedLabel
            // 
            discontinuedLabel.AutoSize = true;
            discontinuedLabel.Location = new System.Drawing.Point(18, 354);
            discontinuedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            discontinuedLabel.Name = "discontinuedLabel";
            discontinuedLabel.Size = new System.Drawing.Size(108, 19);
            discontinuedLabel.TabIndex = 19;
            discontinuedLabel.Text = "Discontinued:";
            // 
            // northwndDataSet
            // 
            this.northwndDataSet.DataSetName = "northwndDataSet";
            this.northwndDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.northwndDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = this.order_DetailsTableAdapter;
            this.tableAdapterManager.orderhistTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NorthwindLab3.northwndDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(1010, 25);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(163, 27);
            this.productIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(188, 26);
            this.productIDTextBox.TabIndex = 2;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(163, 63);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(188, 26);
            this.productNameTextBox.TabIndex = 4;
            // 
            // quantityPerUnitTextBox
            // 
            this.quantityPerUnitTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.quantityPerUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "QuantityPerUnit", true));
            this.quantityPerUnitTextBox.Location = new System.Drawing.Point(163, 167);
            this.quantityPerUnitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityPerUnitTextBox.Name = "quantityPerUnitTextBox";
            this.quantityPerUnitTextBox.Size = new System.Drawing.Size(188, 26);
            this.quantityPerUnitTextBox.TabIndex = 10;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(163, 203);
            this.unitPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(188, 26);
            this.unitPriceTextBox.TabIndex = 12;
            // 
            // unitsInStockTextBox
            // 
            this.unitsInStockTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.unitsInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitsInStock", true));
            this.unitsInStockTextBox.Location = new System.Drawing.Point(163, 239);
            this.unitsInStockTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.unitsInStockTextBox.Name = "unitsInStockTextBox";
            this.unitsInStockTextBox.Size = new System.Drawing.Size(188, 26);
            this.unitsInStockTextBox.TabIndex = 14;
            // 
            // unitsOnOrderTextBox
            // 
            this.unitsOnOrderTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.unitsOnOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitsOnOrder", true));
            this.unitsOnOrderTextBox.Location = new System.Drawing.Point(163, 275);
            this.unitsOnOrderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.unitsOnOrderTextBox.Name = "unitsOnOrderTextBox";
            this.unitsOnOrderTextBox.Size = new System.Drawing.Size(188, 26);
            this.unitsOnOrderTextBox.TabIndex = 16;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.reorderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ReorderLevel", true));
            this.reorderLevelTextBox.Location = new System.Drawing.Point(163, 311);
            this.reorderLevelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(188, 26);
            this.reorderLevelTextBox.TabIndex = 18;
            // 
            // discontinuedCheckBox
            // 
            this.discontinuedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productsBindingSource, "Discontinued", true));
            this.discontinuedCheckBox.Location = new System.Drawing.Point(163, 347);
            this.discontinuedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.discontinuedCheckBox.Name = "discontinuedCheckBox";
            this.discontinuedCheckBox.Size = new System.Drawing.Size(190, 34);
            this.discontinuedCheckBox.TabIndex = 20;
            this.discontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "SupplierID", true));
            this.comboBox1.DataSource = this.SupplierBindingSource;
            this.comboBox1.DisplayMember = "CompanyName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 99);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 27);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "ShipperID";
            // 
            // SupplierBindingSource
            // 
            this.SupplierBindingSource.DataMember = "Shippers";
            this.SupplierBindingSource.DataSource = this.northwndDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "CategoryID", true));
            this.comboBox2.DataSource = this.CategoryBindingSource;
            this.comboBox2.DisplayMember = "CategoryName";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(163, 135);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 27);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.ValueMember = "CategoryID";
            // 
            // CategoryBindingSource
            // 
            this.CategoryBindingSource.DataMember = "Categories";
            this.CategoryBindingSource.DataSource = this.northwndDataSet;
            // 
            // shippersTableAdapter
            // 
            this.shippersTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // lblNorthwind
            // 
            this.lblNorthwind.AutoSize = true;
            this.lblNorthwind.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorthwind.Location = new System.Drawing.Point(268, 44);
            this.lblNorthwind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNorthwind.Name = "lblNorthwind";
            this.lblNorthwind.Size = new System.Drawing.Size(393, 31);
            this.lblNorthwind.TabIndex = 23;
            this.lblNorthwind.Text = "Northwind Product Entry Form";
            // 
            // grpbxProducts
            // 
            this.grpbxProducts.Controls.Add(this.comboBox2);
            this.grpbxProducts.Controls.Add(this.comboBox1);
            this.grpbxProducts.Controls.Add(productIDLabel);
            this.grpbxProducts.Controls.Add(this.productIDTextBox);
            this.grpbxProducts.Controls.Add(productNameLabel);
            this.grpbxProducts.Controls.Add(this.productNameTextBox);
            this.grpbxProducts.Controls.Add(supplierIDLabel);
            this.grpbxProducts.Controls.Add(categoryIDLabel);
            this.grpbxProducts.Controls.Add(quantityPerUnitLabel);
            this.grpbxProducts.Controls.Add(this.quantityPerUnitTextBox);
            this.grpbxProducts.Controls.Add(unitPriceLabel);
            this.grpbxProducts.Controls.Add(this.unitPriceTextBox);
            this.grpbxProducts.Controls.Add(unitsInStockLabel);
            this.grpbxProducts.Controls.Add(this.unitsInStockTextBox);
            this.grpbxProducts.Controls.Add(unitsOnOrderLabel);
            this.grpbxProducts.Controls.Add(this.unitsOnOrderTextBox);
            this.grpbxProducts.Controls.Add(reorderLevelLabel);
            this.grpbxProducts.Controls.Add(this.reorderLevelTextBox);
            this.grpbxProducts.Controls.Add(discontinuedLabel);
            this.grpbxProducts.Controls.Add(this.discontinuedCheckBox);
            this.grpbxProducts.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxProducts.Location = new System.Drawing.Point(45, 78);
            this.grpbxProducts.Name = "grpbxProducts";
            this.grpbxProducts.Size = new System.Drawing.Size(369, 413);
            this.grpbxProducts.TabIndex = 24;
            this.grpbxProducts.TabStop = false;
            this.grpbxProducts.Text = "Products";
            // 
            // grpbxOrderDetails
            // 
            this.grpbxOrderDetails.Controls.Add(this.order_DetailsDataGridView);
            this.grpbxOrderDetails.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxOrderDetails.Location = new System.Drawing.Point(428, 78);
            this.grpbxOrderDetails.Name = "grpbxOrderDetails";
            this.grpbxOrderDetails.Size = new System.Drawing.Size(573, 413);
            this.grpbxOrderDetails.TabIndex = 25;
            this.grpbxOrderDetails.TabStop = false;
            this.grpbxOrderDetails.Text = "Order Details";
            // 
            // order_DetailsDataGridView
            // 
            this.order_DetailsDataGridView.AutoGenerateColumns = false;
            this.order_DetailsDataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.order_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_DetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.order_DetailsDataGridView.DataSource = this.order_DetailsBindingSource1;
            this.order_DetailsDataGridView.Location = new System.Drawing.Point(6, 27);
            this.order_DetailsDataGridView.Name = "order_DetailsDataGridView";
            this.order_DetailsDataGridView.ReadOnly = true;
            this.order_DetailsDataGridView.Size = new System.Drawing.Size(561, 380);
            this.order_DetailsDataGridView.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // order_DetailsBindingSource1
            // 
            this.order_DetailsBindingSource1.DataMember = "FK_Order_Details_Products";
            this.order_DetailsBindingSource1.DataSource = this.productsBindingSource;
            // 
            // frmNorthwind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1010, 545);
            this.Controls.Add(this.grpbxOrderDetails);
            this.Controls.Add(this.grpbxProducts);
            this.Controls.Add(this.lblNorthwind);
            this.Controls.Add(this.productsBindingNavigator);
            this.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNorthwind";
            this.Text = "Northwind";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwndDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).EndInit();
            this.grpbxProducts.ResumeLayout(false);
            this.grpbxProducts.PerformLayout();
            this.grpbxOrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private northwndDataSet northwndDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private northwndDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private northwndDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private northwndDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox quantityPerUnitTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox unitsInStockTextBox;
        private System.Windows.Forms.TextBox unitsOnOrderTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.CheckBox discontinuedCheckBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource SupplierBindingSource;
        private northwndDataSetTableAdapters.ShippersTableAdapter shippersTableAdapter;
        private System.Windows.Forms.BindingSource CategoryBindingSource;
        private northwndDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Label lblNorthwind;
        private System.Windows.Forms.GroupBox grpbxProducts;
        private System.Windows.Forms.GroupBox grpbxOrderDetails;
        private System.Windows.Forms.DataGridView order_DetailsDataGridView;
        private System.Windows.Forms.BindingSource order_DetailsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
    }
}

