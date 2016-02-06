﻿using System;

namespace LinqPost3
{
	public class FakeDatabase
	{

		public Lecture[] Lectures
		{
			get { return _lectures; }
		}

		public Teacher[] Teachers
		{
			get { return _teachers; }
		}

		private static Lecture[] _lectures = new Lecture[]
		{
			new Lecture { Id = 1, TeacherId = 6, Name = "Medical-Surgical" },
			new Lecture { Id = 2, TeacherId = 20, Name = "Consumer Behaviour" },
			new Lecture { Id = 3, TeacherId = 24, Name = "HSM" },
			new Lecture { Id = 4, TeacherId = 24, Name = "Bathrooms" },
			new Lecture { Id = 5, TeacherId = 27, Name = "MRO Management" },
			new Lecture { Id = 6, TeacherId = 9, Name = "DLC" },
			new Lecture { Id = 7, TeacherId = 16, Name = "Commercial Awareness" },
			new Lecture { Id = 8, TeacherId = 1, Name = "KDB+" },
			new Lecture { Id = 9, TeacherId = 29, Name = "Townhomes" },
			new Lecture { Id = 10, TeacherId = 21, Name = "WLM" },
			new Lecture { Id = 11, TeacherId = 24, Name = "AHU" },
			new Lecture { Id = 12, TeacherId = 21, Name = "Equipment Repair" },
			new Lecture { Id = 13, TeacherId = 15, Name = "iPod" },
			new Lecture { Id = 14, TeacherId = 5, Name = "HAZOP Study" },
			new Lecture { Id = 15, TeacherId = 18, Name = "HR Consulting" },
			new Lecture { Id = 16, TeacherId = 11, Name = "Errors &amp; Omissions" },
			new Lecture { Id = 17, TeacherId = 29, Name = "PMBOK" },
			new Lecture { Id = 18, TeacherId = 17, Name = "Xoops" },
			new Lecture { Id = 19, TeacherId = 29, Name = "sFlow" },
			new Lecture { Id = 20, TeacherId = 11, Name = "PPBES" },
			new Lecture { Id = 21, TeacherId = 14, Name = "RPR" },
			new Lecture { Id = 22, TeacherId = 16, Name = "Group Therapy" },
			new Lecture { Id = 23, TeacherId = 4, Name = "BGAN" },
			new Lecture { Id = 24, TeacherId = 5, Name = "Legal Advice" },
			new Lecture { Id = 25, TeacherId = 15, Name = "DWR" },
			new Lecture { Id = 26, TeacherId = 30, Name = "Talent Acquisition" },
			new Lecture { Id = 27, TeacherId = 20, Name = "HTFS" },
			new Lecture { Id = 28, TeacherId = 16, Name = "Juniper Technologies" },
			new Lecture { Id = 29, TeacherId = 9, Name = "DHS" },
			new Lecture { Id = 30, TeacherId = 29, Name = "GL" },
			new Lecture { Id = 31, TeacherId = 1, Name = "Executive Protection" },
			new Lecture { Id = 32, TeacherId = 25, Name = "Vital Signs" },
			new Lecture { Id = 33, TeacherId = 18, Name = "Fixed Income" },
			new Lecture { Id = 34, TeacherId = 18, Name = "Eclipse" },
			new Lecture { Id = 35, TeacherId = 16, Name = "Sleep Disorders" },
			new Lecture { Id = 36, TeacherId = 18, Name = "SFR Certified" },
			new Lecture { Id = 37, TeacherId = 13, Name = "AutoCAD Architecture" },
			new Lecture { Id = 38, TeacherId = 28, Name = "Behavioral Health" },
			new Lecture { Id = 39, TeacherId = 5, Name = "Pension Funds" },
			new Lecture { Id = 40, TeacherId = 22, Name = "HMC" },
			new Lecture { Id = 41, TeacherId = 10, Name = "VDSL" },
			new Lecture { Id = 42, TeacherId = 1, Name = "Full SDLC" },
			new Lecture { Id = 43, TeacherId = 24, Name = "Dunn &amp; Bradstreet" },
			new Lecture { Id = 44, TeacherId = 6, Name = "SV" },
			new Lecture { Id = 45, TeacherId = 30, Name = "XATA" },
			new Lecture { Id = 46, TeacherId = 24, Name = "Software Quality Assurance" },
			new Lecture { Id = 47, TeacherId = 22, Name = "Behavior Based Safety" },
			new Lecture { Id = 48, TeacherId = 18, Name = "Scanning Electron Microscopy" },
			new Lecture { Id = 49, TeacherId = 28, Name = "Pallet Jack" },
			new Lecture { Id = 50, TeacherId = 2, Name = "Go-to-market Strategy" },
			new Lecture { Id = 51, TeacherId = 15, Name = "NCS" },
			new Lecture { Id = 52, TeacherId = 7, Name = "Verilog" },
			new Lecture { Id = 53, TeacherId = 27, Name = "Legislative Affairs" },
			new Lecture { Id = 54, TeacherId = 9, Name = "PPMS" },
			new Lecture { Id = 55, TeacherId = 4, Name = "Economic Research" },
			new Lecture { Id = 56, TeacherId = 12, Name = "GMLAN" },
			new Lecture { Id = 57, TeacherId = 27, Name = "ASP.NET MVC" },
			new Lecture { Id = 58, TeacherId = 30, Name = "Piano" },
			new Lecture { Id = 59, TeacherId = 1, Name = "GDS systems" },
			new Lecture { Id = 60, TeacherId = 15, Name = "AVEVA PDMS" },
			new Lecture { Id = 61, TeacherId = 17, Name = "EOC" },
			new Lecture { Id = 62, TeacherId = 4, Name = "Radio Broadcasting" },
			new Lecture { Id = 63, TeacherId = 19, Name = "JAX-WS" },
			new Lecture { Id = 64, TeacherId = 22, Name = "Jitterbit" },
			new Lecture { Id = 65, TeacherId = 26, Name = "Business Transformation" },
			new Lecture { Id = 66, TeacherId = 24, Name = "CCDP" },
			new Lecture { Id = 67, TeacherId = 12, Name = "Tour Management" },
			new Lecture { Id = 68, TeacherId = 13, Name = "Quality Assurance" },
			new Lecture { Id = 69, TeacherId = 2, Name = "JBoss Seam" },
			new Lecture { Id = 70, TeacherId = 17, Name = "GFI" },
			new Lecture { Id = 71, TeacherId = 15, Name = "SSPS" },
			new Lecture { Id = 72, TeacherId = 25, Name = "LGD" },
			new Lecture { Id = 73, TeacherId = 15, Name = "Cycling" },
			new Lecture { Id = 74, TeacherId = 19, Name = "Test Planning" },
			new Lecture { Id = 75, TeacherId = 11, Name = "European Affairs" },
			new Lecture { Id = 76, TeacherId = 1, Name = "Biblical Studies" },
			new Lecture { Id = 77, TeacherId = 20, Name = "JDE CNC" },
			new Lecture { Id = 78, TeacherId = 30, Name = "UltraTax CS" },
			new Lecture { Id = 79, TeacherId = 9, Name = "IB" },
			new Lecture { Id = 80, TeacherId = 19, Name = "FCNSP" },
			new Lecture { Id = 81, TeacherId = 6, Name = "Hydrology" },
			new Lecture { Id = 82, TeacherId = 9, Name = "TVC" },
			new Lecture { Id = 83, TeacherId = 5, Name = "Sea Kayaking" },
			new Lecture { Id = 84, TeacherId = 21, Name = "NI LabVIEW" },
			new Lecture { Id = 85, TeacherId = 1, Name = "SSAE 16" },
			new Lecture { Id = 86, TeacherId = 13, Name = "GNU C" },
			new Lecture { Id = 87, TeacherId = 22, Name = "Corporate Finance" },
			new Lecture { Id = 88, TeacherId = 22, Name = "Inventory Management" },
			new Lecture { Id = 89, TeacherId = 24, Name = "Geometric Dimensioning &amp; Tolerancing" },
			new Lecture { Id = 90, TeacherId = 29, Name = "Project Oversight" },
			new Lecture { Id = 91, TeacherId = 29, Name = "Beverage Industry" },
			new Lecture { Id = 92, TeacherId = 10, Name = "AAUS Scientific Diver" },
			new Lecture { Id = 93, TeacherId = 6, Name = "Freelance Writing" },
			new Lecture { Id = 94, TeacherId = 4, Name = "VLSI" },
			new Lecture { Id = 95, TeacherId = 12, Name = "Pygame" },
			new Lecture { Id = 96, TeacherId = 13, Name = "Online Communications" },
			new Lecture { Id = 97, TeacherId = 15, Name = "RIP" },
			new Lecture { Id = 98, TeacherId = 17, Name = "Skin Care Products" },
			new Lecture { Id = 99, TeacherId = 13, Name = "UCP" },
			new Lecture { Id = 100, TeacherId = 14, Name = "Ghostwriting" },
		};

