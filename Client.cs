using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs
{
    public class Client
    {
        private decimal accountNumber;
        private static readonly List<Client> clients = new();
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? BankName { get; set; }
        public string AccountNumber 
        {
            get 
            { 
                return accountNumber.ToString(); 
            }
            set
            {
                if (value.Length != 20 || !decimal.TryParse(value, out decimal accountNumber))
                {
                    throw new ArgumentException("Номер счёта должен состоять из 20 цифр и состоять только из цифр!");
                }
                this.accountNumber = accountNumber;
            }
        }
        public string? INN { get; set; }
        public string? ResponsiblePerson { get; set; }
        public string? ResponsiblePersonPhone { get; set; }

        public Client() { }

        public Client(string name, string address, string bankName, string accountNumber,
                      string INN, string responsiblePerson, string responsiblePersonPhone)
        {
            Name = name;
            Address = address;
            BankName = bankName;
            AccountNumber = accountNumber;
            this.INN = INN;
            ResponsiblePerson = responsiblePerson;
            ResponsiblePersonPhone = responsiblePersonPhone;
            clients.Add(this);
        }

        public static ReadOnlyCollection<Client> Clients => new(clients);

    }

}
