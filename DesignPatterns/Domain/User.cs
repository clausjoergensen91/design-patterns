namespace Domain;
public class User
{
    private User(int age)
    {
        FirstName = "John";
        LastName = "Smith";
        Age = age;
        Company = "IBM";
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Company { get; set; }

    public static User Create(int age)
    {
        return new User(age);
    }
}
