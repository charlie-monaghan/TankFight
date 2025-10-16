using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private GameObject player1Prefab;
    [SerializeField] private GameObject player2Prefab;

    [SerializeField] private GameObject player1SpawnPoint;
    [SerializeField] private GameObject player2SpawnPoint;

    [SerializeField] private TMP_Text p1Text;
    [SerializeField] private TMP_Text p2Text;

    private int p1Score = 0;
    private int p2Score = 0;

    void Start()
    {
        if(player1 == null || player2 == null)
        {
            Debug.LogError("One or more player references missing.");
        }

    }

    void Update()
    {
        if (player1 == null)
        {
            p2Score++;
            UpdateScore(player2, p2Text, p2Score);
            RespawnPlayers();

        }
        else if (player2 == null)
        {
            p1Score++;
            UpdateScore(player1, p1Text, p1Score);
            RespawnPlayers();

        }
    }

    private void UpdateScore(GameObject winner, TMP_Text winnerText, int winnerScore)
    {
        winnerText.text = winnerScore.ToString();
        Destroy(winner);
    }

    private void RespawnPlayers()
    {
        player1 = Instantiate(player1Prefab, player1SpawnPoint.transform.position, Quaternion.identity);
        player2 = Instantiate(player2Prefab, player2SpawnPoint.transform.position, Quaternion.identity);
    }
}
