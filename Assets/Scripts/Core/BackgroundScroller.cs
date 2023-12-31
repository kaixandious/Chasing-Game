using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Range(-1f,1f)]
    public float scrollSpeed = 1f;
    private float offset;
    private Material mater;
    // Start is called before the first frame update
    void Start()
    {
        mater = GetComponent<Renderer>().material;  
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mater.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
