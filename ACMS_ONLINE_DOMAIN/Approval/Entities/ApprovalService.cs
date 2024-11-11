// Entity: ApprovalService
using ACMS_ONLINE_DOMAIN.Approval.ValueObjects;
namespace ACMS_ONLINE_DOMAIN.Approval.Entities
{
    public class ApprovalService
    {


        public long ApprovalId { get; private set; }
        public int ItemSerial { get; private set; }
        public int ServiceId { get; private set; }
        public int MedItem { get; private set; }
        public Dose Dose { get; private set; }
        public double? Qty { get; private set; } 
        public string ItemDescription { get; private set; }
        public bool? IsChronic { get; private set; }
        public double Coinsurance { get; private set; }
        public double OriginalPrice { get; private set; }
        public double Price { get; private set; }









        public string? ItemDesc { get; set; }


        public int? ItemRepeat { get; set; }

        public string? Notes { get; set; }

        public string? LastUpdateBy { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public string? LastUpdateFrom { get; set; }

        public int? InsurerMeditem { get; set; }


        public string? OnlineStatus { get; set; }

        public int? Days { get; set; }

        public double? ApQty { get; set; }

        


        public int? Editqty { get; set; }

        public bool? IsActualValue { get; set; }

        public virtual Approval Approval { get; set; } = null!;



        private ApprovalService() { }
        public static ApprovalService Create(long approvalId, int itemSerial, int serviceId, int medItem, Dose dose, float price, string itemDescription, bool? isChronic)
        {

            var service = new ApprovalService()
            {
                ApprovalId = approvalId,
                ItemSerial = itemSerial,
                ServiceId = serviceId,
                MedItem = medItem,
                Dose = dose,
                Price = price,
                ItemDescription = itemDescription,
                IsChronic = isChronic,
                OriginalPrice = price,
            };
            service.CalculateQuantityAndPrice();
            return service;
        }

        private void CalculateQuantityAndPrice()
        {
            if (Dose != null)
            {
                Qty = Dose.CalculateTotalQuantity();

                if (Qty.HasValue)
                {
                    Price = Price * Qty.Value;
                }
            }
            else
            {
                Qty = 0;
            }
        }


        public void UpdatePrice(float price)
        {
            Price = price;
        }


        public double TotalPrice()
        {
            return (Price * Qty ?? 0);
        }

    }
}