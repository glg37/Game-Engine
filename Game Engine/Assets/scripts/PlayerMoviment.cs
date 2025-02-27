using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMoviment : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speedx = 5;
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
            rb.AddForce((new Vector2(0, -swimStrength*2)));
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, jumpStrength));
        }
    }
    private void FixedUpdate()//F�sica
    {
        rb.velocity = new Vector2(horizontal * speedx, rb.velocity.y); 
    }
    private void LateUpdate()//C�mera
    {
        
    }
    private void OnEnable()//quando o c�digo � ativado 
    {//�nico inicializador que � chamado mais de uma vez 
        
    }
}
