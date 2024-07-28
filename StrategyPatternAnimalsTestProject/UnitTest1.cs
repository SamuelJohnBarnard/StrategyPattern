using StrategyPatternAnimalsCorrect;

namespace StrategyPatternAnimalsTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void AnimalsShouldHave_CorrectSwimmingBehaviour() //need to refactor this to a theory test
        {
            //Arrange

            EmperorPenguin emperorPenguin = new EmperorPenguin();
            BlueWhale blueWhale = new BlueWhale();
            WanderingAlbatross wanderingAlbatross = new WanderingAlbatross();

            string flyingBirdSwimmingBehaviour = "This animal briefly swims through the ocean to catch a fish";
            string genericSwimmingBehaviour = "This animal swims quickly through the ocean";

            //Act

            string emperorPenguinSwimmingBehaviour = emperorPenguin.Swim();
            string blueWhaleSwimmingBehaviour = blueWhale.Swim();
            string wanderingAlbatrossSwimmingBehaviour = wanderingAlbatross.Swim();

            //Assert

            Assert.Equal(flyingBirdSwimmingBehaviour, wanderingAlbatrossSwimmingBehaviour);
            Assert.Equal(genericSwimmingBehaviour, blueWhaleSwimmingBehaviour);
            Assert.Equal(genericSwimmingBehaviour, emperorPenguinSwimmingBehaviour);
            
        }

        //Can do equivalent for Walking and Flying behaviours
    }
}