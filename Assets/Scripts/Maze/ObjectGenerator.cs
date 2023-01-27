using Object;

namespace Maze
{
    public static class ObjectGenerator
    {
        public static ObjectModel[] Generate(int count, int lengthByX, int lengthByZ)
        {
            var objects = new ObjectModel[count];
            var counter = 0;
            
            do
            { 
                var x = UnityEngine.Random.Range(0, lengthByX - 1);
                var z = UnityEngine.Random.Range(0, lengthByZ - 1);

                if(CheckerPosition(objects, x, z))
                {
                    objects[counter] = new ObjectModel()
                    {
                        PositionX = x,
                        PositionZ = z,
                        Type = ((TypeObject) UnityEngine.Random.Range(0, 2))
                    };

                    counter++;
                }
                
            } while (counter < count);
            
            return objects;
        }

        private static bool CheckerPosition(ObjectModel[] coins, int x, int z)
        {
            var isIdentity = true;
            
            foreach (var coin in coins)
            {
                if (coin != null)
                {
                    if (x == 0 && z == 0) isIdentity = false;
                    if (x == coin.PositionX && z == coin.PositionZ) isIdentity = false;
                }
            }
            
            return isIdentity;
        }
    }
}