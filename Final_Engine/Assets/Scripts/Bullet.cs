using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static Bullet instance;

    InputActions InputAction;

    Vector2 move;


    private void OnEnable()
    {
        InputAction.Player.Enable();
    }

    private void OnDisable()
    {
        InputAction.Player.Disable();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        InputAction = new InputActions();

        InputAction.Player.Movement.performed += cntxt => move = cntxt.ReadValue<Vector2>();
        InputAction.Player.Movement.canceled += cntxt => move = Vector2.zero;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * move.y * Time.deltaTime, Space.Self);
    }



}
