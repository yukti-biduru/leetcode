using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Leetcode.Solutions.API_coding_challenge;

using System.Collections.Generic;
using System;

namespace Leetcode.Solutions
{
    internal class API_coding_challenge
    {
    }
    public class Charge
    {
        public string ChargeId { get; }
        public string CustomerId { get; }
        public string Value { get; }

        public Charge(string chargeId, string customerId, string value)
        {
            ChargeId = chargeId;
            CustomerId = customerId;
            Value = value;
        }
    }
    public class ChargeValue
    {
        public string ChargeId { get; }
        public string CustomerId { get; }
        public string Amount { get; }
        public string Currency { get; }

        public ChargeValue( string customerId, string amount, string crrency)
        {
            ChargeId = Guid.NewGuid().ToString();
            CustomerId = customerId;
            Amount = amount;
            Currency = crrency;
        }
    }
    public interface IExternalPaymentService
    {
        string CreateCharge(string customerId, decimal amount);
        void CancelCharge(string chargeId);
        string ChargeCurrency { get; set; }
        List<Charge> PendingCharges { get; }
    }
    public class ExternalPaymentService: IExternalPaymentService
    {
        public string ChargeCurrency { get; set; }
        public List<Charge> PendingCharges { get; } = new List<Charge>();
        public ExternalPaymentService(string currency)
        {
            ChargeCurrency = currency;
        }

        public string CreateCharge(string customerId, decimal amount)
        {
            string chargeId = Guid.NewGuid().ToString(); // Generating a unique charge id
            string value = $"{amount} {ChargeCurrency}";
            Charge newCharge = new Charge(chargeId, customerId, value);
            PendingCharges.Add(newCharge);
            return chargeId;
        }

        public void CancelCharge(string chargeId)
        {
            Charge chargeToRemove = PendingCharges.Find(charge => charge.ChargeId == chargeId);
            if (chargeToRemove != null)
            {
                PendingCharges.Remove(chargeToRemove);
            }
        }
    }

    public class ExternalPaymentServiceAdapter
    {
        private IExternalPaymentService _externalPaymentService;

        public ExternalPaymentServiceAdapter(IExternalPaymentService externalPaymentService)
        {
            _externalPaymentService = externalPaymentService;
        }

        public string CreateCharge(string customerId, decimal amount, string currency)
        {

            _externalPaymentService.ChargeCurrency = currency;
            return _externalPaymentService.CreateCharge(customerId, amount);
        }
        public void CancelCharge(string chargeId)
        {
            _externalPaymentService.CancelCharge(chargeId);

        }

        public string UpdateCharge(string chargeId, decimal amount, string currency)
        {
            Charge existingCharge = _externalPaymentService.PendingCharges.Find(charge => charge.ChargeId == chargeId);
            if (existingCharge != null)
            {
                _externalPaymentService.CancelCharge(chargeId);
                return CreateCharge(existingCharge.CustomerId, amount, currency);
            }
            return null;
        }
        public List<ChargeValue> ListCharges()
        {
            List<ChargeValue> charges = new List<ChargeValue>();
            foreach (var charge in _externalPaymentService.PendingCharges)
            {
                string[] valueParts = charge.Value.Split(' ');
                ChargeValue ch = new ChargeValue(charge.CustomerId, valueParts[0], valueParts[1]);
                charges.Add(ch);
            }
            return charges;
        }
    }
}


