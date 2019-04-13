using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.Models;

namespace ClinkedIn.Validators
{
    public class CreateServicesValidator
    {
        public bool ServiesValidator(CreateService createService)
        {
            return string.IsNullOrEmpty(createService.Name)
                || string.IsNullOrEmpty(createService.Description);
        }
    }
}
