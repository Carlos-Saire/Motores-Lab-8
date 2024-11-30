using UnityEngine;
using UnityEngine.UI;

public class ShapePanel : MonoBehaviour
{
    private Image ShapeImage;
    private void Awake()
    {
        ShapeImage = GetComponent<Image>();
    }
    private void UpdateShape(Sprite newShape)
    {
        ShapeImage.sprite = newShape;
    }
    private void OnEnable()
    {
        ShapeObject.OnChangeShape += UpdateShape;
    }
    private void OnDisable()
    {
        ShapeObject.OnChangeShape -= UpdateShape;
    }
}
