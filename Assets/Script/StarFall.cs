using System.Security.Cryptography;
using UnityEngine;

public class StarFall : MonoBehaviour
{
    //vectors and variables can be seen within the inspector for ease
    public Vector2 startPos = new();
    public Vector2 endPos = new();
    public float speed = 0;
    public AnimationCurve starCurve;
    public float randomSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Gives the starting speed for each star a random speed for it to go off of
        randomSpeed = Random.Range(0.002f, 0.005f);

        //Gives a random start and end position for each star
        startPos.x = Random.Range(-25, -5);
        startPos.y = Random.Range(6, 10);
        endPos.x = Random.Range(5, 15);
        endPos.y = Random.Range(-6, -10);
    }

    // Update is called once per frame
    void Update()
    {
        //adds the random speed of the star to the speed which will reset once it reaches the end of the curve
        speed += randomSpeed;
        if (speed > 1)
        {
            speed = 0;
        // gives new random speeds and positions for the stars on completion
            randomSpeed = Random.Range(0.002f, 0.005f);

            startPos.x = Random.Range(-25, -5);
            startPos.y = Random.Range(6, 10);

            endPos.x = Random.Range(5, 15);
            endPos.y = Random.Range(-6, -10);
        }
        //transforms the stars position on the curve based on their given start and end positions
        //as well as the speed it will travel
        transform.position = Vector2.Lerp(startPos, endPos, speed);
    }
}
