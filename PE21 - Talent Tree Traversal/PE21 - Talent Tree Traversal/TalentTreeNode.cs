using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21___Talent_Tree_Traversal
{
	public class TalentTreeNode
	{
		// Attributes.
		private TalentTreeNode left;
		private TalentTreeNode right;
		private string ability;
		private bool achieved;

		// Properties.
		public TalentTreeNode Left
		{
			get { return this.left; }
			set { this.left = value; }
		}

		public TalentTreeNode Right
		{
			get { return this.right; }
			set { this.right = value; }
		}

		public string Ability
		{
			get { return this.ability; }
		}

		public bool Achieved
		{
			get { return this.achieved; }
			set { this.achieved = value; }
		}

		// Constructor.
		public TalentTreeNode(string talentName, bool attained)
		{
			ability = talentName;
			achieved = attained;
			left = null;
			right = null;
		}


		// Print methods.
		public string leftToString()
		{
			return left.Ability;
		}

		public string rightToString()
		{
			return right.Ability;
		}

		public string toString()
		{
			string str = "";

			str += "Element Data: " + this.Ability;
			str += "\t";
			str += "Left: " + leftToString();
			str += "\t";
			str += "Right: " + rightToString();
			str += "\n";

			return str;
		}
	}
}
