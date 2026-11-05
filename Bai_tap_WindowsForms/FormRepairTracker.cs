using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_tap_WindowsForms
{
    public partial class FormRepairTracker : Form
    {
        private BindingList<RepairOrder> listOrders = new BindingList<RepairOrder>();
        private BindingSource orderBindingSource = new BindingSource();
        private string currentImagePath = string.Empty;

        public FormRepairTracker()
        {
            InitializeComponent();
        }

        private void FormRepairTracker_Load(object sender, EventArgs e)
        {
            cboDeviceType.Items.AddRange(new object[] { "Laptop", "Điện thoại", "Máy tính bảng", "PC / Desktop" });
            cboDeviceType.SelectedIndex = 0;

            cboStatus.Items.AddRange(new object[] { "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            cboStatus.SelectedIndex = 0;

            cboFilterStatus.Items.AddRange(new object[] { "Tất cả", "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            cboFilterStatus.SelectedIndex = 0;

            SetupColumns();

            listOrders.Add(new RepairOrder("HD01", "Trần Văn C", "0988123456", "Laptop", "Không lên nguồn, nháy đèn đỏ", DateTime.Now.AddDays(-2), 1500000m, "Đang sửa", ""));
            listOrders.Add(new RepairOrder("HD02", "Lê Thị D", "0977654321", "Điện thoại", "Vỡ màn hình OLED", DateTime.Now.AddDays(-1), 2200000m, "Mới tiếp nhận", ""));

            orderBindingSource.DataSource = listOrders;
            dgvOrders.DataSource = orderBindingSource;

            dgvOrders.SelectionChanged += DgvOrders_SelectionChanged;
            btnChooseImage.Click += BtnChooseImage_Click;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += (s, ev) => ClearForm();
            txtSearch.TextChanged += ApplyFilter;
            cboFilterStatus.SelectedIndexChanged += ApplyFilter;
            menuExportCsv.Click += MenuExportCsv_Click;
            menuExit.Click += (s, ev) => Application.Exit();

            ApplyFilter(null, null);
        }

        private void SetupColumns()
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OrderId", HeaderText = "Mã Đơn", Width = 80 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "Khách Hàng", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "Số ĐT", Width = 100 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DeviceType", HeaderText = "Loại Thiết Bị", Width = 110 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FaultDescription", HeaderText = "Mô Tả Lỗi", Width = 180 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ReceivedDate", HeaderText = "Ngày Nhận", Width = 100 });

            var costCol = new DataGridViewTextBoxColumn { DataPropertyName = "EstimatedCost", HeaderText = "Chi Phí Dự Kiến", Width = 120 };
            costCol.DefaultCellStyle.Format = "N0";
            dgvOrders.Columns.Add(costCol);

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng Thái", Width = 110 });
        }

        private void DgvOrders_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is RepairOrder selected)
            {
                txtOrderId.Text = selected.OrderId;
                txtCustomerName.Text = selected.CustomerName;
                txtPhone.Text = selected.PhoneNumber;
                cboDeviceType.Text = selected.DeviceType;
                txtCost.Text = selected.EstimatedCost.ToString("G0");
                cboStatus.Text = selected.Status;
                dtpReceivedDate.Value = selected.ReceivedDate;
                txtFaultDesc.Text = selected.FaultDescription;

                currentImagePath = selected.ImagePath;
                if (!string.IsNullOrEmpty(currentImagePath) && File.Exists(currentImagePath))
                {
                    picDevice.Image = Image.FromFile(currentImagePath);
                }
                else
                {
                    picDevice.Image = null;
                }
            }
        }

        private void BtnChooseImage_Click(object? sender, EventArgs e)
        {
            ofdImage.Filter = "File Ảnh (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                currentImagePath = ofdImage.FileName;
                picDevice.Image = Image.FromFile(currentImagePath);
            }
        }

        private bool ValidateForm(bool isNew)
        {
            errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                errorProvider.SetError(txtOrderId, "Mã đơn không được trống!"); isValid = false;
            }
            else if (isNew && listOrders.Any(o => o.OrderId.Equals(txtOrderId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(txtOrderId, "Mã đơn bị trùng!"); isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                errorProvider.SetError(txtCustomerName, "Tên khách hàng không được trống!"); isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại không được trống!"); isValid = false;
            }

            if (!decimal.TryParse(txtCost.Text.Trim(), out decimal cost) || cost < 0)
            {
                errorProvider.SetError(txtCost, "Chi phí phải là số không âm!"); isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtFaultDesc.Text))
            {
                errorProvider.SetError(txtFaultDesc, "Mô tả lỗi bắt buộc phải nhập!"); isValid = false;
            }

            return isValid;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateForm(isNew: true)) return;

            decimal.TryParse(txtCost.Text.Trim(), out decimal cost);

            RepairOrder order = new RepairOrder(
                txtOrderId.Text.Trim(), txtCustomerName.Text.Trim(), txtPhone.Text.Trim(),
                cboDeviceType.Text, txtFaultDesc.Text.Trim(), dtpReceivedDate.Value, cost, cboStatus.Text, currentImagePath
            );

            listOrders.Add(order);
            ApplyFilter(null, null);
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is not RepairOrder selected) return;
            if (!ValidateForm(isNew: false)) return;

            decimal.TryParse(txtCost.Text.Trim(), out decimal cost);

            selected.CustomerName = txtCustomerName.Text.Trim();
            selected.PhoneNumber = txtPhone.Text.Trim();
            selected.DeviceType = cboDeviceType.Text;
            selected.FaultDescription = txtFaultDesc.Text.Trim();
            selected.ReceivedDate = dtpReceivedDate.Value;
            selected.EstimatedCost = cost;
            selected.Status = cboStatus.Text;
            selected.ImagePath = currentImagePath;

            orderBindingSource.ResetCurrentItem();
            ApplyFilter(null, null);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is not RepairOrder selected) return;
            if (MessageBox.Show($"Xóa đơn sửa chữa [{selected.OrderId}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listOrders.Remove(selected);
                ApplyFilter(null, null);
                ClearForm();
            }
        }

        private void ApplyFilter(object? sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.Text;

            var filtered = listOrders.Where(o =>
                (string.IsNullOrEmpty(keyword) || o.OrderId.ToLower().Contains(keyword) || o.CustomerName.ToLower().Contains(keyword) || o.PhoneNumber.Contains(keyword)) &&
                (selectedStatus == "Tất cả" || o.Status == selectedStatus)
            ).ToList();

            orderBindingSource.DataSource = new BindingList<RepairOrder>(filtered);

            decimal totalIncompleteCost = listOrders.Where(o => o.Status != "Hoàn tất" && o.Status != "Đã hủy").Sum(o => o.EstimatedCost);

            lblStatusCount.Text = $"Số đơn hiển thị: {orderBindingSource.Count} | ";
            lblTotalCost.Text = $"Tổng chi phí dự kiến (Chưa hoàn tất): {totalIncompleteCost:N0} VNĐ";
        }

        private void ClearForm()
        {
            txtOrderId.Clear(); txtCustomerName.Clear(); txtPhone.Clear(); txtCost.Clear(); txtFaultDesc.Clear();
            dtpReceivedDate.Value = DateTime.Now;
            currentImagePath = string.Empty; picDevice.Image = null;
            errorProvider.Clear();
        }

        private void MenuExportCsv_Click(object? sender, EventArgs e)
        {
            sfdCsv.Filter = "File CSV (*.csv)|*.csv";
            sfdCsv.FileName = "DanhSachDonSuaChua.csv";

            if (sfdCsv.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("OrderId,CustomerName,PhoneNumber,DeviceType,FaultDescription,ReceivedDate,EstimatedCost,Status,ImagePath");
                foreach (RepairOrder item in orderBindingSource)
                {
                    sb.AppendLine(item.ToCsvRow());
                }
                File.WriteAllText(sfdCsv.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}