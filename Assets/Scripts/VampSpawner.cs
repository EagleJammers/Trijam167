using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VampSpawner : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    [Tooltip("the vampire this spawner will spawn")]
    [SerializeField] private GameObject vamp;

    [Tooltip("how often to spawn vampire.")]
    [SerializeField] private float spawn_interval = 10f;

    [Tooltip("how wide is the box the player is in? so we dont spawn things outside of it.")]
    [SerializeField] private float world_width;
    [Tooltip("how tall is the box the player is in? so we dont spawn things outside of it.")]
    [SerializeField] private float world_height;

    //keep track of when we last spawned a vampire
    private float since_last_spawn = 0;

    // This script will simply instantiate the given vampire prefab
    void spawn_vamp()
    {
        // Instantiate at random position within world bounds, with zero rotation.

        Vector3 random_pos = new Vector3(Random.Range(world_width / -2, world_width / 2), Random.Range(world_height / -2, world_height / 2), 0);

        Instantiate(vamp, random_pos, Quaternion.identity);
    }

    void Update()
    {
        since_last_spawn += Time.deltaTime;
        //spawn a vampire every 10 seconds
        if (since_last_spawn > spawn_interval )
        {
            this.spawn_vamp();

            since_last_spawn -= spawn_interval;
        }
    }
}
