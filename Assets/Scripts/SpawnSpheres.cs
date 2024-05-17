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
    private List<GameObject> invisibleSpheres = new List<GameObject>();
    void Start()
    {
        float planeSize = Data.Instance.playAreaSize;
        spawnPosition1 = new Vector3(-planeSize * 5, 1.4f, -planeSize * 5);
        spawnPosition2 = new Vector3(planeSize * 5, 5, planeSize * 5);
        Debug.Log("Spawnpos1 "+spawnPosition1);
        Debug.Log("spawnpos2 "+spawnPosition2);
        // Sätter en timer som kör spawnSphere varje 0.5 sekund
        InvokeRepeating("spawnSphere", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject sphere in invisibleSpheres)
        {
            Color color = sphere.GetComponent<Renderer>().material.color;
            color.a += 0.05f;
            sphere.GetComponent<Renderer>().material.color = color;
            if (color.a >= 1)
            {
                invisibleSpheres.Remove(sphere);
            }
        }
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
        sphere.GetComponent<Rigidbody>().useGravity = true;
        float scale = Random.Range(0.3f, 0.9f);
        sphere.transform.localScale = new Vector3(scale,scale,scale);
        sphere.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0.05f, 0.1f), 1, 1);
        Color color = sphere.GetComponent<Renderer>().material.color;
        color.a = 0;
        sphere.GetComponent<Renderer>().material.color = color;
        invisibleSpheres.Add(sphere);
    }
}
