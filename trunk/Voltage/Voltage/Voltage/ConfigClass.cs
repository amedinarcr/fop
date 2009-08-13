using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

namespace ConfigClass
{
    /// 
    /// ConfigClass 的摘要说明。
    /// 
    public class ConfigClass
    {

        public string configName;
        public string configValue;
        public ConfigClass()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public static string ReadConfig(string configKey)
        {
             string configValue = "";
            configValue = ConfigurationSettings.AppSettings["" + configKey + ""];
            return configValue;
        }



        public static void SaveConfig(string configKey, string configValue)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.ExecutablePath+".config");
            //找出名称为“add”的所有元素
            XmlNodeList nodes = doc.GetElementsByTagName("add");
            for (int i = 0; i < nodes.Count; i++)
            {
                //获得将当前元素的key属性
                XmlAttribute att = nodes[i].Attributes["key"];
                //根据元素的第一个属性来判断当前的元素是不是目标元素
                if (att.Value == "" + configKey + "")
                {
                    //对目标元素中的第二个属性赋值
                    att = nodes[i].Attributes["value"];
                    att.Value = configValue;
                    break;
                }
            }
            //保存上面的修改
            doc.Save(Application.ExecutablePath+".config");
        }
    }
}


