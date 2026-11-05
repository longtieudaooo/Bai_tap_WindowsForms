using System;

namespace Bai_tap_WindowsForms
{
    public class Appointment
    {
        public string AppointmentId { get; set; } = string.Empty;
        public string PatientName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime AppointmentDate { get; set; } = DateTime.Now;
        public string Doctor { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public string Status { get; set; } = "Chờ khám";

        public Appointment() { }

        public Appointment(string id, string name, string phone, DateTime date, string doctor, string reason, string status)
        {
            AppointmentId = id;
            PatientName = name;
            PhoneNumber = phone;
            AppointmentDate = date;
            Doctor = doctor;
            Reason = reason;
            Status = status;
        }

        public string ToCsvRow()
        {
            return $"\"{AppointmentId}\",\"{PatientName}\",\"{PhoneNumber}\",\"{AppointmentDate:yyyy-MM-dd HH:mm}\",\"{Doctor}\",\"{Reason}\",\"{Status}\"";
        }
    }
}