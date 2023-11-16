using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Xml;

namespace GeoMapGameLabor3
{
    internal class PlayerClass
    {
        string playerName;
        int score;
        int time;
        double KD;

        XmlDocument xDoc = new XmlDocument();


        public PlayerClass(string PlayerName, int Score, int Time)
        {
            playerName = PlayerName;
            score = Score;
            time = Time;
            KD = time / score;
        }

        public double Score()
        {

            return KD;
        }
        public void addingToList() //добавляет в документ игроков https://metanit.com/sharp/tutorial/16.2.php
        {
            xDoc.Load("players.xml");
            XmlElement? xRoot = xDoc.DocumentElement;
            XmlElement personElem = xDoc.CreateElement("player");
            XmlAttribute nameAttr = xDoc.CreateAttribute("PlayerName");
            XmlElement scoreElem = xDoc.CreateElement("Score");
            XmlElement timeElem = xDoc.CreateElement("Time");
            XmlElement kdElem = xDoc.CreateElement("KD");
            XmlText nameText = xDoc.CreateTextNode(playerName);
            XmlText scoreText = xDoc.CreateTextNode(score.ToString());
            XmlText timeText = xDoc.CreateTextNode(time.ToString());
            XmlText kdText = xDoc.CreateTextNode(KD.ToString());
            nameAttr.AppendChild(nameText);
            scoreElem.AppendChild(scoreText);
            timeElem.AppendChild(timeText);
            kdElem.AppendChild(kdText);
            personElem.Attributes.Append(nameAttr);
            personElem.AppendChild(scoreElem);
            personElem.AppendChild(timeElem);
            personElem.AppendChild(kdElem);

            xRoot?.AppendChild(personElem);
            xDoc.Save("players.xml");
        }

        public void addingToTablePlayers() //добавляет в таблицу игроков когда пользователь смотрит таблицу, таблица показывает по очкам KD. От наибольшего, к наименьшему
        {

        }

    }
}