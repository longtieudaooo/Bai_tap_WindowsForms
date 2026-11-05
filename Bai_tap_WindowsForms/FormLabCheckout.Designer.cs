namespace Bai_tap_WindowsForms
{
    partial class FormLabCheckout
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.txtTicketId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.cboEquipment = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblCheckoutDate = new System.Windows.Forms.Label();
            this.dtpCheckoutDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.chkReturned = new System.Windows.Forms.CheckBox();

            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMarkReturned = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.btnExportCsv = new System.Windows.Forms.Button();

            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lblStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdCsv = new System.Windows.Forms.SaveFileDialog();

            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            this.grpInput.Controls.Add(this.chkReturned);
            this.grpInput.Controls.Add(this.dtpReturnDate);
            this.grpInput.Controls.Add(this.lblReturnDate);
            this.grpInput.Controls.Add(this.dtpDueDate);
            this.grpInput.Controls.Add(this.lblDueDate);
            this.grpInput.Controls.Add(this.dtpCheckoutDate);
            this.grpInput.Controls.Add(this.lblCheckoutDate);
            this.grpInput.Controls.Add(this.nudQuantity);
            this.grpInput.Controls.Add(this.lblQuantity);
            this.grpInput.Controls.Add(this.cboEquipment);
            this.grpInput.Controls.Add(this.lblEquipment);
            this.grpInput.Controls.Add(this.txtStudentName);
            this.grpInput.Controls.Add(this.lblStudentName);
            this.grpInput.Controls.Add(this.txtStudentId);
            this.grpInput.Controls.Add(this.lblStudentId);
            this.grpInput.Controls.Add(this.txtTicketId);
            this.grpInput.Controls.Add(this.lblTicketId);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Location = new System.Drawing.Point(0, 0);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(920, 160);
            this.grpInput.TabIndex = 0;
            this.grpInput.Text = "Thông Tin Phiếu Mượn";

            this.lblTicketId.Location = new System.Drawing.Point(15, 25); this.lblTicketId.Text = "Mã phiếu:";
            this.txtTicketId.Location = new System.Drawing.Point(90, 22); this.txtTicketId.Size = new System.Drawing.Size(180, 23);

            this.lblStudentId.Location = new System.Drawing.Point(300, 25); this.lblStudentId.Text = "Mã SV:";
            this.txtStudentId.Location = new System.Drawing.Point(380, 22); this.txtStudentId.Size = new System.Drawing.Size(180, 23);

            this.lblStudentName.Location = new System.Drawing.Point(590, 25); this.lblStudentName.Text = "Họ tên SV:";
            this.txtStudentName.Location = new System.Drawing.Point(670, 22); this.txtStudentName.Size = new System.Drawing.Size(220, 23);

            this.lblEquipment.Location = new System.Drawing.Point(15, 60); this.lblEquipment.Text = "Thiết bị:";
            this.cboEquipment.Location = new System.Drawing.Point(90, 57); this.cboEquipment.Size = new System.Drawing.Size(180, 23); this.cboEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblQuantity.Location = new System.Drawing.Point(300, 60); this.lblQuantity.Text = "Số lượng:";
            this.nudQuantity.Location = new System.Drawing.Point(380, 57); this.nudQuantity.Size = new System.Drawing.Size(180, 23); this.nudQuantity.Minimum = 1; this.nudQuantity.Value = 1;

            this.lblCheckoutDate.Location = new System.Drawing.Point(590, 60); this.lblCheckoutDate.Text = "Ngày mượn:";
            this.dtpCheckoutDate.Location = new System.Drawing.Point(670, 57); this.dtpCheckoutDate.Size = new System.Drawing.Size(220, 23); this.dtpCheckoutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblDueDate.Location = new System.Drawing.Point(15, 95); this.lblDueDate.Text = "Hạn trả:";
            this.dtpDueDate.Location = new System.Drawing.Point(90, 92); this.dtpDueDate.Size = new System.Drawing.Size(180, 23); this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblReturnDate.Location = new System.Drawing.Point(300, 95); this.lblReturnDate.Text = "Ngày trả:";
            this.dtpReturnDate.Location = new System.Drawing.Point(380, 92); this.dtpReturnDate.Size = new System.Drawing.Size(180, 23); this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpReturnDate.Enabled = false;

            this.chkReturned.Location = new System.Drawing.Point(590, 93); this.chkReturned.Text = "Đã trả thiết bị";

            this.pnlActions.Controls.Add(this.btnExportCsv);
            this.pnlActions.Controls.Add(this.cboFilterStatus);
            this.pnlActions.Controls.Add(this.lblFilterStatus);
            this.pnlActions.Controls.Add(this.txtSearch);
            this.pnlActions.Controls.Add(this.lblSearch);
            this.pnlActions.Controls.Add(this.btnMarkReturned);
            this.pnlActions.Controls.Add(this.btnDelete);
            this.pnlActions.Controls.Add(this.btnUpdate);
            this.pnlActions.Controls.Add(this.btnAdd);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 160);
            this.pnlActions.Size = new System.Drawing.Size(920, 45);

            this.btnAdd.Location = new System.Drawing.Point(12, 8); this.btnAdd.Size = new System.Drawing.Size(75, 30); this.btnAdd.Text = "Thêm";
            this.btnUpdate.Location = new System.Drawing.Point(93, 8); this.btnUpdate.Size = new System.Drawing.Size(75, 30); this.btnUpdate.Text = "Sửa";
            this.btnDelete.Location = new System.Drawing.Point(174, 8); this.btnDelete.Size = new System.Drawing.Size(75, 30); this.btnDelete.Text = "Xóa";
            this.btnMarkReturned.Location = new System.Drawing.Point(255, 8); this.btnMarkReturned.Size = new System.Drawing.Size(110, 30); this.btnMarkReturned.Text = "Đánh dấu đã trả";

            this.lblSearch.Location = new System.Drawing.Point(375, 13); this.lblSearch.Text = "Tìm kiếm:"; this.lblSearch.AutoSize = true;
            this.txtSearch.Location = new System.Drawing.Point(435, 10); this.txtSearch.Size = new System.Drawing.Size(130, 23);
            this.lblFilterStatus.Location = new System.Drawing.Point(575, 13); this.lblFilterStatus.Text = "Lọc:"; this.lblFilterStatus.AutoSize = true;
            this.cboFilterStatus.Location = new System.Drawing.Point(610, 10); this.cboFilterStatus.Size = new System.Drawing.Size(120, 23); this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnExportCsv.Location = new System.Drawing.Point(810, 8); this.btnExportCsv.Size = new System.Drawing.Size(95, 30); this.btnExportCsv.Text = "Xuất CSV";

            this.dgvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTickets.Location = new System.Drawing.Point(0, 205);
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(920, 300);

            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatusText });
            this.ssMain.Location = new System.Drawing.Point(0, 505);
            this.ssMain.Size = new System.Drawing.Size(920, 22);
            this.lblStatusText.Text = "Tổng số phiếu: 0 | Phiếu quá hạn: 0";

            this.ClientSize = new System.Drawing.Size(920, 527);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.grpInput);
            this.Name = "FormLabCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Equipment Checkout - Quản Lý Mượn Trả Thiết Bị";
            this.Load += new System.EventHandler(this.FormLabCheckout_Load);

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblTicketId, lblStudentId, lblStudentName, lblEquipment, lblQuantity, lblCheckoutDate, lblDueDate, lblReturnDate;
        private System.Windows.Forms.TextBox txtTicketId, txtStudentId, txtStudentName;
        private System.Windows.Forms.ComboBox cboEquipment;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DateTimePicker dtpCheckoutDate, dtpDueDate, dtpReturnDate;
        private System.Windows.Forms.CheckBox chkReturned;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnMarkReturned, btnExportCsv;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch, lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusText;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdCsv;
    }
}