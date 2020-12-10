using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float offset;

    public GameObject bullet;

    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 addedPos = new Vector3(0.0f, 1f, 0.0f);

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(bullet, shotPoint.position + addedPos, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else 
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
