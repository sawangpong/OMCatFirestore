using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMCatFireStore
{
	[FirestoreData]
	public class ProductRecord
	{
		[FirestoreProperty]
		public string Id { get; set; }
		
		[FirestoreProperty]
		public string Name { get; set; }
		
		[FirestoreProperty]
		public string Detail { get; set; }
		
		[FirestoreProperty]
		public string PathImage { get; set; }
		public string Image { get; set; }
	}

}
