using System.Security.Cryptography;
using UnityEngine;

public class StarFall : MonoBehaviour
{
    //make random so the stars can vary around -12 to 10 and 6 to 8
    //same with where they land
    //how do I mske the speed random...
    public Vector2 startPos = new Vector2(-10, 6);
    public Vector2 endPos = new Vector2(10,-6);
    public float t = 0;
    public AnimationCurve starCurve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(startPos, endPos, t);
    }
}
