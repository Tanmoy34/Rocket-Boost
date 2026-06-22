using UnityEngine;
using UnityEngine.InputSystem;

public class Quit : MonoBehaviour
{

    

    void Start()
    {
        

    }





    void Update()
    {
        if (Keyboard.current.escapeKey.isPressed)
        {
            Debug.Log("quit is called From their");
            Application.Quit();
        }
    }
}
