using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // block
    public static GameManager instance;
    //list for players below -->
    public List<PlayerController> players;
    public Transform playerSpawnTransform;

    // Awake is called when the object is first created - before even Start can run
    private void Awake ()
    {
        // if the instance doesnt exist yet -->
        if (instance == null) {
            // this is the instance here
            instance = this;
            // dont destroy it if we load new scene
            DontDestroyOnLoad(gameObject);
        }
        else {
            // otherwise there is already an instance, so destroy this gameObject
            Destroy(gameObject);
        }
       
    }
        private void Start()
        {
        //temporary spawn code for now (change later)
        SpawnPlayer();
        }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlayer()
    {
        //spawn the player controller at (0,0,0) with no rotation
        GameObject newPlayerObj = Instantiate(playerControllerPrefab, Vector3.zero, Quaternion.identity) as GameObject;

        //spawning the pawn --> connect to the controller
        GameObject newPawnObj = Instantiate(tankPawnPrefab, playerSpawnTransform.position, playerSpawnTransform.rotation) as GameObject;

        //Getting the player controller comp, and the pawn component here
        Controller newController = newPlayerObj.GetComponent<Controller>();
        Pawn newPawn = newPawnObj.GetComponent<Pawn>();

        //works them together here -->
        newController.pawn = newPawn; 
    }
    
    //Prefabs here -->
    public GameObject playerControllerPrefab;
    public GameObject tankPawnPrefab; 
}