		private static Teacher[] _teachers = new Teacher[]
		{
			new Teacher { Id = 1, GivenName= "Janet", LastName = "Nelson", Age = 41, Email = "dnelson0@ft.com" },
			new Teacher { Id = 2, GivenName= "Martha", LastName = "Brooks", Age = 42, Email = "mbrooks1@msu.edu" },
			new Teacher { Id = 3, GivenName= "Janice", LastName = "Franklin", Age = 44, Email = "jfranklin2@cornell.edu" },
			new Teacher { Id = 4, GivenName= "Martha", LastName = "Burke", Age = 26, Email = "" },
			new Teacher { Id = 5, GivenName= "Virginia", LastName = "Williams", Age = 50, Email = "vwilliams4@wikispaces.com" },
			new Teacher { Id = 6, GivenName= "Jonathan", LastName = "Graham", Age = 44, Email = "" },
			new Teacher { Id = 7, GivenName= "Helen", LastName = "Snyder", Age = 41, Email = "hsnyder6@tuttocitta.it" },
			new Teacher { Id = 8, GivenName= "George", LastName = "Jackson", Age = 21, Email = "gjackson7@apple.com" },
			new Teacher { Id = 9, GivenName= "Carol", LastName = "Frazier", Age = 38, Email = "cfrazier8@taobao.com" },
			new Teacher { Id = 10, GivenName= "Janet", LastName = "Little", Age = 38, Email = "" },
			new Teacher { Id = 11, GivenName= "Frank", LastName = "Hunt", Age = 24, Email = "" },
			new Teacher { Id = 12, GivenName= "Carl", LastName = "Foster", Age = 36, Email = "cfosterb@harvard.edu" },
			new Teacher { Id = 13, GivenName= "Margaret", LastName = "Burton", Age = 77, Email = "" },
			new Teacher { Id = 14, GivenName= "Carol", LastName = "James", Age = 30, Email = "cjamesd@com.com" },
			new Teacher { Id = 15, GivenName= "Shawn", LastName = "Hanson", Age = 40, Email = "shansone@linkedin.com" },
			new Teacher { Id = 16, GivenName= "Eugene", LastName = "Stevens", Age = 18, Email = "estevensf@g.co" },
			new Teacher { Id = 17, GivenName= "Maria", LastName = "Myers", Age = 23, Email = "mmyersg@prnewswire.com" },
			new Teacher { Id = 18, GivenName= "Terry", LastName = "Williams", Age = 26, Email = "tlawrenceh@wiley.com" },
			new Teacher { Id = 19, GivenName= "Phyllis", LastName = "Burns", Age = 33, Email = "pburnsi@umn.edu" },
			new Teacher { Id = 20, GivenName= "Emily", LastName = "Robertson", Age = 35, Email = "erobertsonj@oracle.com" },
			new Teacher { Id = 21, GivenName= "Janet", LastName = "Gordon", Age = 45, Email = "cgordonk@barnesandnoble.com" },
			new Teacher { Id = 22, GivenName= "Linda", LastName = "Ramirez", Age = 24, Email = "lramirezl@bravesites.com" },
			new Teacher { Id = 23, GivenName= "Lillian", LastName = "Lynch", Age = 39, Email = "llynchm@thetimes.co.uk" },
			new Teacher { Id = 24, GivenName= "Christopher", LastName = "Jackson", Age = 54, Email = "" },
			new Teacher { Id = 25, GivenName= "Laura", LastName = "Williams", Age = 67, Email = "" },
			new Teacher { Id = 26, GivenName= "William", LastName = "Allen", Age = 16, Email = "wallenp@army.mil" },
			new Teacher { Id = 27, GivenName= "Henry", LastName = "Arnold", Age = 33, Email = "harnoldq@exblog.jp" },
			new Teacher { Id = 28, GivenName= "Nancy", LastName = "Peters", Age = 39, Email = "npetersr@engadget.com" },
			new Teacher { Id = 29, GivenName= "Janet", LastName = "Torres", Age = 50, Email = "storress@npr.org" },
			new Teacher { Id = 30, GivenName= "Ruth", LastName = "Williams", Age = 26, Email = "rbishopt@ezinearticles.com" },
		};
	}
}

