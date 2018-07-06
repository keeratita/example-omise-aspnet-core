using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Omise;

namespace OmiseASPNETCore.Pages
{
    public class CheckoutModel : PageModel
    {
        public string ChargeID { get; private set; }
        public void OnGet()
        {
        }

        public async Task OnPostAsync()
        {

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            string token = Request.Form["omiseToken"];

            var omise = new Client(skey: OmiseKeys.SecretKey);
            var charge = await omise.Charges.Create(new Omise.Models.CreateChargeRequest
            {
                Amount = 10025,
                Currency = "THB",
                Card = token
            });

            ChargeID = charge.Id;

        }
    }
}
