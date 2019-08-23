using System;

namespace InterfacesWithMike {
    class Program {
        static void Main(string[] args) {

            Partner p1 = new Partner();
            p1.VendorID = 123;
            p1.CreditLimit = 1000m;
            p1.Address = "30303 A St.";
            IPrintLabel(p1);

            Customer c1 = new Customer();
            IPrintLabel(c1);

            Partner p2 = new Partner();
            p2.VendorID = 123;
            p2.CreditLimit = 5000m;

            //Greater than something > 0
            if (p1.CompareTo(p2) > 0) {
                Console.WriteLine("P1 is better");
            }
            else {
                Console.WriteLine("P1 is not better");
                 }
            }

        static void IPrintLabel(Partner theAddressObject) {
            Console.WriteLine(theAddressObject.Name + " " +theAddressObject.Address);
            }
        }
    }

    interface IVendor {

        int VendorID { get; set; }
        string Name { get; set; }
        decimal CreditLimit { get; set; }
        void YellAtVendor(string Msg);
        string Purchase(string Item, int Qty);       
            //Events
        }

    interface IPrintLabel {
       
        string Name { get; set; }
        string Address { get; set; }
    }

    
    class Customer : IPrintLabel {
    public string Address { get; set; }
    public int CustomerId { get; set; }
    public string Name { get; set; }
    string IPrintLabel.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

}

    class Partner : IVendor, IComparable {
        public int VendorID { get; set; }
        public string Name { get; set; }
        public decimal CreditLimit { get; set; }
        public string Address { get; set; }

        public int CompareTo(object obj) {

            Partner theOtherGuy = (Partner)obj;
            if (this.CreditLimit == theOtherGuy.CreditLimit) {
                return 0; //If they're the same, return 0 always
            } 
            else 
                if (this.CreditLimit > theOtherGuy.CreditLimit) {
                    return 1;
                }
            
            else {
                return -1;
            }
        }

        public string Purchase(string Item, int Qty) {
            return "ok";
        }

        public void YellAtVendor(string Msg) {
            Console.WriteLine(Msg);
        }
    }

    class BankAccount {
        public int fred;
    }


