using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DronController : MonoBehaviour
{
    public int Rutina;
    public float cronometro;
    public Quaternion angulo;
    public float grado;

    public void Comportamiento()
    {
        cronometro += 1 * Time.deltaTime;
        if (cronometro > 4)
        {
            Rutina = Random.Range(0, 2);
            cronometro = 0;
        }
        switch (Rutina)
        {
            case 1:
                grado = Random.Range(0, 360);
                angulo = Quaternion.Euler(0, grado, 0);
                Rutina++; break;

            case 2:
                transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                break;
        }
    }

    private void Update()
    {
        Comportamiento();
    }




}
