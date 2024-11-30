using System;
using UnityEngine;
public class ColorObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData colorData;
    private SpriteRenderer spriteRenderer;
    static public Action<Color> OnChangeColor;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        spriteRenderer.color=colorData.color;
        spriteRenderer.sprite=colorData.sprite;
    }

    private void SetUp()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnChangeColor?.Invoke(colorData.color);
        }
    }
}
