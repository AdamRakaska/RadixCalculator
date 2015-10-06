﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadixCalculator
{
	public partial class MixedRadixSystem
	{
		/// <summary>
		/// Provides access to pre-defined RadixCalculator class instances
		/// </summary>
		public static class Factory
		{
			public static MixedRadixSystem TimeDateRadix52()
			{
				List<long> SortableDate = new List<long>();

				SortableDate.Add(60); // Seconds in minute
				SortableDate.Add(60); // Minutes in hour
				SortableDate.Add(24); // Hours in day
				SortableDate.Add(7);  // Days a week
				SortableDate.Add(52); // Weeks a year

				return new MixedRadixSystem(SortableDate);
			}

			public static MixedRadixSystem TimeDateRadix365()
			{
				List<long> SortableDate = new List<long>();

				SortableDate.Add(60); // Seconds in minute
				SortableDate.Add(60); // Minutes in hour
				SortableDate.Add(24); // Hours in day
				SortableDate.Add(365);// Days in a year

				return new MixedRadixSystem(SortableDate);
			}

			public static MixedRadixSystem Hexadecimal()
			{
				Dictionary<long, string> symbolDict = new Dictionary<long, string>();

				symbolDict.Add(0, "0");
				symbolDict.Add(1, "1");
				symbolDict.Add(2, "2");
				symbolDict.Add(3, "3");
				symbolDict.Add(4, "4");
				symbolDict.Add(5, "5");
				symbolDict.Add(6, "6");
				symbolDict.Add(7, "7");
				symbolDict.Add(8, "8");
				symbolDict.Add(9, "9");
				symbolDict.Add(10, "A");
				symbolDict.Add(11, "B");
				symbolDict.Add(12, "C");
				symbolDict.Add(13, "D");
				symbolDict.Add(14, "E");
				symbolDict.Add(15, "F");

				return new MixedRadixSystem(16, 10, symbolDict);
			}

			public static MixedRadixSystem Symbols5()
			{
				Dictionary<long, string> symbolDict = new Dictionary<long, string>();

				symbolDict.Add(0, ".");
				symbolDict.Add(1, "|");
				symbolDict.Add(2, "V");
				symbolDict.Add(3, "Y");
				symbolDict.Add(4, "X");
				symbolDict.Add(5, "*");
				
				return new MixedRadixSystem(5, 10, symbolDict);
			}

			public static MixedRadixSystem Symbols9()
			{
				Dictionary<long, string> symbolDict = new Dictionary<long, string>();

				symbolDict.Add(0, "_");
				symbolDict.Add(1, "-");
				symbolDict.Add(2, "+");
				symbolDict.Add(3, "x");
				symbolDict.Add(4, "V");
				symbolDict.Add(5, "^");
				symbolDict.Add(6, "<");
				symbolDict.Add(7, ">");
				symbolDict.Add(8, "X");
				symbolDict.Add(9, "#");

				return new MixedRadixSystem(9, 10, symbolDict);
			}

			public static MixedRadixSystem Lines()
			{
				Dictionary<long, string> symbolDict = new Dictionary<long, string>();

				symbolDict.Add(0, " ");
				symbolDict.Add(1, "|");
				symbolDict.Add(2, "V");
				symbolDict.Add(3, "Y");
				symbolDict.Add(4, "X");
				symbolDict.Add(5, "*");

				return new MixedRadixSystem(5, 10, symbolDict);
			}

			public static MixedRadixSystem Base2()
			{
				return new MixedRadixSystem(2, 8);
			}

			public static MixedRadixSystem Base10()
			{
				return new MixedRadixSystem(10, 7);
			}

			public static MixedRadixSystem Base12()
			{
				return new MixedRadixSystem(12, 8);
			}

			public static MixedRadixSystem Base16()
			{
				return new MixedRadixSystem(16, 8);
			}
		}
	}
}
