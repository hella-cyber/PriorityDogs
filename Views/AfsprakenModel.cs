using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PriorityDogs.Models
{
    public class AfsprakenModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Hondeneigenaar naam")]
        public string DogOwnerName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Hondeneigenaar achternaam")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Straatnaam + Nummer")]
        public string Adress { get; set; }

        [Required]
        [DisplayName("Email")]
        public string Email { get; set; } 
        
        [DisplayName("Telefoonnummer")]
        [DataType(DataType.PhoneNumber)]
         public string MobilePhone { get; set; }

        [DisplayName("Afspraakverzoek datum")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [Range(1, maximum: 10)]
        [DisplayName("Hond gemoedstoestand op een schaal van 1-10. 1 erg ongelukkig, gestresst, of veel pijn 10 erg blij of zorgeloos")]
        public int StressLevel { get; set; }

        [Range(1, maximum: 10)]
        [DisplayName("Eigenaar gemoedstoestand op een schaal van 1-10. 1 elemaal gestresst dit kan niet meer, 10 zelfverzekerd blij dit gaat geweldig!")]
        public int StressLevels { get; set; }
    }
}
