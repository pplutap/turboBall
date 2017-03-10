using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform sphere;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = sphere.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 vector = new Vector3(0, 3f, -5f);
        float velocity = rigidbody.velocity.sqrMagnitude;
        vector = vector * (1f + velocity / 25f);

        Vector3 newPosition = sphere.position + vector;

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * 1f);
        transform.LookAt(sphere);
    }

    /*
    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
    */
}
