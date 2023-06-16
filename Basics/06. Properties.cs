using System;
class Person
{
    private byte age;
    private int grade;
    public string name;
    public string address;
    private DateTime dob;
    // DateTime is built in type

    // Method name, property name and class name must be Pascal 
    // case and field name i.e.varible name must be camel case
    public byte Age
    {
        get { return age; }
        set
        {
            if (value > 30 && value < 40)
            {
                age = value;
            }
        }
    }

    // auto-implemented properties - without any logic

    public string Address
    {
        get;
        set;
    }

    // Read only property
    public string Name
    {
        get;
    }

}
class Modifier
{
    public void ModifyPerson()
    {
        Person person = new Person();
        person.Age = 34;   // this will be assigned
        person.Age = 45;   // this won't be assigned
    }

}
