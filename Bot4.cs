using System.Collections.Generic;
using System.Text;
using System.Linq;
using Pirates;

namespace Bot 
{
    class Bot4 : IPirateBot
    {

        private PirateGame game;
        private const bool Debug = true;
        private List<Pirate> myPirates;

        private List<Capsule> myCapsules;
        
        private List<Mothership> myMotherships;
        public void DoTurn(PirateGame game)
        {
            Initialize(game);
        }

        private void Initialize(PirateGame game)
        {
            this.game=game;
        }

        private void MovePirates()
        {
            
        }
    }

}