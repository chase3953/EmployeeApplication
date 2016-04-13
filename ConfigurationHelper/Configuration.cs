using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace ConfigurationHelper
{
    public class Configuration
    {
        public static String GetConnectionString(String name)
        {
            String result = String.Empty;
            String baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            String filePath = Path.Combine(baseDirectory, "DataSystems.config");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlNodeList nodeList = xmlDoc.SelectNodes("/configuration/connectionStrings/add");
            foreach (XmlNode node in nodeList)
            {
                if (node.Attributes["name"].Value.ToString().ToUpper() == name.ToUpper())
                {
                    result = node.Attributes["connectionString"].Value;
                    break;
                }
            }

            return result;
        }
    }
}
