using System.Collections.Generic;
using UnityEngine;

public abstract class FlockBehavior : ScriptableObject
{
    public abstract Vector3 CalculateMove(Boid boid, List<Transform> context, Flock flock); //context means other Boids or obstacles
}




