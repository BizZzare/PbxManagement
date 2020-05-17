using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PbxManagement.Models;

namespace PbxManagement.Helpers
{
    public static class SubscriberHelper
    {
        public static void AddSubscriber(string name, string surname, string phoneNumber)
        {
            if (!CheckIfUnique(phoneNumber))
            {
                throw new Exception("The database already contains a subscriber with this phone number!");
            }

            using (var context = new PbxEntities())
            {
                context.Subscribers.Add(new Subscribers { Name = name, Surname = surname, PhoneNumber = phoneNumber });

                context.SaveChanges();
            }
        }

        public static IEnumerable<Subscribers> GetSubscribers()
        {
            using (var context = new PbxEntities())
            {
                return context.Subscribers.ToList();
            }
        }

        public static IEnumerable<Subscribers> SearchSubscribers(string query)
        {
            var subs = GetSubscribers();
            var res = subs.Where(x => x.Name.ToUpper().Contains(query.ToUpper())
                    || x.Surname.ToUpper().Contains(query.ToUpper())
                    || MakePhoneNumberSafe(x.PhoneNumber).Contains(MakePhoneNumberSafe(query))
                    ).ToList();
            return res;
        }

        public static void UpdateSubscriber(int id, string name, string surname, string phoneNumber, string balance)
        {
            using (var context = new PbxEntities())
            {
                var sub = context.Subscribers.SingleOrDefault(x => x.Id == id);
                if(sub != null)
                {
                    sub.Name = name;
                    sub.Surname = surname;
                    sub.PhoneNumber = phoneNumber;
                    sub.Balance = Convert.ToDecimal(balance);

                    context.SaveChanges();
                }
            }
        }

        private static bool CheckIfUnique(string phoneNumber)
        {
            using (var context = new PbxEntities())
            {
                var subscribers = context.Subscribers.ToList();

                var phoneNumberSafe = MakePhoneNumberSafe(phoneNumber);

                foreach (var subscriber in subscribers)
                {
                    var subsPhoneNumberSafe = MakePhoneNumberSafe(subscriber.PhoneNumber);

                    if (phoneNumberSafe.Equals(subsPhoneNumberSafe))
                    {
                        return false;
                    }

                }

                return true;
            }
        }

        private static string MakePhoneNumberSafe(string phoneNumber)
        {
            return phoneNumber
                    .Replace("+", string.Empty)
                    .Replace(" ", string.Empty)
                    .Replace("-", string.Empty)
                    .Replace("(", string.Empty)
                    .Replace(")", string.Empty);
        }
    }
}
