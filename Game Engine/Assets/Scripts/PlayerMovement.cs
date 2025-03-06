using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speedX = 5;
    [SerializeField] float jumpStrength = 200;
    [SerializeField] float swimStrength = 250;
    float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Fire3"))
        {
            rb.AddForce(new Vector2(0, -swimStrength));
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, jumpStrength));
        }

    }
    private void FixedUpdate()//F�sica
    {
        if(horizontal !=0)
        rb.velocity = new Vector2 (horizontal * speedX, rb.velocity.y);
    }
    private void LateUpdate()//C�mera
    {
        
    }
    private void OnDisable()//Quando � desabilitado
    {
        
    }
    private void OnDestroy()//N�O USAR PARA INSTANCIAR OBJETOS
    {
        
    }
    private void OnBecameInvisible()
    {
        
    }
    private void OnBecameVisible()
    {
        
    }
    private void OnMouseDown()
    {
        
    }
    private void OnMouseDrag()//� atualizado constantemente
    {
        
    }
    private void OnMouseEnter()
    {
        
    }
    private void OnMouseExit()
    {
        
    }
    private void OnMouseOver()//� atualizado constantemente
    {
        
    }
    private void OnMouseUp()
    {
        
    }
}
