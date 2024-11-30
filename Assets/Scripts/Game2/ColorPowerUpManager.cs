using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorPowerUpManager : MonoBehaviour
{
    [SerializeField] private ColorData[] colors; 
    [SerializeField] private ColorData currentColor; 

    private int index = 0; 

    public static event Action<ColorData> OnChangeColor;
    public void OnPreviousColor(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            --index; 
            ChangeColorSelection();
        }
    }

   
    public void OnNextColor(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            ++index; 
            ChangeColorSelection();
        }
    }
    private void ChangeColorSelection()
    {
        if (index < 0)
        {
            index = colors.Length-1; 

        }
        else if (index >= colors.Length)
        {
            index = 0; 
        }
        currentColor = colors[index];
        OnChangeColor?.Invoke(currentColor);
    }

    
    private void ValidateCollision(ColorData enemyColor, int damage)
    {
        
    }

   
    private void ReturnToNormal()
    {
    }
}
