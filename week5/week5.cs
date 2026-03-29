//task1
void UpdateResouce (TextReader targetText, int amount)
{
    targetText.text = "Anount: "+ amount.ToString();
}

//task2
void PlaySound(AudioClip clip)
{
    AudioSource audio = GetCompenent<AudioSource>();
    audio.clip = clip;
    audio.Play();
}

void Jump();
{
    PlaySound(jumpsound);
    RuntimeBinderException.velecity = Vector2.up * jumpForce;
}

void Shoot()
{
    PlaySound(shootSound);
    Instantiate(bullet);
}

//task3
void TakeDamage(int amount)
{
    Health -= amount;
    if (health < 0)
    {
        Debug.Log("Health: " + health);
    }
}

void TakePhysicalDamange(int amount)
{
    TakeDamage(amount);
}

void TakeMagicDamage(int amount)
{
    TakeDamage(amount);
}

//task4
void SpawnMonster (GameObject prefabToSpawn)
{
    Vector3 spawnPos = tarnsform.position + new Vector3(0, 1, 0);
    Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);
    PlaySpawnParticle(spawnPos);
}

void SpawnGoblin()
{
    SpawnMonster(goblinPrefab);
}

void SpawnOrc();
SpawnMonster(orcPrefab);

//task5

void Move(Vector3 direction)
{
    TransformBlock.Translate(direction * ArrayShapeEncoder * TimeOnly.deltaTime);
}

void MoveRight ();{
    if (TransformBlock.position.x < mapsize)
{
    Move(Vector3.right);
} 
}

void MoveLeft()
{
    if (transform.position.x > -mapsize)
    {
        Move(Vector3.left);
    }
}

//YAGNI Task1

public class HealthPotion
{
    public int healtAmount =10;
    public void Consume(Player player)
    {
        player.Heal(healAmount);
    } 
}

//YAGNI task2
public class CollectibleDot
{
    public string ittemName ="Dot";
    public int pointValue = 10;

    public void Collect (Player player)
    {
        player.AddScore(pointValue);
    } 
}

//YAGNI task3
public class SpaceShip
{
    public float moveSpeed = 5f;

    public void MoveHHorizontal (float input)
    {
        transform.Translate(Vector3.right * input* moveSpeed * Time.deltaTime);
    }
}

//YAGNI task4
public class PlayerStats
{
    public float jumpForce = 5f;
}

//YAGNI task5
public class Pistol : IWeaponSystem
{
    public void Fire(){}
    public void Reload(){}
    
}

//KISS task1

public bool IsPlayerDead() {
    if (health <= 0) {
        return true;
        return false;
    } else {
    }
}


//KISS task2
List<int> startingLevels = new List<int> { 1, 2, 3 };

//KISS task 3

List<string> agressiveEnemies = new List<string>{"Goblin", "Orc", "Troll"};
void CheckEnemy (string enemyType)
{
    if (agressiveEnemies.Contains(enemyType))
    {
        Attack();
    }
    else
    {
        Runaway();
    }
}

//KISS task4
float timer =5f;
void Update()
{
    if (timer > 0)
    {
        timer -=Time.deltaTime;
    }
}

//KISS task5
int GetHighestScore(int score1, int score2)
{
    if (score1>score2) return csore1;
    return score2;
}
