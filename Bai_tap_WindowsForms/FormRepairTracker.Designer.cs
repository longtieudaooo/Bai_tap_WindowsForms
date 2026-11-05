namespace Bai_tap_WindowsForms
{
    partial class FormRepairTracker
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
            this.components = new System.ComponentModel.Container();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();

            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.cboDeviceType = new System.Windows.Forms.ComboBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtFaultDesc = new System.Windows.Forms.TextBox();
            this.picDevice = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();

            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();

            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lblStatusCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalCost = new System.Windows.Forms.ToolStripStatusLabel();

            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.sfdCsv = new System.Windows.Forms.SaveFileDialog();

            this.msMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).BeginInit();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuFile });
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Size = new System.Drawing.Size(960, 24);
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuExportCsv, this.menuExit });
            this.menuFile.Text = "Tệp tin";
            this.menuExportCsv.Text = "Xuất danh sách ra CSV";
            this.menuExit.Text = "Thoát ứng dụng";

            this.grpInput.Controls.Add(this.btnChooseImage);
            this.grpInput.Controls.Add(this.picDevice);
            this.grpInput.Controls.Add(this.txtFaultDesc);
            this.grpInput.Controls.Add(this.lblDesc);
            this.grpInput.Controls.Add(this.dtpReceivedDate);
            this.grpInput.Controls.Add(this.lblDate);
            this.grpInput.Controls.Add(this.cboStatus);
            this.grpInput.Controls.Add(this.lblStatus);
            this.grpInput.Controls.Add(this.txtCost);
            this.grpInput.Controls.Add(this.lblCost);
            this.grpInput.Controls.Add(this.cboDeviceType);
            this.grpInput.Controls.Add(this.lblDeviceType);
            this.grpInput.Controls.Add(this.txtPhone);
            this.grpInput.Controls.Add(this.lblPhone);
            this.grpInput.Controls.Add(this.txtCustomerName);
            this.grpInput.Controls.Add(this.lblCustomerName);
            this.grpInput.Controls.Add(this.txtOrderId);
            this.grpInput.Controls.Add(this.lblOrderId);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Location = new System.Drawing.Point(0, 24);
            this.grpInput.Size = new System.Drawing.Size(960, 180);
            this.grpInput.Text = "Thông Tin Đơn Sửa Chữa";

            this.lblOrderId.Location = new System.Drawing.Point(15, 25); this.lblOrderId.Text = "Mã đơn:";
            this.txtOrderId.Location = new System.Drawing.Point(90, 22); this.txtOrderId.Size = new System.Drawing.Size(160, 23);

            this.lblCustomerName.Location = new System.Drawing.Point(270, 25); this.lblCustomerName.Text = "Khách hàng:";
            this.txtCustomerName.Location = new System.Drawing.Point(350, 22); this.txtCustomerName.Size = new System.Drawing.Size(180, 23);

            this.lblPhone.Location = new System.Drawing.Point(550, 25); this.lblPhone.Text = "SĐT:";
            this.txtPhone.Location = new System.Drawing.Point(600, 22); this.txtPhone.Size = new System.Drawing.Size(160, 23);

            this.lblDeviceType.Location = new System.Drawing.Point(15, 60); this.lblDeviceType.Text = "Thiết bị:";
            this.cboDeviceType.Location = new System.Drawing.Point(90, 57); this.cboDeviceType.Size = new System.Drawing.Size(160, 23); this.cboDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblCost.Location = new System.Drawing.Point(270, 60); this.lblCost.Text = "Chi phí dự kiến:";
            this.txtCost.Location = new System.Drawing.Point(350, 57); this.txtCost.Size = new System.Drawing.Size(180, 23);

            this.lblStatus.Location = new System.Drawing.Point(550, 60); this.lblStatus.Text = "Trạng thái:";
            this.cboStatus.Location = new System.Drawing.Point(600, 57); this.cboStatus.Size = new System.Drawing.Size(160, 23); this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblDate.Location = new System.Drawing.Point(15, 95); this.lblDate.Text = "Ngày nhận:";
            this.dtpReceivedDate.Location = new System.Drawing.Point(90, 92); this.dtpReceivedDate.Size = new System.Drawing.Size(160, 23); this.dtpReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblDesc.Location = new System.Drawing.Point(270, 95); this.lblDesc.Text = "Mô tả lỗi:";
            this.txtFaultDesc.Location = new System.Drawing.Point(350, 92); this.txtFaultDesc.Size = new System.Drawing.Size(410, 65); this.txtFaultDesc.Multiline = true;

            this.picDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDevice.Location = new System.Drawing.Point(780, 22);
            this.picDevice.Size = new System.Drawing.Size(160, 110);
            this.picDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnChooseImage.Location = new System.Drawing.Point(780, 137);
            this.btnChooseImage.Size = new System.Drawing.Size(160, 28);
            this.btnChooseImage.Text = "Chọn ảnh thiết bị";

            this.pnlActions.Controls.Add(this.cboFilterStatus);
            this.pnlActions.Controls.Add(this.lblFilterStatus);
            this.pnlActions.Controls.Add(this.txtSearch);
            this.pnlActions.Controls.Add(this.lblSearch);
            this.pnlActions.Controls.Add(this.btnClear);
            this.pnlActions.Controls.Add(this.btnDelete);
            this.pnlActions.Controls.Add(this.btnUpdate);
            this.pnlActions.Controls.Add(this.btnAdd);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 204);
            this.pnlActions.Size = new System.Drawing.Size(960, 45);

            this.btnAdd.Location = new System.Drawing.Point(12, 8); this.btnAdd.Size = new System.Drawing.Size(80, 30); this.btnAdd.Text = "Thêm";
            this.btnUpdate.Location = new System.Drawing.Point(98, 8); this.btnUpdate.Size = new System.Drawing.Size(80, 30); this.btnUpdate.Text = "Sửa";
            this.btnDelete.Location = new System.Drawing.Point(184, 8); this.btnDelete.Size = new System.Drawing.Size(80, 30); this.btnDelete.Text = "Xóa";
            this.btnClear.Location = new System.Drawing.Point(270, 8); this.btnClear.Size = new System.Drawing.Size(80, 30); this.btnClear.Text = "Làm mới";

            this.lblSearch.Location = new System.Drawing.Point(370, 13); this.lblSearch.Text = "Tìm kiếm:"; this.lblSearch.AutoSize = true;
            this.txtSearch.Location = new System.Drawing.Point(435, 10); this.txtSearch.Size = new System.Drawing.Size(150, 23);
            this.lblFilterStatus.Location = new System.Drawing.Point(600, 13); this.lblFilterStatus.Text = "Lọc trạng thái:"; this.lblFilterStatus.AutoSize = true;
            this.cboFilterStatus.Location = new System.Drawing.Point(690, 10); this.cboFilterStatus.Size = new System.Drawing.Size(140, 23); this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 249);
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(960, 280);

            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatusCount, this.lblTotalCost });
            this.ssMain.Location = new System.Drawing.Point(0, 529);
            this.ssMain.Size = new System.Drawing.Size(960, 22);

            this.lblStatusCount.Text = "Số đơn hiển thị: 0 | ";
            this.lblTotalCost.Text = "Tổng chi phí dự kiến (Chưa hoàn tất): 0 VNĐ";

            this.ClientSize = new System.Drawing.Size(960, 551);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.msMain);
            this.Name = "FormRepairTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Service Tracker - Quản Lý Đơn Sửa Chữa";
            this.Load += new System.EventHandler(this.FormRepairTracker_Load);

            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile, menuExportCsv, menuExit;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblOrderId, lblCustomerName, lblPhone, lblDeviceType, lblCost, lblStatus, lblDate, lblDesc;
        private System.Windows.Forms.TextBox txtOrderId, txtCustomerName, txtPhone, txtCost, txtFaultDesc;
        private System.Windows.Forms.ComboBox cboDeviceType, cboStatus;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.PictureBox picDevice;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch, lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCount, lblTotalCost;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.SaveFileDialog sfdCsv;
    }
}