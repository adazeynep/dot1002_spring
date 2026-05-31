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
