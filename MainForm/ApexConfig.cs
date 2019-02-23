using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace ApexConfiguration
{
    static class ApexConfig
    {
        const string PreConfigListUrl = "https://coldthunder11.com/ApexConfiguration/HotUpdate/PreConfigList.txt";
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
        public static void CheckPreConfigUpdate()
        {
            var request = WebRequest.Create(PreConfigListUrl) as HttpWebRequest;
            request.ProtocolVersion = HttpVersion.Version10;
            var response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string versionString = reader.ReadToEnd();
        }
    }
}
