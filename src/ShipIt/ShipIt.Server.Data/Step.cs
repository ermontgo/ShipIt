﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipIt.Server.Data
{
	public class Step
	{
		public int Id { get; set; }
		public int Name { get; set; }
		public string ToolClassName { get; set; }
		public DateTimeOffset CreatedDate { get; set; }

		public string ArgumentsXml { get; set; }
	}
}
