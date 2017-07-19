
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DeserializeXml
{
	class Program
	{
		static void Main(string[] args)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Ads));

			XmlDocument crm = new XmlDocument();
			crm.Load("http://novosel.itesc2.tmweb.ru/exports/crm.xml");
			StringReader reader = new StringReader(crm.InnerXml);
			var ads = (Ads)serializer.Deserialize(reader);
			reader.Close();			
		}
	}	
}
