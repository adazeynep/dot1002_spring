/*
public interface IEnemy
{
    int CalculateDamage();
}

public class Goblin: IEnemy
{
    public int CalculateDamage() => 25;
}
public class Orc : IEnemy
{
    public int  CalculateDamage()=> 10;
}
public class Dragon : IEnemy
{
    public int CalculateDamage()=>100;
}
public class DamageCalculator
{
    public int GetDamage(IEnemy enemy)
    {
        return enemy.CalculateDamagge();
    }
}
*/
/*
public interface IMovable
{
    void MoveForward();
}
public interface IAttackable
{
    void Attack();
}

public class Player: IMovable, IAttackable
{
    public void MoveForward() => Console.WriteLine("The player swings a sword.");
}
public class StationaryTurret : IAttackable
{
    public void Attack()=> Console.WriteLine("The turret fires.");
}
*/
/*public interface ISaveSystem
{
    void SaveGame();
}
public class LocalDiskSaver : ISaveSystem
{
    public void SaveGame()=> Console.WriteLine("Game saved to local disk.");
}
public class CloudSaver : ISaveSystem
{
    public void SaveGame()=> Console.WriteLine("The game uploaded to the cloud.");
}
public class GameManager
{
    private readonly ISaveSystem _saveSystem;

    public GameManager(ISaveSystem saveSystem)
    {
        _saveSystem = saveSystem;
    }

    public void SaveProgress()
    {
        _saveSystem.SaveGame();
    }
}
*/
