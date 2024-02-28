using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandle : MonoBehaviour
{
    #region Public Field
    public GameController gameControler;
    #endregion
    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        InputSystem.EnableDevice(Keyboard.current);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Private Methods
    private void OnEnable()
    {
        //
    }
    #endregion
}
