using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{

    public SpriteRenderer SpriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        //{
        //    //PickARandomColor();
        //}

        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //is it over sprite?
        if(SpriteRenderer.bounds.Contains(mousePos) == true)
        {
            //Y: use col variable
            SpriteRenderer.color = col;
        }

        else
        {
            //N: set color to white
            SpriteRenderer.color = Color.white;

        }
    }

    void PickARandomColor()
    {
        SpriteRenderer.color = Random.ColorHSV();
    }
}
