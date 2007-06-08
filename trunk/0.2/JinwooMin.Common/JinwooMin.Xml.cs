using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using JinwooMin.Logging;

namespace JinwooMin.Xml
{
    public class TreeViewXmlSerializer
    {
        public static void SaveToXml(ILogger logger, string filename, Type rootNodeType, object rootNode)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            XmlTextWriter writer = new XmlTextWriter(fs, new UTF8Encoding());
            writer.Formatting = Formatting.Indented;
            XmlSerializer serializer = new XmlSerializer(rootNodeType);
            try
            {
                try
                {
                    serializer.Serialize(fs, rootNode);

                }
                catch (Exception e)
                {
                    logger.Error(e.Message);
                }
            }
            finally
            {
                writer.Close();
                fs.Close();
            }
        }

        public static object LoadFromXml(ILogger logger, string filename, Type rootNodeType)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlTextReader reader = new XmlTextReader(fs);
            XmlSerializer serializer = new XmlSerializer(rootNodeType);
            try
            {
                try
                {
                    return serializer.Deserialize(reader);
                }
                catch (Exception e)
                {
                    logger.Error(e.Message);
                }

            }
            finally
            {
                reader.Close();
                fs.Close();
            }

            return null;
        }
    }
}
