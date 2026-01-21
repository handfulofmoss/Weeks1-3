using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{

    public SpriteRenderer SpriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColor();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log ("Try to change the sprite");
            //PickARandomColor();
            if (barrels.Count > 0)
            {
                PickARandomSprite();
            }
        }

        //DONT WRITE IT THIS WAY- will read it as sprite pos at (0,0): SpriteRenderer.sprite.bounds.Contains(mousePos)
        //INSTEAD DO: SpriteRenderer.bounds.Contains(mousePos)

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

        //when left mouse button pressed, deletes the first item in the barrels arrayList, unless the list is empty
        if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }

    }

    void PickARandomColor()
    {
        SpriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //get a random num between 0 & 2
        randomNumber = Random.Range(0, barrels.Count);

        //use that to set the sprite
        SpriteRenderer.sprite = barrels[randomNumber];

    }
}
