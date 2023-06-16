using System;

// class are by default internal
class AccessModifier
{

    internal void DoSOmeThing()

    // by default private and accessible within the same class only
    // internal means accessible within an assembly i.e. withing a project
    // public means accessible every where
    {
        Console.WriteLine("Inside doing something method");
    }

    public void DoAnotherThing()
    {
        Console.WriteLine("Inside doing another thing method");

    }
}

//another class - may be another file

class ModifiersDemo
{
    void DoSOmeThing()
    {
        AccessModifier access = new AccessModifier();
        access.DoSOmeThing();
        access.DoAnotherThing();


    }

    static void Main5(string[] args)
    {
        ModifiersDemo md = new ModifiersDemo();
        md.DoSOmeThing();
    }
}