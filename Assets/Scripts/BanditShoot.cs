using System.Collections;
using UnityEngine;

public class BanditShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    private Vector3 firePoint;
    public float minAngle = 0.0f;
    public float maxAngle = 10.0f;
    public float shootingIntervalMin = 30.0f;
    public float shootingIntervalMax = 60.0f;
    public AudioClip shootingSound;
    public float bulletSpeed = 10.0f;

    private AudioSource audioSource;

    public Transform player;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(Wait());
        firePoint = this.transform.position + Vector3.up;
    }

    private void Update()
    {
        //Be sure to always face the player
        this.transform.LookAt(player.position);
    }
    void ShootAtPlayer()
    {
        //Set the direction vector for the player
        Vector3 directionToPlayer = (player.position + Vector3.up - firePoint).normalized;
        float randomAngle = Random.Range(minAngle, maxAngle);
        Vector3 randomDirection = Quaternion.Euler(0, Random.Range(-randomAngle, randomAngle), 0) * directionToPlayer;
        //Instantiate the bullet preform
        GameObject bullet = Instantiate(bulletPrefab, firePoint, Quaternion.Euler(90f, 0f, 0f));
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.velocity = randomDirection * bulletSpeed;
        audioSource.PlayOneShot(shootingSound);

    }

    IEnumerator Wait()
    {
        Debug.Log("Starting task");
        yield return new WaitForSeconds(Random.Range(10, 30));
        InvokeRepeating("ShootAtPlayer", 1f, Random.Range(shootingIntervalMin, shootingIntervalMax));
    }
}