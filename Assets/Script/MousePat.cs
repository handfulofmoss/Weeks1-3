using UnityEngine;
using UnityEngine.InputSystem;

public class MousePat : MonoBehaviour
{
    //boolean for the current status of the mouse position in relation to the kirby sprite
    public bool mousePat = false;
    //vector for kirbys scale so it can be modified easily
    public Vector2 kirbyScale = new Vector2(0.75f, 0.75f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //depending if kirby is being pat or not, will change the current y scale of the kirby sprite
        //making it appear like its getting slightly squished
        if (mousePat == true)
        {
            kirbyScale.y = 0.7f;
        }
        else
        {
            kirbyScale.y = 0.75f;
        }

        //turns the mosue position into pixels so it can be used within the world
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //find distance between the current position of kirby and the mouse position
        float distance = Vector2.Distance(transform.position, mousePos);

        //if the mouse is close enough, triggers mousePat
        if (distance < 4)
        {
            mousePat = true;
        }
        //if not, sets to false
        else
        {
            mousePat = false;
        }

        //changes the scale of kirby depending on if the mouse is hovering him or not
        transform.localScale = kirbyScale;
    }
}
