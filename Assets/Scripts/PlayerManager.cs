using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public List<GameObject> players;

    // Start is called before the first frame update
    void Start()
    {
        var player = GameObject.FindGameObjectsWithTag("Player");
        players.AddRange(player);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
