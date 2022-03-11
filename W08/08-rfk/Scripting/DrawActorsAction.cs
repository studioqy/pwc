using System.Collections.Generic;
using _08_rfk.Casting;
using _08_rfk.Services;


namespace _08_rfk.Scripting
{
    // TODO: Add your class here to draw all the actors in the game
    // making use of the OutputService object.
    public class DrawActorsAction : Action
    {
        OutputService _outputService;
        private List<Actor> actorsList = new List<Actor>();

        public DrawActorsAction(OutputService outputService) {
            _outputService = outputService;
        }
    
        public override void Execute(Dictionary<string, List<Actor>> cast) {
            _outputService.StartDrawing();
            foreach (List<Actor> group in cast.Values) {
                // actorsList.Add()
                _outputService.DrawActors(group);
            }
            _outputService.EndDrawing();

            // actorsList = 
            // _outputService.DrawActors(cast.Values);
        }
    }
}