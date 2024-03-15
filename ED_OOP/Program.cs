namespace ED_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değer Tip Örneği
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;

            ////OUTPUT: 20
            //Console.WriteLine(sayi1); 
            #endregion

            //----------------------------------------------

            #region Referans Tip Örneği
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            ////OUTPUT: 1000, 20, 30
            //Console.WriteLine(sayilar1[0] + " " + sayilar1[1] + " " + sayilar1[2]); 
            #endregion

            //----------------------------------------------

            //CreditManager creditManager = new CreditManager();
            //creditManager.Calculate();
            //creditManager.Save();

            //// Örnek (instance) oluşturmak.
            //Customer customer = new Customer();
            //customer.ID = 1;
            ////customer.FirstName = "Ahmet";
            ////customer.LastName = "Yüksel";
            ////customer.IdentityNumber = "1234567890";
            //customer.City= "İstanbul";

            //CustomerManager customerManager = new CustomerManager(customer);
            ////customerManager.Save(customer);
            ////customerManager.Save(customer);
            //customerManager.Save();
            //customerManager.Delete();

            //Company company = new Company();
            //company.ID = 2;
            ////company.FirstName = "Şirket";
            //company.TaxNumber = "1234567890";
            //company.City = "Ankara";

            //CustomerManager companyManager = new CustomerManager(new Company());

            //Person person = new Person();
            //person.ID = 3;
            //person.FirstName = "Kişi";
            //person.IdentityNumber = "1234567890";
            //person.City = "İzmir";

            //Customer c1 = new Customer();
            //Customer c2 = new Person();
            //Customer c3 = new Company();

            //----------------------------------------------

            CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
            customerManager.GiveCredit();

        }
    }

    class CreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Kredi hesaplandı.");
        }

        public void Save()
        {
            Console.WriteLine("Kredi verildi.");
        }
    }

    interface ICreditManager
    {
        void Calculate();

        void Save();
    }

    abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate();

        public virtual void Save()
        {
            Console.WriteLine("Kaydedildi.");
        }
    }

    class TeacherCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Öğretmen kredisi hesaplandı.");
        }

        public override void Save()
        {
            Console.WriteLine("Öğretmen kredisi kaydedildi.");
        }
    }

    class MilitaryCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Asker kredisi hesaplandı.");
        }
    }

    class CarCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Araba kredisi hesaplandı.");
        }
    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Müşteri nesnesi başlatıldı.");
        }

        public int ID { get; set; }

        public string City { get; set; }

        /* SOLID'e Uymaz
        public void Save()
        {
            Console.WriteLine("Müşteri kaydedildi.");
        }
        */
    }

    class Company : Customer
    {
        public string CompanyName { get; set; }

        public string TaxNumber { get; set; }
    }

    class Person : Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IdentityNumber { get; set; }
    }

    // Katmanlı Mimariler
    class CustomerManager
    {
        private Customer _customer;
        ICreditManager _creditManager;

        public CustomerManager(Customer customer, ICreditManager creditManager)
        {
            _customer = customer;
            _creditManager = creditManager;
        }

        public void Save()
        {
            Console.WriteLine("Müşteri kaydedildi: " + _customer.ID);
        }

        public void Delete()
        {
            Console.WriteLine("Müşteri silindi: " + _customer.ID);
        }

        public void GiveCredit()
        {
            _creditManager.Calculate();
            Console.WriteLine("Kredi verildi.");

            _creditManager.Save();
        }
    }
}
