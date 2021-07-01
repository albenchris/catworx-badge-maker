namespace CatWorx.BadgeMaker
{
    class Employee
    {
        // constructor
        private string FirstName;
        private string LastName;
        private int Id;
        private string PhotoUrl;

        // methods
        public Employee(string firstName, string lastName, int id, string photoUrl) {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }

        public string GetName() {
            return FirstName + " " + LastName;
        }

        public int GetId() {
            return Id;
        }

        public string GetPhotoUrl() {
            return PhotoUrl;
        }
    }
}