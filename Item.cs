// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;

namespace CSharpTest
{
	public class Item
	{
		public int Id{ set; get; }

		public String Name{ set; get; }

		public int Price{ set; get; }

		public String Seller{ set; get; }

		public Item ()
		{
		}

		public Item (String name, int price, String seller)
		{
			this.Name = name;
			this.Price = price;
			this.Seller = seller;
		}

		public override string ToString ()
		{
			return string.Format ("[Item: Id={0}, Name={1}, Price={2}, Seller={3}]", Id, Name, Price, Seller);
		}
		
	}
}

