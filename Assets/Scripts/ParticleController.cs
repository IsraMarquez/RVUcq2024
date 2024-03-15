using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem particleEnergy;

    void Start()
    {
        // Desactivar el sistema de partículas al inicio del juego
        particleEnergy.Stop();
    }

    public void ActivateParticles()
    {
        // Activar el sistema de partículas
        particleEnergy.Play();
    }

    public void DeactivateParticles()
    {
        // Desactivar el sistema de partículas
        particleEnergy.Stop();
    }
}
