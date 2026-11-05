using System;

namespace Bai_tap_WindowsForms
{
    public class RepairOrder
    {
        public string OrderId { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string DeviceType { get; set; } = string.Empty;
        public string FaultDescription { get; set; } = string.Empty;
        public DateTime ReceivedDate { get; set; } = DateTime.Now;
        public decimal EstimatedCost { get; set; }
        public string Status { get; set; } = "Mới tiếp nhận";
        public string ImagePath { get; set; } = string.Empty;

        public RepairOrder() { }

        public RepairOrder(string orderId, string customerName, string phoneNumber, string deviceType, string faultDescription, DateTime receivedDate, decimal estimatedCost, string status, string imagePath)
        {
            OrderId = orderId;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            DeviceType = deviceType;
            FaultDescription = faultDescription;
            ReceivedDate = receivedDate;
            EstimatedCost = estimatedCost;
            Status = status;
            ImagePath = imagePath;
        }

        public string ToCsvRow()
        {
            return $"\"{OrderId}\",\"{CustomerName}\",\"{PhoneNumber}\",\"{DeviceType}\",\"{FaultDescription}\",\"{ReceivedDate:yyyy-MM-dd}\",{EstimatedCost},\"{Status}\",\"{ImagePath}\"";
        }
    }
}