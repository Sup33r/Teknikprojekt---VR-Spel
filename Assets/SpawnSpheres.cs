using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpheres : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Referensen till prefabben
    public GameObject spherePrefab;

    // Referensen till positionerna där punkterna ska kunna spawna
    public Vector3 spawnPosition1;
    public Vector3 spawnPosition2;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Metod för att spawna ett klot
    public void spawnSphere()
    {
        // Skapa en kopia av prefabben
        GameObject sphere = Instantiate(spherePrefab);

        // Randomisera en position mellan spawnPosition1 och spawnPosition2
        Vector3 randomPosition = new Vector3(Random.Range(spawnPosition1.x, spawnPosition2.x), Random.Range(spawnPosition1.y, spawnPosition2.y), Random.Range(spawnPosition1.z, spawnPosition2.z));

        // Sätter värden på klotet
        sphere.transform.position = randomPosition;
        sphere.GetComponent<Rigidbody>().drag = Random.Range(2, 7);
        float scale = Random.Range(0.3f, 0.9f);
        sphere.transform.localScale = new Vector3(scale,scale,scale);
        sphere.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0.05f, 0.1f), 1, 1);
    }
}
