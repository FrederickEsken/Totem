﻿using SQLite;

namespace TotemAppCore {
	public class Totem {
		[PrimaryKey, AutoIncrement]
		public string number { get; set; }
		public string nid { get; set; }
		public string title { get; set; }
		public string body { get; set; }
		public string synonyms { get; set; }
		public bool selected { get; set; }
	}
}