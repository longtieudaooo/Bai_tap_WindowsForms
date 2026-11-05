namespace Bai_tap_WindowsForms
{
    partial class FormAppointment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            msMain = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuExportCsv = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            tblLayoutInput = new TableLayoutPanel();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblDoctor = new Label();
            cboDoctor = new ComboBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblReason = new Label();
            txtReason = new TextBox();
            pnlActions = new Panel();
            lblFilterStatus = new Label();
            cboFilterStatus = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvAppointments = new DataGridView();
            ssMain = new StatusStrip();
            lblStatusCount = new ToolStripStatusLabel();
            errorProvider = new ErrorProvider(components);
            sfdCsv = new SaveFileDialog();
            msMain.SuspendLayout();
            tblLayoutInput.SuspendLayout();
            pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.Items.AddRange(new ToolStripItem[] { menuFile });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(950, 24);
            msMain.TabIndex = 4;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuExportCsv, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(56, 20);
            menuFile.Text = "Tệp tin";
            // 
            // menuExportCsv
            // 
            menuExportCsv.Name = "menuExportCsv";
            menuExportCsv.Size = new Size(192, 22);
            menuExportCsv.Text = "Xuất danh sách ra CSV";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(192, 22);
            menuExit.Text = "Thoát";
            // 
            // tblLayoutInput
            // 
            tblLayoutInput.ColumnCount = 4;
            tblLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tblLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tblLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayoutInput.Controls.Add(lblId, 0, 0);
            tblLayoutInput.Controls.Add(txtId, 1, 0);
            tblLayoutInput.Controls.Add(lblName, 2, 0);
            tblLayoutInput.Controls.Add(txtName, 3, 0);
            tblLayoutInput.Controls.Add(lblPhone, 0, 1);
            tblLayoutInput.Controls.Add(txtPhone, 1, 1);
            tblLayoutInput.Controls.Add(lblDate, 2, 1);
            tblLayoutInput.Controls.Add(dtpDate, 3, 1);
            tblLayoutInput.Controls.Add(lblDoctor, 0, 2);
            tblLayoutInput.Controls.Add(cboDoctor, 1, 2);
            tblLayoutInput.Controls.Add(lblStatus, 2, 2);
            tblLayoutInput.Controls.Add(cboStatus, 3, 2);
            tblLayoutInput.Controls.Add(lblReason, 0, 3);
            tblLayoutInput.Controls.Add(txtReason, 1, 3);
            tblLayoutInput.Dock = DockStyle.Top;
            tblLayoutInput.Location = new Point(0, 24);
            tblLayoutInput.Name = "tblLayoutInput";
            tblLayoutInput.Padding = new Padding(10);
            tblLayoutInput.RowCount = 4;
            tblLayoutInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblLayoutInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblLayoutInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblLayoutInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblLayoutInput.Size = new Size(950, 155);
            tblLayoutInput.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left;
            lblId.Location = new Point(13, 16);
            lblId.Name = "lblId";
            lblId.Size = new Size(94, 23);
            lblId.TabIndex = 0;
            lblId.Text = "Mã lịch hẹn:";
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(113, 13);
            txtId.Name = "txtId";
            txtId.Size = new Size(359, 23);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.Location = new Point(478, 16);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Bệnh nhân:";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(578, 13);
            txtName.Name = "txtName";
            txtName.Size = new Size(359, 23);
            txtName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Left;
            lblPhone.Location = new Point(13, 51);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(94, 23);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(113, 48);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(359, 23);
            txtPhone.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.Location = new Point(478, 51);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(94, 23);
            lblDate.TabIndex = 6;
            lblDate.Text = "Ngày giờ hẹn:";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(578, 48);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(359, 23);
            dtpDate.TabIndex = 7;
            // 
            // lblDoctor
            // 
            lblDoctor.Anchor = AnchorStyles.Left;
            lblDoctor.Location = new Point(13, 86);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(94, 23);
            lblDoctor.TabIndex = 8;
            lblDoctor.Text = "Bác sĩ:";
            // 
            // cboDoctor
            // 
            cboDoctor.Dock = DockStyle.Fill;
            cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoctor.Location = new Point(113, 83);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(359, 23);
            cboDoctor.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.Location = new Point(478, 86);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 23);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Trạng thái:";
            // 
            // cboStatus
            // 
            cboStatus.Dock = DockStyle.Fill;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Location = new Point(578, 83);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(359, 23);
            cboStatus.TabIndex = 11;
            // 
            // lblReason
            // 
            lblReason.Anchor = AnchorStyles.Left;
            lblReason.Location = new Point(13, 121);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(94, 23);
            lblReason.TabIndex = 12;
            lblReason.Text = "Lý do khám:";
            // 
            // txtReason
            // 
            tblLayoutInput.SetColumnSpan(txtReason, 3);
            txtReason.Dock = DockStyle.Fill;
            txtReason.Location = new Point(113, 118);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(824, 23);
            txtReason.TabIndex = 13;
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(lblFilterStatus);
            pnlActions.Controls.Add(cboFilterStatus);
            pnlActions.Controls.Add(lblSearch);
            pnlActions.Controls.Add(txtSearch);
            pnlActions.Controls.Add(btnClear);
            pnlActions.Controls.Add(btnDelete);
            pnlActions.Controls.Add(btnUpdate);
            pnlActions.Controls.Add(btnAdd);
            pnlActions.Dock = DockStyle.Top;
            pnlActions.Location = new Point(0, 179);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(950, 45);
            pnlActions.TabIndex = 2;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Location = new Point(615, 13);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(83, 15);
            lblFilterStatus.TabIndex = 0;
            lblFilterStatus.Text = "Lọc trạng thái:";
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.Location = new Point(705, 10);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(140, 23);
            cboFilterStatus.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(370, 13);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(60, 15);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(435, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(160, 23);
            txtSearch.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(270, 8);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 30);
            btnClear.TabIndex = 4;
            btnClear.Text = "Làm mới";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(184, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(98, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 30);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Sửa";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            // 
            // dgvAppointments
            // 
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(0, 224);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(950, 300);
            dgvAppointments.TabIndex = 0;
            // 
            // ssMain
            // 
            ssMain.Items.AddRange(new ToolStripItem[] { lblStatusCount });
            ssMain.Location = new Point(0, 524);
            ssMain.Name = "ssMain";
            ssMain.Size = new Size(950, 22);
            ssMain.TabIndex = 1;
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(180, 17);
            lblStatusCount.Text = "Tổng số lịch hẹn đang hiển thị: 0";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAppointment
            // 
            ClientSize = new Size(950, 546);
            Controls.Add(dgvAppointments);
            Controls.Add(ssMain);
            Controls.Add(pnlActions);
            Controls.Add(tblLayoutInput);
            Controls.Add(msMain);
            Name = "FormAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Appointment Manager - Quản Lý Lịch Hẹn";
            Load += FormAppointment_Load;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            tblLayoutInput.ResumeLayout(false);
            tblLayoutInput.PerformLayout();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ssMain.ResumeLayout(false);
            ssMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExportCsv;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.TableLayoutPanel tblLayoutInput;
        private System.Windows.Forms.Label lblId, lblName, lblPhone, lblDate, lblDoctor, lblStatus, lblReason;
        private System.Windows.Forms.TextBox txtId, txtName, txtPhone, txtReason;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboDoctor, cboStatus;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch, lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCount;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdCsv;
    }
}