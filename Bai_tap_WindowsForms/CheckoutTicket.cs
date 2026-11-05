using System;

namespace Bai_tap_WindowsForms
{
    public class CheckoutTicket
    {
        public string TicketId { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string EquipmentName { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
        public DateTime CheckoutDate { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(7);
        public DateTime? ActualReturnDate { get; set; }
        public string Status { get; set; } = "Đang mượn";

        public CheckoutTicket() { }

        public CheckoutTicket(string ticketId, string studentId, string studentName, string equipmentName, int quantity, DateTime checkoutDate, DateTime dueDate, DateTime? actualReturnDate, string status)
        {
            TicketId = ticketId;
            StudentId = studentId;
            StudentName = studentName;
            EquipmentName = equipmentName;
            Quantity = quantity;
            CheckoutDate = checkoutDate;
            DueDate = dueDate;
            ActualReturnDate = actualReturnDate;
            Status = status;
            CheckOverdue();
        }

        public void CheckOverdue()
        {
            if (Status == "Đang mượn" && DueDate.Date < DateTime.Now.Date)
            {
                Status = "Quá hạn";
            }
        }

        public string ToCsvRow()
        {
            string returnDateStr = ActualReturnDate.HasValue ? ActualReturnDate.Value.ToString("yyyy-MM-dd") : "Chưa trả";
            return $"\"{TicketId}\",\"{StudentId}\",\"{StudentName}\",\"{EquipmentName}\",{Quantity},\"{CheckoutDate:yyyy-MM-dd}\",\"{DueDate:yyyy-MM-dd}\",\"{returnDateStr}\",\"{Status}\"";
        }
    }
}