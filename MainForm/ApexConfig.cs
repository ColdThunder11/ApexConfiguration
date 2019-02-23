using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ApexConfiguration
{
    static class ApexConfig
    {
        public static Dictionary<string,string> Read2Dict(string[] configString)
        {
            var retDictionary = new Dictionary<string, string>();
            foreach (string t in configString)
            {
                if (t.Contains(@"		"))
                {
                    string[] kv = t.Split('	');
                    kv[1] = kv[1].Trim('\"');
                    kv[3] = kv[3].Trim('\"');
                    retDictionary.Add(kv[1], kv[3]);
                }
            }
            return retDictionary;
        }
        public static void WriteDict2File(Dictionary<string, string> config,string path)
        {
            var outStr = new List<string>
            {
                "\"VideoConfig\"",
                "{"
            };
            foreach (var t in config)
            {
                outStr.Add("	\"" + t.Key + "\"		\"" + t.Value + "\"");
            }
            outStr.Add("{");
            File.WriteAllLines(path, outStr);
        }
    }
}
