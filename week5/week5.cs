//task1
using System.Diagnostics;
using System.Security;
using Microsoft.CSharp.RuntimeBinder;

void PlaySound(AudioClip clip)
{
    AudioSource audio = GetComponent<AudioSource>();
    audio.clip= clip;
    audioPlay();
}

void Jump()
{
    PlaySound(jumpSound);
    rb.velocity = Vector2.up * jumpForce;
}

void Shoot()
{
    PlaySound(shootSound);
    Instantiate(bullet);
}

//task2

public Text goldText;
public Text crystalText;
public Text foodText;
public Text woodText;

void UpdateResource(TextReader targetText, int amount)
{
    targetText.text = "Amount: " + amount.ToString();
}

//task3

public class HealthPotion
{
    public int healAmount = 10;

    public void Consume(Player player)
    {
        player.Heal(healAmount);
    }

}


//task4

public class CollectibleDot
{
    public int pointValue = 10;

    public void Collect(Player player)
    {
        player.AddScore(pointValue);
        Debug.Log("Dot collected!");
    }
}

//task5

public bool IsPlayerDead()
{
    return HealthPotion <= 0;
}

//task6

List<int> startingLevels = new List<int> { 1, 2, 3 };

void Start() {
   
}