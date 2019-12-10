namespace databaseConnect
{
    partial class Form4
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
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label attendenceLabel;
            System.Windows.Forms.Label tutorialLabel;
            System.Windows.Forms.Label theoryLabel;
            System.Windows.Forms.Label vivaVoceLabel;
            System.Windows.Forms.Label departmentIDLabel;
            System.Windows.Forms.Label examTypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.departmentManagementSystemDataSet = new databaseConnect.DepartmentManagementSystemDataSet();
            this.performancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performancesTableAdapter = new databaseConnect.DepartmentManagementSystemDataSetTableAdapters.PerformancesTableAdapter();
            this.tableAdapterManager = new databaseConnect.DepartmentManagementSystemDataSetTableAdapters.TableAdapterManager();
            this.performancesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.performancesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.attendenceTextBox = new System.Windows.Forms.TextBox();
            this.tutorialTextBox = new System.Windows.Forms.TextBox();
            this.theoryTextBox = new System.Windows.Forms.TextBox();
            this.vivaVoceTextBox = new System.Windows.Forms.TextBox();
            this.departmentIDTextBox = new System.Windows.Forms.TextBox();
            this.examTypeTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.performancesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            studentIDLabel = new System.Windows.Forms.Label();
            attendenceLabel = new System.Windows.Forms.Label();
            tutorialLabel = new System.Windows.Forms.Label();
            theoryLabel = new System.Windows.Forms.Label();
            vivaVoceLabel = new System.Windows.Forms.Label();
            departmentIDLabel = new System.Windows.Forms.Label();
            examTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.departmentManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingNavigator)).BeginInit();
            this.performancesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performancesDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentIDLabel.Location = new System.Drawing.Point(19, 63);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(102, 20);
            studentIDLabel.TabIndex = 1;
            studentIDLabel.Text = "Student ID:";
            // 
            // attendenceLabel
            // 
            attendenceLabel.AutoSize = true;
            attendenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            attendenceLabel.Location = new System.Drawing.Point(19, 99);
            attendenceLabel.Name = "attendenceLabel";
            attendenceLabel.Size = new System.Drawing.Size(107, 20);
            attendenceLabel.TabIndex = 3;
            attendenceLabel.Text = "Attendence:";
            // 
            // tutorialLabel
            // 
            tutorialLabel.AutoSize = true;
            tutorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tutorialLabel.Location = new System.Drawing.Point(19, 137);
            tutorialLabel.Name = "tutorialLabel";
            tutorialLabel.Size = new System.Drawing.Size(74, 20);
            tutorialLabel.TabIndex = 5;
            tutorialLabel.Text = "Tutorial:";
            // 
            // theoryLabel
            // 
            theoryLabel.AutoSize = true;
            theoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            theoryLabel.Location = new System.Drawing.Point(374, 62);
            theoryLabel.Name = "theoryLabel";
            theoryLabel.Size = new System.Drawing.Size(68, 20);
            theoryLabel.TabIndex = 7;
            theoryLabel.Text = "Theory:";
            // 
            // vivaVoceLabel
            // 
            vivaVoceLabel.AutoSize = true;
            vivaVoceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vivaVoceLabel.Location = new System.Drawing.Point(374, 101);
            vivaVoceLabel.Name = "vivaVoceLabel";
            vivaVoceLabel.Size = new System.Drawing.Size(94, 20);
            vivaVoceLabel.TabIndex = 9;
            vivaVoceLabel.Text = "Viva Voce:";
            // 
            // departmentIDLabel
            // 
            departmentIDLabel.AutoSize = true;
            departmentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentIDLabel.Location = new System.Drawing.Point(374, 137);
            departmentIDLabel.Name = "departmentIDLabel";
            departmentIDLabel.Size = new System.Drawing.Size(133, 20);
            departmentIDLabel.TabIndex = 11;
            departmentIDLabel.Text = "Department ID:";
            // 
            // examTypeLabel
            // 
            examTypeLabel.AutoSize = true;
            examTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            examTypeLabel.Location = new System.Drawing.Point(374, 176);
            examTypeLabel.Name = "examTypeLabel";
            examTypeLabel.Size = new System.Drawing.Size(101, 20);
            examTypeLabel.TabIndex = 13;
            examTypeLabel.Text = "Exam Type:";
            // 
            // departmentManagementSystemDataSet
            // 
            this.departmentManagementSystemDataSet.DataSetName = "DepartmentManagementSystemDataSet";
            this.departmentManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // performancesBindingSource
            // 
            this.performancesBindingSource.DataMember = "Performances";
            this.performancesBindingSource.DataSource = this.departmentManagementSystemDataSet;
            // 
            // performancesTableAdapter
            // 
            this.performancesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.PerformancesTableAdapter = this.performancesTableAdapter;
            this.tableAdapterManager.StudentCourseTableAdapter = null;
            this.tableAdapterManager.StudentsInfoTableAdapter = null;
            this.tableAdapterManager.TeachersInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = databaseConnect.DepartmentManagementSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // performancesBindingNavigator
            // 
            this.performancesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.performancesBindingNavigator.BindingSource = this.performancesBindingSource;
            this.performancesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.performancesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.performancesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.performancesBindingNavigatorSaveItem});
            this.performancesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.performancesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.performancesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.performancesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.performancesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.performancesBindingNavigator.Name = "performancesBindingNavigator";
            this.performancesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.performancesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.performancesBindingNavigator.TabIndex = 0;
            this.performancesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // performancesBindingNavigatorSaveItem
            // 
            this.performancesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.performancesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("performancesBindingNavigatorSaveItem.Image")));
            this.performancesBindingNavigatorSaveItem.Name = "performancesBindingNavigatorSaveItem";
            this.performancesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.performancesBindingNavigatorSaveItem.Text = "Save Data";
            this.performancesBindingNavigatorSaveItem.Click += new System.EventHandler(this.performancesBindingNavigatorSaveItem_Click);
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "StudentID", true));
            this.studentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTextBox.Location = new System.Drawing.Point(158, 63);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.studentIDTextBox.TabIndex = 2;
            // 
            // attendenceTextBox
            // 
            this.attendenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "Attendence", true));
            this.attendenceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendenceTextBox.Location = new System.Drawing.Point(158, 99);
            this.attendenceTextBox.Name = "attendenceTextBox";
            this.attendenceTextBox.Size = new System.Drawing.Size(200, 26);
            this.attendenceTextBox.TabIndex = 4;
            // 
            // tutorialTextBox
            // 
            this.tutorialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "Tutorial", true));
            this.tutorialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialTextBox.Location = new System.Drawing.Point(158, 137);
            this.tutorialTextBox.Name = "tutorialTextBox";
            this.tutorialTextBox.Size = new System.Drawing.Size(200, 26);
            this.tutorialTextBox.TabIndex = 6;
            // 
            // theoryTextBox
            // 
            this.theoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "Theory", true));
            this.theoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theoryTextBox.Location = new System.Drawing.Point(513, 62);
            this.theoryTextBox.Name = "theoryTextBox";
            this.theoryTextBox.Size = new System.Drawing.Size(200, 26);
            this.theoryTextBox.TabIndex = 8;
            // 
            // vivaVoceTextBox
            // 
            this.vivaVoceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "VivaVoce", true));
            this.vivaVoceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vivaVoceTextBox.Location = new System.Drawing.Point(513, 101);
            this.vivaVoceTextBox.Name = "vivaVoceTextBox";
            this.vivaVoceTextBox.Size = new System.Drawing.Size(200, 26);
            this.vivaVoceTextBox.TabIndex = 10;
            // 
            // departmentIDTextBox
            // 
            this.departmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "DepartmentID", true));
            this.departmentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentIDTextBox.Location = new System.Drawing.Point(513, 137);
            this.departmentIDTextBox.Name = "departmentIDTextBox";
            this.departmentIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.departmentIDTextBox.TabIndex = 12;
            // 
            // examTypeTextBox
            // 
            this.examTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "ExamType", true));
            this.examTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTypeTextBox.Location = new System.Drawing.Point(513, 176);
            this.examTypeTextBox.Name = "examTypeTextBox";
            this.examTypeTextBox.Size = new System.Drawing.Size(200, 26);
            this.examTypeTextBox.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 119);
            this.panel1.TabIndex = 15;
            // 
            // performancesDataGridView
            // 
            this.performancesDataGridView.AutoGenerateColumns = false;
            this.performancesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.performancesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.performancesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.performancesDataGridView.DataSource = this.performancesBindingSource;
            this.performancesDataGridView.Location = new System.Drawing.Point(23, 311);
            this.performancesDataGridView.Name = "performancesDataGridView";
            this.performancesDataGridView.Size = new System.Drawing.Size(746, 119);
            this.performancesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Attendence";
            this.dataGridViewTextBoxColumn2.HeaderText = "Attendence";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tutorial";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tutorial";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Theory";
            this.dataGridViewTextBoxColumn4.HeaderText = "Theory";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VivaVoce";
            this.dataGridViewTextBoxColumn5.HeaderText = "VivaVoce";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DepartmentID";
            this.dataGridViewTextBoxColumn6.HeaderText = "DepartmentID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ExamType";
            this.dataGridViewTextBoxColumn7.HeaderText = "ExamType";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(506, 25);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 29);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(403, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(300, 25);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(94, 29);
            this.btnnext.TabIndex = 9;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.Location = new System.Drawing.Point(196, 25);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(94, 29);
            this.btnprevious.TabIndex = 8;
            this.btnprevious.Text = "Previous";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(110, 25);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(79, 29);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(24, 25);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(79, 29);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnnext);
            this.panel2.Controls.Add(this.btnprevious);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Location = new System.Drawing.Point(89, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 71);
            this.panel2.TabIndex = 16;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.performancesDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(attendenceLabel);
            this.Controls.Add(this.attendenceTextBox);
            this.Controls.Add(tutorialLabel);
            this.Controls.Add(this.tutorialTextBox);
            this.Controls.Add(theoryLabel);
            this.Controls.Add(this.theoryTextBox);
            this.Controls.Add(vivaVoceLabel);
            this.Controls.Add(this.vivaVoceTextBox);
            this.Controls.Add(departmentIDLabel);
            this.Controls.Add(this.departmentIDTextBox);
            this.Controls.Add(examTypeLabel);
            this.Controls.Add(this.examTypeTextBox);
            this.Controls.Add(this.performancesBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingNavigator)).EndInit();
            this.performancesBindingNavigator.ResumeLayout(false);
            this.performancesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performancesDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DepartmentManagementSystemDataSet departmentManagementSystemDataSet;
        private System.Windows.Forms.BindingSource performancesBindingSource;
        private DepartmentManagementSystemDataSetTableAdapters.PerformancesTableAdapter performancesTableAdapter;
        private DepartmentManagementSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator performancesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton performancesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox attendenceTextBox;
        private System.Windows.Forms.TextBox tutorialTextBox;
        private System.Windows.Forms.TextBox theoryTextBox;
        private System.Windows.Forms.TextBox vivaVoceTextBox;
        private System.Windows.Forms.TextBox departmentIDTextBox;
        private System.Windows.Forms.TextBox examTypeTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView performancesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel2;
    }
}