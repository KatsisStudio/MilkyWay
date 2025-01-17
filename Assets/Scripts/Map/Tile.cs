using CowMilking.Character;
using CowMilking.SO;
using UnityEngine;

namespace CowMilking
{
    public class Tile : MonoBehaviour
    {
        public TileContent TileContent { set; get; }
    }

    public class TileContent
    {
        public TileContent(GameObject obj, SpawnableInfo info, ICharacter character)
        {
            Object = obj;
            Info = info;
            Character = character;
        }

        public GameObject Object { private set; get; }
        public SpawnableInfo Info { private set; get; }
        public ICharacter Character { private set; get; }
    }
}
