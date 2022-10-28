
namespace Курсовая.Forms
{
    partial class TablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseTableCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.used_carDataSet = new Курсовая.Used_carDataSet();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new Курсовая.Used_carDataSetTableAdapters.BrandTableAdapter();
            this.tableAdapterManager = new Курсовая.Used_carDataSetTableAdapters.TableAdapterManager();
            this.carcaseTableAdapter = new Курсовая.Used_carDataSetTableAdapters.CarcaseTableAdapter();
            this.carTableAdapter = new Курсовая.Used_carDataSetTableAdapters.CarTableAdapter();
            this.clientTableAdapter = new Курсовая.Used_carDataSetTableAdapters.ClientTableAdapter();
            this.contractTableAdapter = new Курсовая.Used_carDataSetTableAdapters.ContractTableAdapter();
            this.dealerTableAdapter = new Курсовая.Used_carDataSetTableAdapters.DealerTableAdapter();
            this.modelTableAdapter = new Курсовая.Used_carDataSetTableAdapters.ModelTableAdapter();
            this.photo_carTableAdapter = new Курсовая.Used_carDataSetTableAdapters.Photo_carTableAdapter();
            this.stateTableAdapter = new Курсовая.Used_carDataSetTableAdapters.StateTableAdapter();
            this.BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.brandBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.brandDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDataGridView = new System.Windows.Forms.DataGridView();
            this.carcaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carcaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo_carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photo_carDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.used_carDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).BeginInit();
            this.BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carcaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carcaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_carDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 82);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Просмотр таблиц";
            // 
            // chooseTableCB
            // 
            this.chooseTableCB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseTableCB.FormattingEnabled = true;
            this.chooseTableCB.Items.AddRange(new object[] {
            "Car",
            "Brand",
            "Carcase",
            "Client",
            "Contract",
            "Dealer",
            "Model",
            "Photo_car",
            "State"});
            this.chooseTableCB.Location = new System.Drawing.Point(323, 85);
            this.chooseTableCB.Name = "chooseTableCB";
            this.chooseTableCB.Size = new System.Drawing.Size(223, 34);
            this.chooseTableCB.TabIndex = 3;
            this.chooseTableCB.SelectedIndexChanged += new System.EventHandler(this.chooseTableCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите таблицу:";
            // 
            // used_carDataSet
            // 
            this.used_carDataSet.DataSetName = "Used_carDataSet";
            this.used_carDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.used_carDataSet;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = this.brandTableAdapter;
            this.tableAdapterManager.CarcaseTableAdapter = this.carcaseTableAdapter;
            this.tableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.ContractTableAdapter = this.contractTableAdapter;
            this.tableAdapterManager.DealerTableAdapter = this.dealerTableAdapter;
            this.tableAdapterManager.ModelTableAdapter = this.modelTableAdapter;
            this.tableAdapterManager.Photo_carTableAdapter = this.photo_carTableAdapter;
            this.tableAdapterManager.StateTableAdapter = this.stateTableAdapter;
            this.tableAdapterManager.UpdateOrder = Курсовая.Used_carDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carcaseTableAdapter
            // 
            this.carcaseTableAdapter.ClearBeforeFill = true;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // dealerTableAdapter
            // 
            this.dealerTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // photo_carTableAdapter
            // 
            this.photo_carTableAdapter.ClearBeforeFill = true;
            // 
            // stateTableAdapter
            // 
            this.stateTableAdapter.ClearBeforeFill = true;
            // 
            // BindingNavigator
            // 
            this.BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BindingNavigator.BindingSource = this.brandBindingSource;
            this.BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.brandBindingNavigatorSaveItem});
            this.BindingNavigator.Location = new System.Drawing.Point(581, 85);
            this.BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigator.Name = "BindingNavigator";
            this.BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigator.Size = new System.Drawing.Size(341, 27);
            this.BindingNavigator.TabIndex = 4;
            this.BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // brandBindingNavigatorSaveItem
            // 
            this.brandBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brandBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("brandBindingNavigatorSaveItem.Image")));
            this.brandBindingNavigatorSaveItem.Name = "brandBindingNavigatorSaveItem";
            this.brandBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.brandBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.brandBindingNavigatorSaveItem.Click += new System.EventHandler(this.brandBindingNavigatorSaveItem_Click);
            // 
            // brandDataGridView
            // 
            this.brandDataGridView.AutoGenerateColumns = false;
            this.brandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.brandDataGridView.DataSource = this.brandBindingSource;
            this.brandDataGridView.Location = new System.Drawing.Point(9, 125);
            this.brandDataGridView.Name = "brandDataGridView";
            this.brandDataGridView.RowHeadersWidth = 51;
            this.brandDataGridView.RowTemplate.Height = 24;
            this.brandDataGridView.Size = new System.Drawing.Size(1353, 599);
            this.brandDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name_brand";
            this.dataGridViewTextBoxColumn1.HeaderText = "name_brand";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_brand";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_brand";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.used_carDataSet;
            // 
            // carDataGridView
            // 
            this.carDataGridView.AutoGenerateColumns = false;
            this.carDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.carDataGridView.DataSource = this.carBindingSource;
            this.carDataGridView.Location = new System.Drawing.Point(9, 125);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.RowHeadersWidth = 51;
            this.carDataGridView.RowTemplate.Height = 24;
            this.carDataGridView.Size = new System.Drawing.Size(1353, 599);
            this.carDataGridView.TabIndex = 5;
            // 
            // carcaseBindingSource
            // 
            this.carcaseBindingSource.DataMember = "Carcase";
            this.carcaseBindingSource.DataSource = this.used_carDataSet;
            // 
            // carcaseDataGridView
            // 
            this.carcaseDataGridView.AutoGenerateColumns = false;
            this.carcaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carcaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.carcaseDataGridView.DataSource = this.carcaseBindingSource;
            this.carcaseDataGridView.Location = new System.Drawing.Point(9, 125);
            this.carcaseDataGridView.Name = "carcaseDataGridView";
            this.carcaseDataGridView.RowHeadersWidth = 51;
            this.carcaseDataGridView.RowTemplate.Height = 24;
            this.carcaseDataGridView.Size = new System.Drawing.Size(1353, 599);
            this.carcaseDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "id_carcase";
            this.dataGridViewTextBoxColumn15.HeaderText = "id_carcase";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "type_carcase";
            this.dataGridViewTextBoxColumn16.HeaderText = "type_carcase";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.used_carDataSet;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.clientDataGridView.DataSource = this.clientBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(9, 125);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.RowHeadersWidth = 51;
            this.clientDataGridView.RowTemplate.Height = 24;
            this.clientDataGridView.Size = new System.Drawing.Size(1353, 599);
            this.clientDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "id_client";
            this.dataGridViewTextBoxColumn17.HeaderText = "id_client";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "telephone";
            this.dataGridViewTextBoxColumn18.HeaderText = "telephone";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn19.HeaderText = "address";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "name_client";
            this.dataGridViewTextBoxColumn20.HeaderText = "name_client";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.used_carDataSet;
            // 
            // contractDataGridView
            // 
            this.contractDataGridView.AutoGenerateColumns = false;
            this.contractDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26});
            this.contractDataGridView.DataSource = this.contractBindingSource;
            this.contractDataGridView.Location = new System.Drawing.Point(9, 125);
            this.contractDataGridView.Name = "contractDataGridView";
            this.contractDataGridView.RowHeadersWidth = 51;
            this.contractDataGridView.RowTemplate.Height = 24;
            this.contractDataGridView.Size = new System.Drawing.Size(1353, 599);
            this.contractDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "id_contract";
            this.dataGridViewTextBoxColumn21.HeaderText = "id_contract";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "date_transaction";
            this.dataGridViewTextBoxColumn22.HeaderText = "date_transaction";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "id_client";
            this.dataGridViewTextBoxColumn23.HeaderText = "id_client";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "id_dealer";
            this.dataGridViewTextBoxColumn24.HeaderText = "id_dealer";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "id_lot";
            this.dataGridViewTextBoxColumn25.HeaderText = "id_lot";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 125;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "actual_price";
            this.dataGridViewTextBoxColumn26.HeaderText = "actual_price";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 125;
            // 
            // dealerBindingSource
            // 
            this.dealerBindingSource.DataMember = "Dealer";
            this.dealerBindingSource.DataSource = this.used_carDataSet;
            // 
            // dealerDataGridView
            // 
            this.dealerDataGridView.AutoGenerateColumns = false;
            this.dealerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30});
            this.dealerDataGridView.DataSource = this.dealerBindingSource;
            this.dealerDataGridView.Location = new System.Drawing.Point(9, 125);
            this.dealerDataGridView.Name = "dealerDataGridView";
            this.dealerDataGridView.RowHeadersWidth = 51;
            this.dealerDataGridView.RowTemplate.Height = 24;
            this.dealerDataGridView.Size = new System.Drawing.Size(1353, 599);
            this.dealerDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "id_dealer";
            this.dataGridViewTextBoxColumn27.HeaderText = "id_dealer";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 125;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "name_dealer";
            this.dataGridViewTextBoxColumn28.HeaderText = "name_dealer";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 125;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn29.HeaderText = "address";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 125;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "telephone";
            this.dataGridViewTextBoxColumn30.HeaderText = "telephone";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 125;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.used_carDataSet;
            // 
            // modelDataGridView
            // 
            this.modelDataGridView.AutoGenerateColumns = false;
            this.modelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33});
            this.modelDataGridView.DataSource = this.modelBindingSource;
            this.modelDataGridView.Location = new System.Drawing.Point(9, 125);
            this.modelDataGridView.Name = "modelDataGridView";
            this.modelDataGridView.RowHeadersWidth = 51;
            this.modelDataGridView.RowTemplate.Height = 24;
            this.modelDataGridView.Size = new System.Drawing.Size(1353, 599);
            this.modelDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "model_name";
            this.dataGridViewTextBoxColumn31.HeaderText = "model_name";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 125;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "id_carcase";
            this.dataGridViewTextBoxColumn32.HeaderText = "id_carcase";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 125;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "id_brand";
            this.dataGridViewTextBoxColumn33.HeaderText = "id_brand";
            this.dataGridViewTextBoxColumn33.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 125;
            // 
            // photo_carBindingSource
            // 
            this.photo_carBindingSource.DataMember = "Photo_car";
            this.photo_carBindingSource.DataSource = this.used_carDataSet;
            // 
            // photo_carDataGridView
            // 
            this.photo_carDataGridView.AutoGenerateColumns = false;
            this.photo_carDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photo_carDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn34});
            this.photo_carDataGridView.DataSource = this.photo_carBindingSource;
            this.photo_carDataGridView.Location = new System.Drawing.Point(9, 125);
            this.photo_carDataGridView.Name = "photo_carDataGridView";
            this.photo_carDataGridView.RowHeadersWidth = 51;
            this.photo_carDataGridView.RowTemplate.Height = 24;
            this.photo_carDataGridView.Size = new System.Drawing.Size(1353, 599);
            this.photo_carDataGridView.TabIndex = 11;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "photo";
            this.dataGridViewImageColumn1.HeaderText = "photo";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "id_lot";
            this.dataGridViewTextBoxColumn34.HeaderText = "id_lot";
            this.dataGridViewTextBoxColumn34.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Width = 125;
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataMember = "State";
            this.stateBindingSource.DataSource = this.used_carDataSet;
            // 
            // stateDataGridView
            // 
            this.stateDataGridView.AutoGenerateColumns = false;
            this.stateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36});
            this.stateDataGridView.DataSource = this.stateBindingSource;
            this.stateDataGridView.Location = new System.Drawing.Point(9, 125);
            this.stateDataGridView.Name = "stateDataGridView";
            this.stateDataGridView.RowHeadersWidth = 51;
            this.stateDataGridView.RowTemplate.Height = 24;
            this.stateDataGridView.Size = new System.Drawing.Size(1353, 599);
            this.stateDataGridView.TabIndex = 12;
            this.stateDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.stateDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "state_description";
            this.dataGridViewTextBoxColumn35.HeaderText = "state_description";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Width = 125;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "id_lot";
            this.dataGridViewTextBoxColumn36.HeaderText = "id_lot";
            this.dataGridViewTextBoxColumn36.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_lot";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_lot";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_carcase";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_carcase";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "year_issue";
            this.dataGridViewTextBoxColumn5.HeaderText = "year_issue";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "mileage";
            this.dataGridViewTextBoxColumn6.HeaderText = "mileage";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn7.HeaderText = "price";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn8.HeaderText = "color";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "type_engine";
            this.dataGridViewTextBoxColumn9.HeaderText = "type_engine";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fuel_type";
            this.dataGridViewTextBoxColumn10.HeaderText = "fuel_type";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "date_issue";
            this.dataGridViewTextBoxColumn11.HeaderText = "date_issue";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "availability";
            this.dataGridViewTextBoxColumn12.HeaderText = "availability";
            this.dataGridViewTextBoxColumn12.Items.AddRange(new object[] {
            "в наличии",
            "продано"});
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "model_name";
            this.dataGridViewTextBoxColumn13.HeaderText = "model_name";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "engine_capacity";
            this.dataGridViewTextBoxColumn14.HeaderText = "engine_capacity";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1374, 736);
            this.Controls.Add(this.stateDataGridView);
            this.Controls.Add(this.photo_carDataGridView);
            this.Controls.Add(this.modelDataGridView);
            this.Controls.Add(this.dealerDataGridView);
            this.Controls.Add(this.contractDataGridView);
            this.Controls.Add(this.clientDataGridView);
            this.Controls.Add(this.carcaseDataGridView);
            this.Controls.Add(this.carDataGridView);
            this.Controls.Add(this.brandDataGridView);
            this.Controls.Add(this.BindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseTableCB);
            this.Controls.Add(this.panel1);
            this.Name = "TablesForm";
            this.Text = "TablesForm";
            this.Load += new System.EventHandler(this.TablesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.used_carDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).EndInit();
            this.BindingNavigator.ResumeLayout(false);
            this.BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carcaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carcaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_carDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseTableCB;
        private System.Windows.Forms.Label label2;
        private Used_carDataSet used_carDataSet;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private Used_carDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private Used_carDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton brandBindingNavigatorSaveItem;
        private Used_carDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridView brandDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource carBindingSource;
        private Used_carDataSetTableAdapters.CarcaseTableAdapter carcaseTableAdapter;
        private System.Windows.Forms.DataGridView carDataGridView;
        private System.Windows.Forms.BindingSource carcaseBindingSource;
        private Used_carDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridView carcaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Used_carDataSetTableAdapters.ContractTableAdapter contractTableAdapter;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private Used_carDataSetTableAdapters.DealerTableAdapter dealerTableAdapter;
        private System.Windows.Forms.DataGridView contractDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.BindingSource dealerBindingSource;
        private Used_carDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.DataGridView dealerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private Used_carDataSetTableAdapters.Photo_carTableAdapter photo_carTableAdapter;
        private System.Windows.Forms.DataGridView modelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.BindingSource photo_carBindingSource;
        private Used_carDataSetTableAdapters.StateTableAdapter stateTableAdapter;
        private System.Windows.Forms.DataGridView photo_carDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.DataGridView stateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}