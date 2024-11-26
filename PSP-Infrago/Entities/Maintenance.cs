namespace PSP_Infrago.Entities
{
    public class Maintenance
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public int MaintenanceDate { get; set; }
        public string MaintenanceType { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public string Details { get; set; }
        public string Photo { get; set; }
    }
}