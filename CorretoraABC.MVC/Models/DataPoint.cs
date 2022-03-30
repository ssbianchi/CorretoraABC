using System.Runtime.Serialization;

namespace CorretoraABC.MVC.Models
{
	[DataContract]
	public class DataPoint
	{
		public DataPoint(double x, decimal y)
		{
			this.X = x;
			this.Y = y;
		}

		//Explicitly setting the name to be used while serializing to JSON.
		[DataMember(Name = "x")]
		public double? X = null;

		//Explicitly setting the name to be used while serializing to JSON.
		[DataMember(Name = "y")]
		public Nullable<decimal> Y = null;
	}
}
