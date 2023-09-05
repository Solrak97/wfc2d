using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.Json;



public class Tile : MonoBehaviour
{

    public string id;


    // this has to be abstracted into a generic placeable tile object
    public Texture texture;

    public List<string> upAdjacencey = new List<string>();
    public List<string> downAdjacencey = new List<string>();
    public List<string> leftAdjacencey = new List<string>();
    public List<string> rightAdjacencey = new List<string>();



    // Start is called before the first frame update
    void Start()
    {
        id = texture.name;
        Draw();

    }

    // Update is called once per frame
    void Update()
    {

    }


    void Draw()
    {
        gameObject.AddComponent(typeof(SpriteRenderer));
        Sprite spr = Sprite.Create(
            texture as Texture2D,
            new Rect(0f, 0f, texture.width, texture.height),
            new Vector2(0.5f, 0.5f),
            texture.width
        );
        SpriteRenderer render = gameObject.GetComponent<SpriteRenderer>();
        render.transform.localScale = Vector2.one;
        render.sprite = spr;

    }

    [ContextMenu("Serialize")]
    string Serialize(){
        string jsonString = JsonSerializer.Serialize(weatherForecast);
        Debug.Log(jsonString);
        return jsonString;
    }
}
