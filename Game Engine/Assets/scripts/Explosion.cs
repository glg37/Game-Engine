using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float TimeToDesactive;
    // Start is called before the first frame update
   IEnumerator Start()
    {
        yield return new WaitForSeconds(TimeToDesactive);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DesactiveObject()
    {
        yield return new WaitForSeconds(0.5f);
    }
}
