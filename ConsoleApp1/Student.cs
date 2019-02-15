namespace ConsoleApp1
{
    public class Student : Person
    {
        public int Id { get; private set; }

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void AttendClass(Class @class)
        {
            if (ReferenceEquals(null, @class)) throw new System.ArgumentNullException(nameof(@class));

            Id = @class.Students.Count + 1;
        }
    }
}
