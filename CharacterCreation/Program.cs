namespace CharacterCreation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            CharacterClass firstCharacter = new CharacterClass("Aria", "Warrior");
            CharacterClass secondCharacter = new CharacterClass("Lennon", "Mage");
            CharacterClass thirdCharacter = new CharacterClass("Pythoas", "Astronomer");

            firstCharacter.DisplayInfo();
            secondCharacter.DisplayInfo();
            thirdCharacter.DisplayInfo();

            PathDecision[] pathDecisions = new PathDecision[]
            {
               new PathDecision(
                    "The party find a tree soon after they enter the forest. What will you do at the tree?",
                    new string[] {"Pray to the tree", "Strike the tree", "Go around the tree", "Rest at the tree"}
                    ),

                new PathDecision(
                    "The party find a river soon after they enter the forest. What will you do at the river?",
                    new string[] {"Swim across", "Build a raft", "Look for a bridge", "Rest by the river"}
                    ),
                new PathDecision(
                    "The party find a cave soon after they enter the forest. What will you do at the cave?",
                    new string[] {"Enter the cave", "Light a fire outside", "Look for another way", "Rest at the cave"}
                    )
            };

            Adventure myAdventure = new Adventure(pathDecisions);
            myAdventure.StartAdventure();
           

        }
    }
}




