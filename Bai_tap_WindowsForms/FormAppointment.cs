using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai_tap_WindowsForms
{
    public partial class FormAppointment : Form
    {
        private BindingList<Appointment> listAppointments = new BindingList<Appointment>();
        private BindingSource appointmentBindingSource = new BindingSource();

        public FormAppointment()
        {
            InitializeComponent();
        }

        private void FormAppointment_Load(object sender, EventArgs e)
        {
            cboDoctor.Items.AddRange(new object[] { "BS. Nguyễn Văn Phước", "BS. Trần Thị Mai", "BS. Lê Hoàng Nam" });
            cboDoctor.SelectedIndex = 0;

            cboStatus.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboStatus.SelectedIndex = 0;

            cboFilterStatus.Items.AddRange(new object[] { "Tất cả", "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboFilterStatus.SelectedIndex = 0;

            SetupColumns();

            listAppointments.Add(new Appointment("LH01", "Nguyễn An", "0905123456", DateTime.Now.AddHours(2), "BS. Nguyễn Văn Phước", "Tái khám định kỳ", "Chờ khám"));
            listAppointments.Add(new Appointment("LH02", "Trần Bình", "0914987654", DateTime.Now.AddDays(1), "BS. Trần Thị Mai", "Đau dạ dày", "Chờ khám"));

            appointmentBindingSource.DataSource = listAppointments;
            dgvAppointments.DataSource = appointmentBindingSource;

            dgvAppointments.SelectionChanged += DgvAppointments_SelectionChanged;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += (s, ev) => ClearForm();
            txtSearch.TextChanged += ApplyFilter;
            cboFilterStatus.SelectedIndexChanged += ApplyFilter;
            menuExportCsv.Click += MenuExportCsv_Click;
            menuExit.Click += (s, ev) => Application.Exit();

            UpdateStatusCount();
        }

        private void SetupColumns()
        {
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.Columns.Clear();
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AppointmentId", HeaderText = "Mã Lịch Hẹn", Width = 90 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PatientName", HeaderText = "Bệnh Nhân", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "Số Điện Thoại", Width = 110 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AppointmentDate", HeaderText = "Ngày Giờ Hẹn", Width = 130 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Doctor", HeaderText = "Bác Sĩ", Width = 140 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Reason", HeaderText = "Lý Do Khám", Width = 150 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng Thái", Width = 100 });
        }

        private void DgvAppointments_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is Appointment selected)
            {
                txtId.Text = selected.AppointmentId;
                txtName.Text = selected.PatientName;
                txtPhone.Text = selected.PhoneNumber;
                dtpDate.Value = selected.AppointmentDate < dtpDate.MinDate ? DateTime.Now : selected.AppointmentDate;
                cboDoctor.Text = selected.Doctor;
                txtReason.Text = selected.Reason;
                cboStatus.Text = selected.Status;
            }
        }

        private bool ValidateForm(bool isNew)
        {
            errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                errorProvider.SetError(txtId, "Mã lịch hẹn không được để trống!");
                isValid = false;
            }
            else if (isNew && listAppointments.Any(a => a.AppointmentId.Equals(txtId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(txtId, "Mã lịch hẹn đã tồn tại!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "Họ tên bệnh nhân không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{9,11}$"))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại không hợp lệ (9-11 chữ số)!");
                isValid = false;
            }

            if (dtpDate.Value < DateTime.Now.AddMinutes(-5))
            {
                errorProvider.SetError(dtpDate, "Ngày hẹn không được nằm trong quá khứ!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                errorProvider.SetError(txtReason, "Lý do khám không được để trống!");
                isValid = false;
            }

            return isValid;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateForm(isNew: true)) return;

            Appointment app = new Appointment(
                txtId.Text.Trim(), txtName.Text.Trim(), txtPhone.Text.Trim(),
                dtpDate.Value, cboDoctor.Text, txtReason.Text.Trim(), cboStatus.Text
            );

            listAppointments.Add(app);
            ApplyFilter(null, null);
            MessageBox.Show("Thêm lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is not Appointment selected) return;
            if (!ValidateForm(isNew: false)) return;

            selected.PatientName = txtName.Text.Trim();
            selected.PhoneNumber = txtPhone.Text.Trim();
            selected.AppointmentDate = dtpDate.Value;
            selected.Doctor = cboDoctor.Text;
            selected.Reason = txtReason.Text.Trim();
            selected.Status = cboStatus.Text;

            appointmentBindingSource.ResetCurrentItem();
            ApplyFilter(null, null);
            MessageBox.Show("Cập nhật lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is not Appointment selected) return;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa lịch hẹn [{selected.AppointmentId}]?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listAppointments.Remove(selected);
                ApplyFilter(null, null);
                ClearForm();
            }
        }

        private void ApplyFilter(object? sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.Text;

            var filtered = listAppointments.Where(a =>
                (string.IsNullOrEmpty(keyword) || a.PatientName.ToLower().Contains(keyword) || a.PhoneNumber.Contains(keyword)) &&
                (selectedStatus == "Tất cả" || a.Status == selectedStatus)
            ).ToList();

            appointmentBindingSource.DataSource = new BindingList<Appointment>(filtered);
            UpdateStatusCount();
        }

        private void ClearForm()
        {
            txtId.Clear(); txtName.Clear(); txtPhone.Clear(); txtReason.Clear();
            dtpDate.Value = DateTime.Now;
            if (cboDoctor.Items.Count > 0) cboDoctor.SelectedIndex = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            errorProvider.Clear();
        }

        private void UpdateStatusCount()
        {
            lblStatusCount.Text = $"Tổng số lịch hẹn đang hiển thị: {appointmentBindingSource.Count}";
        }

        private void MenuExportCsv_Click(object? sender, EventArgs e)
        {
            sfdCsv.Filter = "File CSV (*.csv)|*.csv";
            sfdCsv.FileName = "DanhSachLichHen.csv";

            if (sfdCsv.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("AppointmentId,PatientName,PhoneNumber,AppointmentDate,Doctor,Reason,Status");

                foreach (Appointment item in appointmentBindingSource)
                {
                    sb.AppendLine(item.ToCsvRow());
                }

                File.WriteAllText(sfdCsv.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}