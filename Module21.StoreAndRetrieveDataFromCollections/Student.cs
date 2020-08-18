namespace Module21.StoreAndRetrieveDataFromCollections
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string EmailAddress { get; set; }
    }
}