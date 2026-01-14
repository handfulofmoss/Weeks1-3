using System.Security.Cryptography;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float t = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;

        t += Time.deltaTime;
        if (t > 3)
        {
            newPos.x = Random.Range(-5, 5);
            newPos.y = Random.Range(-5, 5);
            transform.position = newPos;
            t = 0;
        }

    }
}
