using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public InputField nameInput;
    public InputField ageInput;
    public InputField weightInput;
    public Text result;

    // used in the inspector 
    public void CreatePerson()
    { 
        Person newPerson = new Person(nameInput.text, float.Parse(weightInput.text), true, int.Parse(ageInput.text), 180);
        result.text += newPerson.firstName + " weight: " + newPerson.weightInKg + " age: " + newPerson.age;
    }
}