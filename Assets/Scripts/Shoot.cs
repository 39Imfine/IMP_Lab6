using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private float forcePower = 10.0f;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform barrelLocation;
    private AudioSource audioSource;
    private bool shoot = false;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(shoot){
            GameObject go = Instantiate(bullet, barrelLocation.position, barrelLocation.rotation);
            Rigidbody rigidbody = go.GetComponent<Rigidbody>();

            rigidbody.AddForce(gameObject.transform.forward * forcePower, ForceMode.Impulse);
            audioSource.Play();

            Destroy(go, 2);

            shoot = false;
        }

    }

    public void Fire()
    {
        shoot = true;
    }
}
