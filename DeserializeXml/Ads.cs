using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeXml
{

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Ads
	{

		private AdsAD[] adField;

		private byte formatVersionField;

		private string targetField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Ad")]
		public AdsAD[] Ad
		{
			get
			{
				return this.adField;
			}
			set
			{
				this.adField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte formatVersion
		{
			get
			{
				return this.formatVersionField;
			}
			set
			{
				this.formatVersionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class AdsAD
	{

		private uint idField;

		private string categoryField;

		private string operationTypeField;

		private System.DateTime dateBeginField;

		private string regionField;

		private string cityField;

		private string streetField;

		private string descriptionField;

		private uint priceField;

		private string managerNameField;

		private long contactPhoneField;

		private AdsADImage[] imagesField;

		private byte roomsField;

		private decimal squareField;

		private decimal livingSpaceField;

		private byte floorField;

		private byte floorsField;

		private string houseTypeField;

		private string marketTypeField;

		private string phonecustomerField;

		private string fiocustomerField;

		/// <remarks/>
		public uint Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks/>
		public string Category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}

		/// <remarks/>
		public string OperationType
		{
			get
			{
				return this.operationTypeField;
			}
			set
			{
				this.operationTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime DateBegin
		{
			get
			{
				return this.dateBeginField;
			}
			set
			{
				this.dateBeginField = value;
			}
		}

		/// <remarks/>
		public string Region
		{
			get
			{
				return this.regionField;
			}
			set
			{
				this.regionField = value;
			}
		}

		/// <remarks/>
		public string City
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
			}
		}

		/// <remarks/>
		public string Street
		{
			get
			{
				return this.streetField;
			}
			set
			{
				this.streetField = value;
			}
		}

		/// <remarks/>
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		public uint Price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
			}
		}

		/// <remarks/>
		public string ManagerName
		{
			get
			{
				return this.managerNameField;
			}
			set
			{
				this.managerNameField = value;
			}
		}

		/// <remarks/>
		public long ContactPhone
		{
			get
			{
				return this.contactPhoneField;
			}
			set
			{
				this.contactPhoneField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("Image", IsNullable = false)]
		public AdsADImage[] Images
		{
			get
			{
				return this.imagesField;
			}
			set
			{
				this.imagesField = value;
			}
		}

		/// <remarks/>
		public byte Rooms
		{
			get
			{
				return this.roomsField;
			}
			set
			{
				this.roomsField = value;
			}
		}

		/// <remarks/>
		public decimal Square
		{
			get
			{
				return this.squareField;
			}
			set
			{
				this.squareField = value;
			}
		}

		/// <remarks/>
		public decimal LivingSpace
		{
			get
			{
				return this.livingSpaceField;
			}
			set
			{
				this.livingSpaceField = value;
			}
		}

		/// <remarks/>
		public byte Floor
		{
			get
			{
				return this.floorField;
			}
			set
			{
				this.floorField = value;
			}
		}

		/// <remarks/>
		public byte Floors
		{
			get
			{
				return this.floorsField;
			}
			set
			{
				this.floorsField = value;
			}
		}

		/// <remarks/>
		public string HouseType
		{
			get
			{
				return this.houseTypeField;
			}
			set
			{
				this.houseTypeField = value;
			}
		}

		/// <remarks/>
		public string MarketType
		{
			get
			{
				return this.marketTypeField;
			}
			set
			{
				this.marketTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("phone-customer")]
		public string phonecustomer
		{
			get
			{
				return this.phonecustomerField;
			}
			set
			{
				this.phonecustomerField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("fio-customer")]
		public string fiocustomer
		{
			get
			{
				return this.fiocustomerField;
			}
			set
			{
				this.fiocustomerField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class AdsADImage
	{

		private string urlField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}
	}


}
