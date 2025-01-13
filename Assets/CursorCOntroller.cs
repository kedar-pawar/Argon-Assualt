using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    // Serialize the cursor state to change it easily from the inspector
    [SerializeField] CursorLockMode cursorState = CursorLockMode.Locked;

    void Start()
    {
        Cursorsetter();
    }

    void Cursorsetter()
    {
        // Set the cursor lock state based on the serialized value
        Cursor.lockState = cursorState;
        
    }
}
