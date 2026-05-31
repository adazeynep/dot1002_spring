/*
User m = new User();
m.Age = 25;
m.Age =-5;
Console.WriteLine(m.Age);

class User
{
    private int _age;
    public int Age
    {
        get{return _age;}

        set
        {
            if (value>= 0 && value<= 150)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
*/
/*
public enum PlayerState
{
    Idle, Walking, Running, Attacking, TakingDamage, Dead
}
class Player
{
    public PlayerState currentState = PlayerState.Idle;
    public void UpdateState()
    {
        switch (currentState)
        {
            case PlayerState.Idle:
            Console.WriteLine("Breathing animation on. Waiting for the imput.");
            break;
            
            case PlayerState.Walking:
            Console.WriteLine("Moving the character at walking speed.");
            break;
            
            case PlayerState.Attacking:
            Console.WriteLine("Sword siwng animation is on.");
            break;

            case PlayerState.Dead:
            Console.WriteLine("Loading the amee over screen.");
            break;
        }
    }
}

class Program
{
    static void Main()
    {
        Player mainCharacter = new Player();
        mainCharacter.UpdateState();
        mainCharacter.currentState= PlayerState.Attacking;
        mainCharacter.UpdateState();
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        Player myPlayer = new Player();
        Enemy ifrit =new Enemy();
        WoodenCrate ammoBox = new WoodenCrate();
        ExplosiveBarrel redBarrel= new ExplosiveBarrel();
        string concreteWall = "I am just a wall.";

        myPlayer.Shoot(ifrit);
        myPlayer.Shoot(ammoBox);
        myPlayer.Shoot(redBarrel);
        myPlayer.Shoot(concreteWall);

    }
}

public interface IDamageable
{
    void TakeDamage(int damageAmount);
}
public class Enemy: IDamageable
{
    public int health=100;

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        Console.WriteLine($"Enemy took {damageAmount} dmg. Health is {health}.");

        if (health <= 0)
        {
            Console.WriteLine("Enemy plays death animation and drops loot.");
        }
    }
}

public class WoodenCrate : IDamageable
{
    public int durability =50;

    public void TakeDamage(int damageAmount)
    {
        durability-= damageAmount;
        Console.WriteLine($"Crate took {damageAmount} dmg.");

        if (durability < 0)
        {
            Console.WriteLine("Crate shatters into pieces.");
        }
    }
}

public class ExplosiveBarrel : IDamageable
{
    public void TakeDamage(int damageAmount){
    Console.WriteLine("KABOOM! Barrel dealing damage to everything.");
    }
}
public class Player
{
    public void Shoot(object targetHitByBullet)
    {
        Console.WriteLine("Player fires a shot.");
        if (targetHitByBullet is IDamageable damageableTarget)
        {
            damageableTarget.TakeDamage(25);
        }
        else
        {
            Console.WriteLine("The bullet hit something inestructible.");
        }
    }
}
*/
/*
using System;
public interface IInteractable
{
    void interact();
}

public class Door: IInteractable
{
    public void interact()
    {
        Console.WriteLine("The wooden door opens with a craking sound.");
    }
}
public class NPC: IInteractable
{
    public void interact()
    {
        Console.WriteLine("Greetings traveler! I have a new quest for you.");
    }
}
public class TreasureChest : IInteractable
{
    private bool _isOpened = false;
    public void interact()
    {
        if(_isOpened== false)
        {
            Console.WriteLine("You opened a chest! You found 100 Gold and a Legendary Sword.");
            _isOpened = true;
        }
        else
        {
            Console.WriteLine("The chest is already empty. Look  elsewhere.");
        }
    }
}
class Program
{
    static void Main()
    {
        Door d =new Door();
        TreasureChest chest =new TreasureChest();
        NPC villager = new NPC();

        List<IInteractable> interactablePlayer = new List<IInteractable>();
        interactablePlayer.Add(d);
        interactablePlayer.Add(chest);
        interactablePlayer.Add( villager);


        foreach(IInteractable item in interactablePlayer)
        {
            item.interact();
        }

        Console.WriteLine("\n--- Player interacts with the chest again.---");

        chest.interact();
    }
}
*/
