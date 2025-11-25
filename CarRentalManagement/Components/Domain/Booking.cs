namespace CarRentalManagement.Components.Domain
{
    public class Booking : BaseDomainModel
    {
        public int VehicleId { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

        public string CustomerId { get; set; }
    }
}
