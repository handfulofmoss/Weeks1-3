using UnityEngine;

public class ClockHand : MonoBehaviour
{
    public float handSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 handRotate = transform.eulerAngles;
        handRotate.z += handSpeed * Time.deltaTime;
        transform.eulerAngles = handRotate;
    }
}
