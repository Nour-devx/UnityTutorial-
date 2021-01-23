

public class Person 
{
    // instance variables
    // functions or methods
    // object
    // encapslation type Name {body}
    // oop -> inheritance 
    // instance variables


  

    public string CompareWeight(Person hamada)
    {
        if (weightInKg> hamada.weightInKg)
        {
            return firstName+" is heavier";
        }

        else
        {
            return hamada.firstName+" is heavier";
        }
    }

    public string firstName;

    public bool femaleOrMale;

    public float heightInCms;

    public int age = 20;

    public float weightInKg;


    public Person(string firstName,float weightInKg, bool femaleOrMale, int age, float heightInCms)
    {
        this.firstName = firstName;
        this.weightInKg = weightInKg;
        this.femaleOrMale = femaleOrMale;
        this.age = age;
        this.heightInCms = heightInCms;
    }

}



