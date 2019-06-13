using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TTNN_gameLine98
{
    class SaveAndLoad
    {
        public static void saveGame(GameShape g, string filename)
        {
            Stream s = File.Open(filename, FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, g);
            s.Close();
        }

        public static GameShape loadGame(string filename)
        {
            Stream s = File.Open(filename, FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            GameShape g = (GameShape)b.Deserialize(s);
            s.Close();
            return g;
        }
    }
}
