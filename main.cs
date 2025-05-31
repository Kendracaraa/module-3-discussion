public class Bunny

{

  public string Name;

  public bool LikesCarrots;

  public bool LikesHumans;



  public Bunny (

    string name,

    bool likesCarrots = false,

    bool likesHumans = false)

  {

    Name = name;

    LikesCarrots = likesCarrots;

    LikesHumans = likesHumans; 

  }

}

public class BabyBunny : Bunny
{
	public int NumSiblings;
    public string MotherName;
    
    public BabyBunny(
    string name,

    bool likesCarrots = false,

    bool likesHumans = false,
    int sibl;ings,
    string mother
    )
    {
    	Name = name;

      	LikesCarrots = likesCarrots;

      	LikesHumans = likesHumans; 
        NumSiblings = siblings;
        MotherName = mother;
        
    }
}

Bunny Mother = new Bunny("mom", true, false);

BabyBunny child = new BabyBunny("child 1", true, false, 3, "mom");