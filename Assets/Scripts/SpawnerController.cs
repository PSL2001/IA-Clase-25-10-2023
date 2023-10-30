using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject Robot;

    public int ancho;
    public int largo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn() 
    {
        yield return new WaitForSeconds(5.0f);

        while (true)
        {
            int x = Random.Range(0, ancho + 1);
            int z = Random.Range(0, largo + 1);

            yield return new WaitForEndOfFrame();
        }
    }
}
