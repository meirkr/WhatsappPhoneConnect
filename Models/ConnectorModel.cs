using System.ComponentModel.DataAnnotations;

namespace WhatsappPhoneConnect.Models
{
    public class ConnectorModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "חסר מספר טלפון")] 
        public string PhoneNumber { get; set; }
    }
}