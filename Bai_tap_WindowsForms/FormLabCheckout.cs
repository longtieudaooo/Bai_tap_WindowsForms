using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_tap_WindowsForms
{
    public partial class FormLabCheckout : Form
    {
        private BindingList<CheckoutTicket> listTickets = new BindingList<CheckoutTicket>();
        private BindingSource ticketBindingSource = new BindingSource();

        public FormLabCheckout()
        {
            InitializeComponent();
        }

        private void FormLabCheckout_Load(object sender, EventArgs e)
        {
            cboEquipment.Items.AddRange(new object[] { "Oscilloscope Tektronix", "Bộ thực hành Microcontroller", "Máy phát hàm Signal Generator", "Multimeter Fluke" });
            cboEquipment.SelectedIndex = 0;

            cboFilterStatus.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Đã trả", "Quá hạn" });
            cboFilterStatus.SelectedIndex = 0;

            SetupColumns();

            listTickets.Add(new CheckoutTicket("PM01", "SV201201", "Lại Thanh Long", "Oscilloscope Tektronix", 1, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-3), null, "Đang mượn"));
            listTickets.Add(new CheckoutTicket("PM02", "SV201202", "Nguyễn Văn B", "Multimeter Fluke", 2, DateTime.Now.AddDays(-1), DateTime.Now.AddDays(6), null, "Đang mượn"));

            ticketBindingSource.DataSource = listTickets;
            dgvTickets.DataSource = ticketBindingSource;

            dgvTickets.SelectionChanged += DgvTickets_SelectionChanged;
            chkReturned.CheckedChanged += (s, ev) => dtpReturnDate.Enabled = chkReturned.Checked;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnMarkReturned.Click += BtnMarkReturned_Click;
            txtSearch.TextChanged += ApplyFilter;
            cboFilterStatus.SelectedIndexChanged += ApplyFilter;
            btnExportCsv.Click += BtnExportCsv_Click;

            ApplyFilter(null, null);
        }

        private void SetupColumns()
        {
            dgvTickets.AutoGenerateColumns = false;
            dgvTickets.Columns.Clear();
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TicketId", HeaderText = "Mã Phiếu", Width = 80 });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentId", HeaderText = "Mã SV", Width = 90 });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentName", HeaderText = "Họ Tên SV", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EquipmentName", HeaderText = "Thiết Bị", Width = 170 });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "SL", Width = 50 });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CheckoutDate", HeaderText = "Ngày Mượn", Width = 100 });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DueDate", HeaderText = "Hạn Trả", Width = 100 });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ActualReturnDate", HeaderText = "Ngày Trả", Width = 100 });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng Thái", Width = 90 });
        }

        private void DgvTickets_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow?.DataBoundItem is CheckoutTicket selected)
            {
                txtTicketId.Text = selected.TicketId;
                txtStudentId.Text = selected.StudentId;
                txtStudentName.Text = selected.StudentName;
                cboEquipment.Text = selected.EquipmentName;
                nudQuantity.Value = selected.Quantity;
                dtpCheckoutDate.Value = selected.CheckoutDate;
                dtpDueDate.Value = selected.DueDate;

                if (selected.ActualReturnDate.HasValue)
                {
                    chkReturned.Checked = true;
                    dtpReturnDate.Value = selected.ActualReturnDate.Value;
                }
                else
                {
                    chkReturned.Checked = false;
                    dtpReturnDate.Value = DateTime.Now;
                }
            }
        }

        private bool ValidateForm(bool isNew)
        {
            errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtTicketId.Text))
            {
                errorProvider.SetError(txtTicketId, "Mã phiếu không được trống!"); isValid = false;
            }
            else if (isNew && listTickets.Any(t => t.TicketId.Equals(txtTicketId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(txtTicketId, "Mã phiếu bị trùng!"); isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                errorProvider.SetError(txtStudentId, "Mã SV không được trống!"); isValid = false;
            }

            if (dtpDueDate.Value.Date < dtpCheckoutDate.Value.Date)
            {
                errorProvider.SetError(dtpDueDate, "Hạn trả không được trước ngày mượn!"); isValid = false;
            }

            if (chkReturned.Checked && dtpReturnDate.Value.Date < dtpCheckoutDate.Value.Date)
            {
                errorProvider.SetError(dtpReturnDate, "Ngày trả không được trước ngày mượn!"); isValid = false;
            }

            return isValid;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateForm(isNew: true)) return;

            string status = chkReturned.Checked ? "Đã trả" : "Đang mượn";
            DateTime? returnDate = chkReturned.Checked ? dtpReturnDate.Value : null;

            CheckoutTicket ticket = new CheckoutTicket(
                txtTicketId.Text.Trim(), txtStudentId.Text.Trim(), txtStudentName.Text.Trim(),
                cboEquipment.Text, (int)nudQuantity.Value, dtpCheckoutDate.Value, dtpDueDate.Value, returnDate, status
            );

            listTickets.Add(ticket);
            ApplyFilter(null, null);
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow?.DataBoundItem is not CheckoutTicket selected) return;
            if (!ValidateForm(isNew: false)) return;

            selected.StudentId = txtStudentId.Text.Trim();
            selected.StudentName = txtStudentName.Text.Trim();
            selected.EquipmentName = cboEquipment.Text;
            selected.Quantity = (int)nudQuantity.Value;
            selected.CheckoutDate = dtpCheckoutDate.Value;
            selected.DueDate = dtpDueDate.Value;

            if (chkReturned.Checked)
            {
                selected.Status = "Đã trả";
                selected.ActualReturnDate = dtpReturnDate.Value;
            }
            else
            {
                selected.Status = "Đang mượn";
                selected.ActualReturnDate = null;
                selected.CheckOverdue();
            }

            ticketBindingSource.ResetCurrentItem();
            ApplyFilter(null, null);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow?.DataBoundItem is not CheckoutTicket selected) return;
            if (MessageBox.Show($"Xóa phiếu [{selected.TicketId}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listTickets.Remove(selected);
                ApplyFilter(null, null);
            }
        }

        private void BtnMarkReturned_Click(object? sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow?.DataBoundItem is not CheckoutTicket selected) return;
            selected.Status = "Đã trả";
            selected.ActualReturnDate = DateTime.Now;
            chkReturned.Checked = true;
            dtpReturnDate.Value = DateTime.Now;

            ticketBindingSource.ResetCurrentItem();
            ApplyFilter(null, null);
            MessageBox.Show("Đã đánh dấu phiếu mượn là ĐÃ TRẢ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ApplyFilter(object? sender, EventArgs e)
        {
            foreach (var t in listTickets) t.CheckOverdue();

            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.Text;

            var filtered = listTickets.Where(t =>
                (string.IsNullOrEmpty(keyword) || t.StudentId.ToLower().Contains(keyword) || t.EquipmentName.ToLower().Contains(keyword)) &&
                (selectedStatus == "Tất cả" || t.Status == selectedStatus)
            ).ToList();

            ticketBindingSource.DataSource = new BindingList<CheckoutTicket>(filtered);

            int overdueCount = listTickets.Count(t => t.Status == "Quá hạn");
            lblStatusText.Text = $"Tổng số phiếu: {listTickets.Count} | Số phiếu quá hạn: {overdueCount}";
        }

        private void BtnExportCsv_Click(object? sender, EventArgs e)
        {
            sfdCsv.Filter = "File CSV (*.csv)|*.csv";
            sfdCsv.FileName = "DanhSachMuonTra.csv";

            if (sfdCsv.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("TicketId,StudentId,StudentName,EquipmentName,Quantity,CheckoutDate,DueDate,ActualReturnDate,Status");
                foreach (CheckoutTicket item in ticketBindingSource)
                {
                    sb.AppendLine(item.ToCsvRow());
                }
                File.WriteAllText(sfdCsv.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}