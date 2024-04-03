using UnityEngine;

public class Rand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Generate a random number between 0 and 1
        float randomNumber = Random.value;
        
        // Print the random number to the console
        Debug.Log("Random Number: " + randomNumber);
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic here
    }
}