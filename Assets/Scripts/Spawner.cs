using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject patientPrefab;
    [SerializeField] float destroyTime = 1f;
    GameObject prevPatient;
    void Start()
    {
        ProgressBar.Completed += OnProgressCompleted;
        SpawnPatient();
    }

    void OnProgressCompleted() {
        if (prevPatient) {
            prevPatient.GetComponent<Animator>().SetBool("isHealthy", true);
            prevPatient.gameObject.GetComponent<Patient>().MakeHealthy();
            Destroy(prevPatient, destroyTime);
        }
        SpawnPatient();
    }

    void SpawnPatient() {
        prevPatient = (GameObject)Instantiate(patientPrefab);
    }
}
