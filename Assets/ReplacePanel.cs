using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplacePanel : MonoBehaviour
{
    [SerializeField]
    GameObject breakingModel;

    [SerializeField]
    GameObject ground;

    [SerializeField]
    GameObject Doors;

    [SerializeField]
    GameObject panel;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        GameObject tmp = Instantiate(breakingModel, transform.position, Quaternion.identity);
        Destroy(gameObject);

        Destroy(tmp, 3.0f);

        Instantiate(ground, transform.localPosition + new Vector3(7.5f, -2, 40), Quaternion.identity);
        Instantiate(Doors, transform.localPosition + new Vector3(7.5f, -2, 40), Quaternion.identity);
        Instantiate(panel, transform.localPosition + new Vector3(0, 0, 40), Quaternion.identity);
    }
}
