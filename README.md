
# The-Flying-Dutchman
The Flying Dutchman bot code for Skillz 2018


## Plans:

We assign the pirates accordingly (Maybe using priorities) we can use dectionaries to:
1) Capsule Pirate (Goes for the capsule)
2) Defender Pirate (Prevent enemies from getting points)
3) Helper Pirates (They either push enemy pirates, be ready to get the capsule after our capsule holder delivers it, assist our capsule holder)




- Find if there is a bunker 							bool IsThereABunker()
- How many pirates are there in the bunker					int NumOfPiratesInBunker()





### Attacking Pirates:
How to avoid the bunker : 
(We decide which one to use according to the number of enemy pirates in the bunker, and the distant of our helper friendly pirate)

- Friendly pirate to push over the bunker					
- Avoid the bunker								void Avoid(Location ourLocation, Location avoidLocation)
- Push pirates away from the bunker

if there isn't a bunker						


### Defending Pirates:
- A bunker that can move according to the situation (at least 2 pirates)
- Helper pirates that make the job for the defenders easier (they either knock down the enemy pirate capsule holder escorts 
	or stand in the way of the capsule holder so his escorts waste their push on them)



### Push Mechanics:
- Push accordingly (This functinon uses all the below ones)

- A function that decides the best direction to push a pirate      		Location BestDirection(Pirate p1, Pirate p2)
- A function that decides whether it's best for the pirate to push or not	bool CanPush(Pirate p)

private void pushInTheBestWay(Pirate p1, Pirate p2)
{
     if(p1.canPush(p2))
     {
         if (p2.HasCapsule())
	 {
	     p1.Push(p2, game.GetEnemyMothership().Location.Towards(p2, game.PushRange * 2)
	 }
	 else
	 {
	     p1.push(enemy, GetOutsideBorder(enemy.Location));
	 }
      }
}
(GetOutsideBorder function is already written in web kit)
