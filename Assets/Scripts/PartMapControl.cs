using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartMapControl : MonoBehaviour
{
    private SpriteRenderer _compSpriteRenderer;
    private void Awake()
    {
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetSprite(Sprite sprite)
    {
        _compSpriteRenderer.sprite = sprite;
    }
}
