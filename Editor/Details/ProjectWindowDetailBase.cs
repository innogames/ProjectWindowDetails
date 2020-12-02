using UnityEditor;
using UnityEngine;

namespace ProjectWindowDetail.Details
{
	/// <summary>
	/// Base class of custom columns to be drawn by ProjectWindowDetails
	/// </summary>
	public abstract class ProjectWindowDetailBase
	{
		private const string ShowPrefsKey = "ProjectWindowDetails.Show.";
		public int ColumnWidth = 100;
		public string Name = "Base";
		public TextAlignment Alignment = TextAlignment.Left;

		public bool Visible { get; set; }

		public abstract string GetLabel(string guid, string assetPath, Object asset);
	}
}
