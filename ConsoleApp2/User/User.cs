namespace ConsoleApp2.User;

public  class User
{
    private static int count = 0;
    public int Id {get;}
    public String firstName { get; set; }
    public String lastName { get; set; }
    public UserType userType { get; set; }

    public User(String firstName, String lastName, UserType userType)
    {
        this.Id = ++count;
        this.firstName = firstName;
        this.lastName = lastName;
        this.userType = userType;
    }

    public int maxCapacity
    {
        get
        {
            if (userType == UserType.Student)
            {
                return 2;
            }
            else
            {
                return 5;
            }
        }
    }
    
    
}