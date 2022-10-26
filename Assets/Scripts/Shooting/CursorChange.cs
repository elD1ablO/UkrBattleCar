using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CursorChange : MonoBehaviour
{
    public static CursorChange instance;

    [SerializeField] public Texture2D cursorTexture;

    private void Awake()
    {
        instance = this;        
    }
    void Start()
    {
        Vector2 cursorHotspot = new Vector2(cursorTexture.width * 0.5f, cursorTexture.height * 0.5f);
        
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.ForceSoftware);

    }

    public void SetCursorColor(Color color)
    {
        cursorTexture.GetComponent<SpriteRenderer>().color = color;
    }
   
}
