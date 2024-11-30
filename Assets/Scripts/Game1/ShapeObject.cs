using UnityEngine;
using System;
public class ShapeObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData shapeData;
    private SpriteRenderer spriteRenderer;
    static public event Action<Sprite> OnChangeShape;

    private void SetUp()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnChangeShape?.Invoke(shapeData.sprite);
        }
    }
}
