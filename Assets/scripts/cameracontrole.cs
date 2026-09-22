using UnityEngine;

public class cameracontrole : MonoBehaviour
{
        public Transform PlayerTransform;
        private Vector3 PlayerPosition;

    void Start()
    {
        if(PlayerTransform !=null){
            PlayerPosition = PlayerTransform.position;
            transform.position = new Vector3(PlayerPosition.x, PlayerPosition.y, transform.position.z);
    }
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerTransform !=null){
            PlayerPosition = PlayerTransform.position;
            transform.position = new Vector3(PlayerPosition.x, PlayerPosition.y, transform.position.z);
    }
    }
        
    }

