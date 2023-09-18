using System.Collections.Generic;
using System.Timers;

namespace Tamagotchi.Models
{
  public class Pets
  {
    public string Name { get; set; }
    public int FoodStatus { get; set; }
    public int AttentionStatus { get; set; }
    public int RestStatus { get; set; }

    public bool IsAlive { get; private set; } = true;

    private Timer _foodTimer;


    private static Pets _instance;

    public Pets(string name, int foodStatus, int attentionStatus, int restStatus)
    {
      Name = name;
      FoodStatus = foodStatus;
      AttentionStatus = attentionStatus;
      RestStatus = restStatus;
      _instance = this;

      _foodTimer = new Timer(30000);
      _foodTimer.Elapsed += Hunger;
      _foodTimer.AutoReset = true;
      _foodTimer.Enabled = true;
    }

    public static Pets GetInstance()
    {
      return _instance;
    }
    private void Hunger(object sender, ElapsedEventArgs e)
    {

      if (FoodStatus > 0)
      {
        FoodStatus -= 1;
      }
      else
      {
        FoodStatus = 0;
        IsAlive = false;
        _foodTimer.Stop();
      }
    }

    public void FeedPet()
    {
      if (IsAlive)
      {
        FoodStatus += 1;
      }
    }

    public int GetHunger()
    {
      Pets newPet = GetInstance();
      if (newPet != null)
      {
        return newPet.FoodStatus;
      }
      else
      {
        return 0;
      }
    }

  }
}