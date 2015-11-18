﻿using UnityEngine;
using UnityEngine.UI;

using System.Collections.Generic;
using System.Xml;

public class DialogManager : MonoBehaviour
{

    public TextAsset Text_Asset;

    void OnEnable()
    {
        if (Text_Asset == null) throw new System.Exception("Text_Asset not defined on Binder Script!");

        XmlDocument xd = new XmlDocument();
        xd.LoadXml(Text_Asset.text);

        if (xd.DocumentElement.HasChildNodes)
        {
            Dictionary<string, Text> textComponents = new Dictionary<string, Text>(2);
            Text[] t = gameObject.GetComponentsInChildren<Text>();

            foreach (Text itm in t)
                textComponents.Add(itm.name, itm);

            foreach (XmlNode node in xd.DocumentElement.ChildNodes)
            {
                if (textComponents.ContainsKey(node.Name))
                    textComponents[node.Name].text = node.InnerText;
            }
        }
    }
}