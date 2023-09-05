using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class wfcman : MonoBehaviour
{

    public Vector2 mapScale;
    public TextAsset tileRules;
    public List<Texture> rawTextures;


    private bool isDone = false;


    // Start is called before the first frame update
    void Start()
    {

        int starting_x = UnityEngine.Random.Range(0, (int)mapScale.x);
        int starting_y = UnityEngine.Random.Range(0, (int)mapScale.y);

        int starting_tile = UnityEngine.Random.Range(0, rawTextures.Count);

        Debug.Log("WFC Starting...");
        Debug.Log($"{starting_x}, {starting_y}, {starting_tile}");

        PlaceTile(rawTextures[starting_tile], new Vector2(starting_x, starting_y));

    }

    // Update is called once per frame
    void Update()
    {

    }




    void PlaceTile(Texture tex, Vector3 position)
    {
        GameObject drawableObject = new GameObject("Generated Tile");
        drawableObject.AddComponent(typeof(SpriteRenderer));
        drawableObject.transform.position = position;

        Sprite spr = Sprite.Create(
            tex as Texture2D,
            new Rect(0f, 0f, tex.width, tex.height),
            new Vector2(0.5f, 0.5f),
            tex.width
        );

        SpriteRenderer render = drawableObject.GetComponent<SpriteRenderer>();
        render.transform.localScale = Vector2.one;
        render.sprite = spr;

        drawableObject.transform.parent = this.transform;
    }



    // Utilidades
    [ContextMenu("Save as JSON")]
    void ToJSON()
    {

        foreach (var tex in rawTextures){

        }
    }
}



